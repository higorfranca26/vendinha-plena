using System;
using System.Windows.Forms;
using VendinhaPlena.Desktop.Data;
using VendinhaPlena.Desktop.Services;

namespace VendinhaPlena.Desktop
{
    public partial class FormPendurarDivida : Form
    {
        private readonly DividaService _servicoDeDividas;

        public FormPendurarDivida(AppDbContext bancoDeDados)
        {
            InitializeComponent();
            _servicoDeDividas = new DividaService(bancoDeDados);

            btnSalvar.Click += btnSalvar_Click;
            btnCancelar.Click += btnCancelar_Click;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdCliente.Text, out int idCliente) || !decimal.TryParse(txtValor.Text, out decimal valorDaDivida))
            {
                MessageBox.Show("Por favor, preencha o ID do cliente e o valor da dívida utilizando apenas números válidos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string resultadoDaOperacao = _servicoDeDividas.PendurarDivida(idCliente, valorDaDivida);

            if (resultadoDaOperacao == "Sucesso")
            {
                MessageBox.Show("A nova dívida foi registrada na caderneta do cliente com sucesso!", "Registro Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(resultadoDaOperacao, "Aviso Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}