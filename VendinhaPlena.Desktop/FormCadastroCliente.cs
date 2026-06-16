using System;
using System.Linq;
using System.Windows.Forms;
using VendinhaPlena.Desktop.Data;
using VendinhaPlena.Desktop.Models;
using VendinhaPlena.Desktop.Services;

namespace VendinhaPlena.Desktop
{
    public partial class FormCadastroCliente : Form
    {
        private readonly ClienteService _servicoDeClientes;

        public FormCadastroCliente(AppDbContext bancoDeDados)
        {
            InitializeComponent();
            _servicoDeClientes = new ClienteService(bancoDeDados);

            btnSalvar.Click += btnSalvar_Click;
            btnCancelar.Click += btnCancelar_Click;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var novoCliente = new Cliente
            {
                NomeCompleto = txtNome.Text.Trim(),
                Cpf = new string(txtCpf.Text.Where(char.IsDigit).ToArray()),
                DataNascimento = dtpDataNascimento.Value,
                Email = string.IsNullOrWhiteSpace(txtEmail.Text) ? null : txtEmail.Text.Trim()
            };

            string resultadoDaOperacao = _servicoDeClientes.SalvarCliente(novoCliente);

            if (resultadoDaOperacao == "Sucesso")
            {
                MessageBox.Show("O cliente foi cadastrado com sucesso!", "Cadastro Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
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