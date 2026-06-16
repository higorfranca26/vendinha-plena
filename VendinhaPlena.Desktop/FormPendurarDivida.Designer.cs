namespace VendinhaPlena.Desktop
{
    partial class FormPendurarDivida
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
            txtIdCliente = new TextBox();
            txtValor = new TextBox();
            btnSalvar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txtIdCliente
            // 
            txtIdCliente.AccessibleName = "";
            txtIdCliente.BorderStyle = BorderStyle.FixedSingle;
            txtIdCliente.Location = new Point(94, 106);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(308, 23);
            txtIdCliente.TabIndex = 0;
            // 
            // txtValor
            // 
            txtValor.BorderStyle = BorderStyle.FixedSingle;
            txtValor.Cursor = Cursors.IBeam;
            txtValor.Location = new Point(94, 169);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(308, 23);
            txtValor.TabIndex = 1;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.DarkSlateGray;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Location = new Point(327, 229);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 88);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 3;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 151);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 4;
            label2.Text = "Divida:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(128, 23);
            label3.Name = "label3";
            label3.Size = new Size(220, 37);
            label3.TabIndex = 5;
            label3.Text = "Cadastar Divida";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.Menu;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(220, 229);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // FormPendurarDivida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 283);
            Controls.Add(btnCancelar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSalvar);
            Controls.Add(txtValor);
            Controls.Add(txtIdCliente);
            MaximizeBox = false;
            Name = "FormPendurarDivida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Divida";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdCliente;
        private TextBox txtValor;
        private Button btnSalvar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCancelar;
        
    }
}