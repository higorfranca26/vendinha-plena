using System;
using System.Linq;
using System.Windows.Forms;
using VendinhaPlena.Desktop.Data;
using VendinhaPlena.Desktop.Services;

namespace VendinhaPlena.Desktop
{
    public partial class FormEditarCliente : Form
    {
        private readonly ClienteService _servicoDeClientes;
        private readonly int _idCliente;

        public FormEditarCliente(AppDbContext bancoDeDados, int idCliente)
        {
            InitializeComponent();
            _servicoDeClientes = new ClienteService(bancoDeDados);
            _idCliente = idCliente;

            this.Load += FormEditarCliente_Load;
            btnSalvar.Click += btnSalvar_Click;
            btnCancelar.Click += btnCancelar_Click;
        }

        private void FormEditarCliente_Load(object sender, EventArgs e)
        {
            var clienteParaEdicao = _servicoDeClientes.ObterClientePorId(_idCliente);

            if (clienteParaEdicao != null)
            {
                txtNome.Text = clienteParaEdicao.NomeCompleto;
                txtCpf.Text = clienteParaEdicao.Cpf;
                dtpDataNascimento.Value = clienteParaEdicao.DataNascimento;
                txtEmail.Text = clienteParaEdicao.Email;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var clienteParaEdicao = _servicoDeClientes.ObterClientePorId(_idCliente);

            if (clienteParaEdicao == null) return;

            clienteParaEdicao.NomeCompleto = txtNome.Text.Trim();
            clienteParaEdicao.Cpf = new string(txtCpf.Text.Where(char.IsDigit).ToArray());
            clienteParaEdicao.DataNascimento = dtpDataNascimento.Value;
            clienteParaEdicao.Email = string.IsNullOrWhiteSpace(txtEmail.Text) ? null : txtEmail.Text.Trim();

            string resultadoDaOperacao = _servicoDeClientes.SalvarCliente(clienteParaEdicao);

            if (resultadoDaOperacao == "Sucesso")
            {
                MessageBox.Show("Os dados do cliente foram atualizados com sucesso!", "Atualização Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(resultadoDaOperacao, "Atenção aos Dados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}