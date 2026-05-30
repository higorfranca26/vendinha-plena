using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;
using VendinhaPlena.Desktop.Data;
using VendinhaPlena.Desktop.Models;

namespace VendinhaPlena.Desktop
{
    public partial class Form1 : Form
    {
        private AppDbContext _context;

        public Form1()
        {
            InitializeComponent();

            _context = new AppDbContext();
            _context.Database.EnsureCreated();

            this.Load += Form1_Load;
            btnPendurarDivida.Click += btnPendurarDivida_Click;
            btnPagarDivida.Click += btnPagarDivida_Click;
            btnEditarCliente.Click += btnEditarCliente_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void AtualizarTabela()
        {
            var clientes = _context.Clientes
                .Include(c => c.Dividas)
                .ToList()
                .OrderByDescending(c => c.TotalDevido)
                .Take(10)
                .Select(c => new
                {
                    c.Id,
                    Nome = c.NomeCompleto,
                    c.Cpf,
                    Idade = c.Idade,
                    Total_Devido = $"R$ {c.TotalDevido:F2}"
                })
                .ToList();

            gridClientes.DataSource = clientes;
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            var formCadastro = new FormCadastroCliente(_context);
            formCadastro.ShowDialog();

            AtualizarTabela();
        }

        private void btnPendurarDivida_Click(object sender, EventArgs e)
        {
            var formDivida = new FormPendurarDivida(_context);
            formDivida.ShowDialog();

            AtualizarTabela();
        }

        private void btnPagarDivida_Click(object sender, EventArgs e)
        {
            var formPagar = new FormPagarDivida(_context);
            formPagar.ShowDialog();

            AtualizarTabela();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (gridClientes.CurrentRow == null)
            {
                MessageBox.Show("Selecione um cliente na tabela primeiro para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idSelecionado = Convert.ToInt32(gridClientes.CurrentRow.Cells["Id"].Value);

            var formEditar = new FormEditarCliente(_context, idSelecionado);
            formEditar.ShowDialog();

            AtualizarTabela();
        }

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            if (gridClientes.CurrentRow == null)
            {
                MessageBox.Show("Selecione um cliente na tabela primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idSelecionado = Convert.ToInt32(gridClientes.CurrentRow.Cells["Id"].Value);
            var cliente = _context.Clientes.Find(idSelecionado);

            if (cliente != null)
            {
                var confirmacao = MessageBox.Show(
                    $"Tem certeza que deseja excluir o cliente {cliente.NomeCompleto}?\n\nAVISO: Todas as dívidas atreladas a ele também serão apagadas permanentemente!",
                    "Confirmar Exclusão",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmacao == DialogResult.Yes)
                {
                    _context.Clientes.Remove(cliente);
                    _context.SaveChanges();

                    MessageBox.Show("Cliente excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarTabela();
                }
            }
        }
    }
}