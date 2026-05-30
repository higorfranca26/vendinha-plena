namespace VendinhaPlena.Desktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnNovoCliente = new Button();
            btnPendurarDivida = new Button();
            gridClientes = new DataGridView();
            label1 = new Label();
            btnPagarDivida = new Button();
            btnEditarCliente = new Button();
            btnExcluirCliente = new Button();
            ((System.ComponentModel.ISupportInitialize)gridClientes).BeginInit();
            SuspendLayout();
            // 
            // btnNovoCliente
            // 
            btnNovoCliente.Location = new Point(74, 303);
            btnNovoCliente.Name = "btnNovoCliente";
            btnNovoCliente.Size = new Size(104, 38);
            btnNovoCliente.TabIndex = 0;
            btnNovoCliente.Text = "Novo Cliente";
            btnNovoCliente.UseVisualStyleBackColor = true;
            btnNovoCliente.Click += btnNovoCliente_Click;
            // 
            // btnPendurarDivida
            // 
            btnPendurarDivida.Location = new Point(184, 303);
            btnPendurarDivida.Name = "btnPendurarDivida";
            btnPendurarDivida.Size = new Size(104, 38);
            btnPendurarDivida.TabIndex = 1;
            btnPendurarDivida.Text = "Pendurar Divida";
            btnPendurarDivida.UseVisualStyleBackColor = true;
            btnPendurarDivida.Click += Form1_Load;
            // 
            // gridClientes
            // 
            gridClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridClientes.Location = new Point(74, 68);
            gridClientes.Name = "gridClientes";
            gridClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridClientes.Size = new Size(545, 211);
            gridClientes.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(188, 18);
            label1.Name = "label1";
            label1.Size = new Size(287, 47);
            label1.TabIndex = 3;
            label1.Text = "Lista de Clientes";
            // 
            // btnPagarDivida
            // 
            btnPagarDivida.Location = new Point(294, 303);
            btnPagarDivida.Name = "btnPagarDivida";
            btnPagarDivida.Size = new Size(104, 38);
            btnPagarDivida.TabIndex = 4;
            btnPagarDivida.Text = "Pagar Divida";
            btnPagarDivida.UseVisualStyleBackColor = true;
            // 
            // btnEditarCliente
            // 
            btnEditarCliente.Location = new Point(404, 303);
            btnEditarCliente.Name = "btnEditarCliente";
            btnEditarCliente.Size = new Size(104, 38);
            btnEditarCliente.TabIndex = 5;
            btnEditarCliente.Text = "Editar";
            btnEditarCliente.UseVisualStyleBackColor = true;
            // 
            // btnExcluirCliente
            // 
            btnExcluirCliente.Location = new Point(514, 303);
            btnExcluirCliente.Name = "btnExcluirCliente";
            btnExcluirCliente.Size = new Size(104, 38);
            btnExcluirCliente.TabIndex = 6;
            btnExcluirCliente.Text = "Excluir";
            btnExcluirCliente.UseVisualStyleBackColor = true;
            btnExcluirCliente.Click += btnExcluirCliente_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 370);
            Controls.Add(btnExcluirCliente);
            Controls.Add(btnEditarCliente);
            Controls.Add(btnPagarDivida);
            Controls.Add(label1);
            Controls.Add(gridClientes);
            Controls.Add(btnPendurarDivida);
            Controls.Add(btnNovoCliente);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)gridClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNovoCliente;
        private Button btnPendurarDivida;
        private DataGridView gridClientes;
        private Label label1;
        private Button btnPagarDivida;
        private Button btnEditarCliente;
        private Button btnExcluirCliente;
    }
}
