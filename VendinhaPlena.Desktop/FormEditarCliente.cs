using System;
using System.Linq;
using System.Windows.Forms;
using VendinhaPlena.Desktop.Data;
using VendinhaPlena.Desktop.Validations;

namespace VendinhaPlena.Desktop
{
    public partial class FormEditarCliente : Form
    {
        private readonly AppDbContext _context;
        private readonly int _clienteId;

        public FormEditarCliente(AppDbContext context, int clienteId)
        {
            InitializeComponent();

            _context = context;
            _clienteId = clienteId;

            this.Load += FormEditarCliente_Load;
            btnSalvar.Click += btnSalvar_Click;
        }

        private void FormEditarCliente_Load(object sender, EventArgs e)
        {
            var cliente = _context.Clientes.Find(_clienteId);

            if (cliente != null)
            {
                txtNome.Text = cliente.NomeCompleto;
                txtCpf.Text = cliente.Cpf;
                dtpDataNascimento.Value = cliente.DataNascimento;
                txtEmail.Text = cliente.Email;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string cpf = new string(txtCpf.Text.Where(char.IsDigit).ToArray());
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(cpf) || cpf.Length != 11)
            {
                MessageBox.Show("Nome e CPF são obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidadorCpf.IsCpfValido(cpf))
            {
                MessageBox.Show("O CPF informado é inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool cpfPertenceAOutro = _context.Clientes.Any(c => c.Cpf == cpf && c.Id != _clienteId);

            if (cpfPertenceAOutro)
            {
                MessageBox.Show("Este CPF já está sendo usado por outro cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var cliente = _context.Clientes.Find(_clienteId);

            if (cliente != null)
            {
                cliente.NomeCompleto = nome;
                cliente.Cpf = cpf;
                cliente.DataNascimento = dtpDataNascimento.Value;
                cliente.Email = string.IsNullOrWhiteSpace(email) ? null : email;

                _context.SaveChanges();

                MessageBox.Show("Dados atualizados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}