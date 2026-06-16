using System;
using System.Windows.Forms;
using VendinhaPlena.Desktop.Data;
using VendinhaPlena.Desktop.Services;

namespace VendinhaPlena.Desktop
{
    public partial class Form1 : Form
    {
        private AppDbContext _bancoDeDados;
        private ClienteService _servicoDeClientes;

        private int _paginaAtual = 1;
        private int _totalDePaginas = 1;

        public Form1()
        {
            InitializeComponent();

            _bancoDeDados = new AppDbContext();
            _bancoDeDados.Database.EnsureCreated();

            _servicoDeClientes = new ClienteService(_bancoDeDados);

            this.Load += Form1_Load;

            btnBuscar.Click += btnBuscar_Click;
            btnAnterior.Click += btnAnterior_Click;
            btnProximo.Click += btnProximo_Click;

            btnNovoCliente.Click += btnNovoCliente_Click;
            btnEditarCliente.Click += btnEditarCliente_Click;
            btnExcluirCliente.Click += btnExcluirCliente_Click;
            btnPendurarDivida.Click += btnPendurarDivida_Click;
            btnPagarDivida.Click += btnPagarDivida_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void AtualizarTabela()
        {
            string nomeBuscado = txtBusca.Text.Trim();

            var resultado = _servicoDeClientes.ObterClientes(nomeBuscado, _paginaAtual);

            gridClientes.DataSource = resultado.Lista;
            _totalDePaginas = resultado.TotalPaginas;

            lblPagina.Text = $"Página {_paginaAtual} de {_totalDePaginas}";

            btnAnterior.Enabled = _paginaAtual > 1;
            btnProximo.Enabled = _paginaAtual < _totalDePaginas;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _paginaAtual = 1;
            AtualizarTabela();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (_paginaAtual > 1)
            {
                _paginaAtual--;
                AtualizarTabela();
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (_paginaAtual < _totalDePaginas)
            {
                _paginaAtual++;
                AtualizarTabela();
            }
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            var telaCadastro = new FormCadastroCliente(_bancoDeDados);
            telaCadastro.ShowDialog();
            AtualizarTabela();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (gridClientes.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecione um cliente na tabela primeiro para poder editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idClienteSelecionado = Convert.ToInt32(gridClientes.CurrentRow.Cells["Id"].Value);

            var telaEdicao = new FormEditarCliente(_bancoDeDados, idClienteSelecionado);
            telaEdicao.ShowDialog();
            AtualizarTabela();
        }

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            if (gridClientes.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecione um cliente na tabela primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idClienteSelecionado = Convert.ToInt32(gridClientes.CurrentRow.Cells["Id"].Value);
            var cliente = _bancoDeDados.Clientes.Find(idClienteSelecionado);

            if (cliente != null)
            {
                var mensagem = $"Tem certeza que deseja excluir o cliente {cliente.NomeCompleto}?\n\nAVISO: Todas as dívidas vinculadas a este cliente também serão apagadas permanentemente!";
                var confirmacao = MessageBox.Show(mensagem, "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacao == DialogResult.Yes)
                {
                    _bancoDeDados.Clientes.Remove(cliente);
                    _bancoDeDados.SaveChanges();

                    MessageBox.Show("Cliente excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarTabela();
                }
            }
        }

        private void btnPendurarDivida_Click(object sender, EventArgs e)
        {
            var telaDivida = new FormPendurarDivida(_bancoDeDados);
            telaDivida.ShowDialog();
            AtualizarTabela();
        }

        private void btnPagarDivida_Click(object sender, EventArgs e)
        {
            var telaPagar = new FormPagarDivida(_bancoDeDados);
            telaPagar.ShowDialog();
            AtualizarTabela();
        }
    }
}