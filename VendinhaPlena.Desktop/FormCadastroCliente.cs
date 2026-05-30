using System;
using System.Linq;
using System.Windows.Forms;
using VendinhaPlena.Desktop.Data;
using VendinhaPlena.Desktop.Models;
using VendinhaPlena.Desktop.Validations;

namespace VendinhaPlena.Desktop
{
    public partial class FormCadastroCliente : Form
    {
        private readonly AppDbContext _context;

        public FormCadastroCliente(AppDbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string cpf = new string(txtCpf.Text.Where(char.IsDigit).ToArray());
            DateTime dataNascimento = dtpDataNascimento.Value;
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("O campo Nome Completo é obrigatório.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(cpf) || cpf.Length != 11)
            {
                MessageBox.Show("O campo CPF é obrigatório.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCpf.Focus();
                return;
            }

            if (!ValidadorCpf.IsCpfValido(cpf))
            {
                MessageBox.Show("O CPF informado não é válido.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCpf.Focus();
                return;
            }

            bool cpfJaExiste = _context.Clientes.Any(c => c.Cpf == cpf);

            if (cpfJaExiste)
            {
                MessageBox.Show("Já existe um cliente cadastrado com este CPF.", "Erro de Duplicidade", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCpf.Focus();
                return;
            }

            if (!string.IsNullOrEmpty(email))
            {
                if (!email.Contains("@") || !email.Contains("."))
                {
                    MessageBox.Show("O formato do e-mail informado é inválido.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return;
                }
            }

            try
            {
                var novoCliente = new Cliente
                {
                    NomeCompleto = nome,
                    Cpf = cpf,
                    DataNascimento = dataNascimento,
                    Email = string.IsNullOrWhiteSpace(email) ? null : email
                };

                _context.Clientes.Add(novoCliente);
                _context.SaveChanges();

                MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar no banco de dados: {ex.Message}", "Erro Interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}