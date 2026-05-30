using System;
using System.Linq;
using System.Windows.Forms;
using VendinhaPlena.Desktop.Data;
using VendinhaPlena.Desktop.Models;

namespace VendinhaPlena.Desktop
{
    public partial class FormPendurarDivida : Form
    {
        private readonly AppDbContext _context;

        public FormPendurarDivida(AppDbContext context)
        {
            InitializeComponent();

            _context = context;
            btnSalvar.Click += btnSalvar_Click;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdCliente.Text, out int clienteId))
            {
                MessageBox.Show("Por favor, digite um ID de Cliente válido (apenas números).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtValor.Text, out decimal valor) || valor <= 0)
            {
                MessageBox.Show("Por favor, digite um valor válido maior que zero.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var clienteExiste = _context.Clientes.Any(c => c.Id == clienteId);

            if (!clienteExiste)
            {
                MessageBox.Show("Cliente não encontrado com este ID.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool temDividaAberta = _context.Dividas.Any(d => d.ClienteId == clienteId && d.Situacao == false);

            if (temDividaAberta)
            {
                MessageBox.Show("Este cliente já possui uma dívida em aberto! É necessário quitá-la antes de pendurar uma nova.", "Regra de Negócio", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            var novaDivida = new Divida
            {
                ClienteId = clienteId,
                Valor = valor,
                Situacao = false
            };

            _context.Dividas.Add(novaDivida);
            _context.SaveChanges();

            MessageBox.Show("Dívida pendurada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}