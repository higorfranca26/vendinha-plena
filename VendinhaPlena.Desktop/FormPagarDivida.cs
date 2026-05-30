using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using VendinhaPlena.Desktop.Data;

namespace VendinhaPlena.Desktop
{
    public partial class FormPagarDivida : Form
    {
        private readonly AppDbContext _context;
        private int _dividaAbertaId;

        public FormPagarDivida(AppDbContext context)
        {
            InitializeComponent();

            _context = context;
            btnPagar.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdCliente.Text, out int clienteId))
            {
                MessageBox.Show("Digite um ID de Cliente válido (apenas números).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var cliente = _context.Clientes
                .Include(c => c.Dividas)
                .FirstOrDefault(c => c.Id == clienteId);

            if (cliente == null)
            {
                MessageBox.Show("Cliente não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gridDividas.DataSource = null;
                btnPagar.Enabled = false;
                return;
            }

            var listaDividas = cliente.Dividas
                .OrderByDescending(d => d.DataCriacao)
                .Select(d => new
                {
                    Código = d.Id,
                    Valor = $"R$ {d.Valor:F2}",
                    Situação = d.Situacao ? "Paga" : "Em Aberto",
                    Criada_Em = d.DataCriacao.ToString("dd/MM/yyyy"),
                    Paga_Em = d.DataPagamento?.ToString("dd/MM/yyyy") ?? "-"
                })
                .ToList();

            gridDividas.DataSource = listaDividas;

            var dividaAberta = cliente.Dividas.FirstOrDefault(d => d.Situacao == false);

            if (dividaAberta != null)
            {
                _dividaAbertaId = dividaAberta.Id;
                btnPagar.Enabled = true;
            }
            else
            {
                _dividaAbertaId = 0;
                btnPagar.Enabled = false;
                MessageBox.Show("Este cliente não possui dívidas em aberto no momento.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            var confirmacao = MessageBox.Show(
                "Tem certeza que deseja marcar a dívida em aberto como PAGA?",
                "Confirmar Pagamento",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacao == DialogResult.Yes)
            {
                var divida = _context.Dividas.Find(_dividaAbertaId);

                if (divida != null)
                {
                    divida.Situacao = true;
                    divida.DataPagamento = DateTime.Now;

                    _context.SaveChanges();

                    MessageBox.Show("Dívida marcada como paga com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnBuscar_Click(sender, e);
                }
            }
        }
    }
}