namespace VendinhaPlena.Desktop
{
    partial class FormCadastroCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNome = new TextBox();
            txtCpf = new TextBox();
            txtEmail = new TextBox();
            btnCancelar = new Button();
            dtpDataNascimento = new DateTimePicker();
            btnSalvar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(121, 105);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(252, 23);
            txtNome.TabIndex = 0;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(121, 156);
            txtCpf.MaxLength = 20;
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(252, 23);
            txtCpf.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(121, 253);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(252, 23);
            txtEmail.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Gray;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(202, 306);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Location = new Point(121, 204);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(252, 23);
            dtpDataNascimento.TabIndex = 5;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.DarkSlateGray;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.ForeColor = SystemColors.ButtonHighlight;
            btnSalvar.Location = new Point(298, 306);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(163, 23);
            label1.Name = "label1";
            label1.Size = new Size(176, 50);
            label1.TabIndex = 7;
            label1.Text = "Cadastro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 87);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 8;
            label2.Text = "Nome Completo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(121, 138);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 9;
            label3.Text = "CPF:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(121, 186);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 10;
            label4.Text = "Data de Nascimento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(121, 235);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 11;
            label5.Text = "Email:";
            // 
            // FormCadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 416);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSalvar);
            Controls.Add(dtpDataNascimento);
            Controls.Add(btnCancelar);
            Controls.Add(txtEmail);
            Controls.Add(txtCpf);
            Controls.Add(txtNome);
            MaximizeBox = false;
            Name = "FormCadastroCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtCpf;
        private TextBox txtEmail;
        private Button btnCancelar;
        private DateTimePicker dtpDataNascimento;
        private Button btnSalvar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}