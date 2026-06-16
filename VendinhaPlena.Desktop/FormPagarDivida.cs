using System;
using System.Windows.Forms;
using VendinhaPlena.Desktop.Data;
using VendinhaPlena.Desktop.Services;

namespace VendinhaPlena.Desktop
{
    public partial class FormPagarDivida : Form
    {
        private readonly DividaService _servicoDeDividas;
        private int? _idDaDividaPendente = null;

        public FormPagarDivida(AppDbContext bancoDeDados)
        {
            InitializeComponent();
            _servicoDeDividas = new DividaService(bancoDeDados);

            btnBuscar.Click += btnBuscar_Click;
            btnPagar.Click += btnPagar_Click;
            btnPagar.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdCliente.Text, out int idCliente))
            {
                MessageBox.Show("Por favor, informe um número de ID válido para buscar o cliente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var historicoDeDividas = _servicoDeDividas.ObterDividasDoCliente(idCliente, out _idDaDividaPendente);

            if (historicoDeDividas == null)
            {
                MessageBox.Show("Não conseguimos localizar nenhum cliente com o ID informado.", "Cliente Não Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gridDividas.DataSource = null;
                btnPagar.Enabled = false;
                return;
            }

            gridDividas.DataSource = historicoDeDividas;
            btnPagar.Enabled = _idDaDividaPendente.HasValue;

            if (!_idDaDividaPendente.HasValue)
            {
                MessageBox.Show("Excelente! Este cliente não possui nenhuma dívida pendente no momento.", "Situação Regular", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (_idDaDividaPendente.HasValue)
            {
                var confirmacao = MessageBox.Show("Deseja realmente confirmar o pagamento da dívida em aberto deste cliente?", "Confirmar Pagamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacao == DialogResult.Yes)
                {
                    string resultadoDaOperacao = _servicoDeDividas.PagarDivida(_idDaDividaPendente.Value);

                    if (resultadoDaOperacao == "Sucesso")
                    {
                        MessageBox.Show("O pagamento foi registrado e a dívida foi marcada como paga com sucesso!", "Pagamento Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnBuscar_Click(sender, e);
                    }
                }
            }
        }
    }
}