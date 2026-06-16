namespace VendinhaPlena.Desktop
{
    partial class FormEditarCliente
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSalvar = new Button();
            dtpDataNascimento = new DateTimePicker();
            btnCancelar = new Button();
            txtEmail = new TextBox();
            txtCpf = new TextBox();
            txtNome = new TextBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(80, 247);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 22;
            label5.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 198);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 21;
            label4.Text = "Data de Nascimento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 150);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 20;
            label3.Text = "CPF:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 99);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 19;
            label2.Text = "Nome Completo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(122, 35);
            label1.Name = "label1";
            label1.Size = new Size(176, 50);
            label1.TabIndex = 18;
            label1.Text = "Cadastro";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.DarkSlateGray;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.ForeColor = SystemColors.ButtonHighlight;
            btnSalvar.Location = new Point(257, 318);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 17;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Location = new Point(80, 216);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(252, 23);
            dtpDataNascimento.TabIndex = 16;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Gray;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(161, 318);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(80, 265);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(252, 23);
            txtEmail.TabIndex = 14;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(80, 168);
            txtCpf.MaxLength = 11;
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(252, 23);
            txtCpf.TabIndex = 13;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(80, 117);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(252, 23);
            txtNome.TabIndex = 12;
            // 
            // FormEditarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 393);
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
            Name = "FormEditarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Cliente";
            Load += FormEditarCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSalvar;
        private DateTimePicker dtpDataNascimento;
        private Button btnCancelar;
        private TextBox txtEmail;
        private TextBox txtCpf;
        private TextBox txtNome;
    }
}