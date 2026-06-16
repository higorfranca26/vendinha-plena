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
            txtBusca = new TextBox();
            btnBuscar = new Button();
            btnAnterior = new Button();
            btnProximo = new Button();
            lblPagina = new Label();
            ((System.ComponentModel.ISupportInitialize)gridClientes).BeginInit();
            SuspendLayout();
            // 
            // btnNovoCliente
            // 
            btnNovoCliente.Location = new Point(74, 399);
            btnNovoCliente.Name = "btnNovoCliente";
            btnNovoCliente.Size = new Size(104, 38);
            btnNovoCliente.TabIndex = 0;
            btnNovoCliente.Text = "Novo Cliente";
            btnNovoCliente.UseVisualStyleBackColor = true;
            // 
            // btnPendurarDivida
            // 
            btnPendurarDivida.Location = new Point(515, 399);
            btnPendurarDivida.Name = "btnPendurarDivida";
            btnPendurarDivida.Size = new Size(104, 38);
            btnPendurarDivida.TabIndex = 1;
            btnPendurarDivida.Text = "Pendurar Divida";
            btnPendurarDivida.UseVisualStyleBackColor = true;
            btnPendurarDivida.Click += Form1_Load;
            // 
            // gridClientes
            // 
            gridClientes.AllowUserToAddRows = false;
            gridClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridClientes.Location = new Point(74, 88);
            gridClientes.Name = "gridClientes";
            gridClientes.ReadOnly = true;
            gridClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridClientes.Size = new Size(545, 276);
            gridClientes.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(184, 9);
            label1.Name = "label1";
            label1.Size = new Size(287, 47);
            label1.TabIndex = 3;
            label1.Text = "Lista de Clientes";
            // 
            // btnPagarDivida
            // 
            btnPagarDivida.Location = new Point(515, 454);
            btnPagarDivida.Name = "btnPagarDivida";
            btnPagarDivida.Size = new Size(104, 38);
            btnPagarDivida.TabIndex = 4;
            btnPagarDivida.Text = "Pagar Divida";
            btnPagarDivida.UseVisualStyleBackColor = true;
            // 
            // btnEditarCliente
            // 
            btnEditarCliente.Location = new Point(184, 399);
            btnEditarCliente.Name = "btnEditarCliente";
            btnEditarCliente.Size = new Size(104, 38);
            btnEditarCliente.TabIndex = 5;
            btnEditarCliente.Text = "Editar";
            btnEditarCliente.UseVisualStyleBackColor = true;
            // 
            // btnExcluirCliente
            // 
            btnExcluirCliente.Location = new Point(74, 454);
            btnExcluirCliente.Name = "btnExcluirCliente";
            btnExcluirCliente.Size = new Size(104, 38);
            btnExcluirCliente.TabIndex = 6;
            btnExcluirCliente.Text = "Excluir";
            btnExcluirCliente.UseVisualStyleBackColor = true;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(74, 59);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(460, 23);
            txtBusca.TabIndex = 8;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(540, 59);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Pesquisar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(178, 370);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(75, 23);
            btnAnterior.TabIndex = 10;
            btnAnterior.Text = "Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnProximo
            // 
            btnProximo.Location = new Point(443, 370);
            btnProximo.Name = "btnProximo";
            btnProximo.Size = new Size(75, 23);
            btnProximo.TabIndex = 11;
            btnProximo.Text = "Proximo";
            btnProximo.UseVisualStyleBackColor = true;
            // 
            // lblPagina
            // 
            lblPagina.AutoSize = true;
            lblPagina.Location = new Point(311, 378);
            lblPagina.Name = "lblPagina";
            lblPagina.Size = new Size(77, 15);
            lblPagina.TabIndex = 12;
            lblPagina.Text = "Pagina 1 de 1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 497);
            Controls.Add(lblPagina);
            Controls.Add(btnProximo);
            Controls.Add(btnAnterior);
            Controls.Add(btnBuscar);
            Controls.Add(txtBusca);
            Controls.Add(btnExcluirCliente);
            Controls.Add(btnEditarCliente);
            Controls.Add(btnPagarDivida);
            Controls.Add(label1);
            Controls.Add(gridClientes);
            Controls.Add(btnPendurarDivida);
            Controls.Add(btnNovoCliente);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vendinha Plena";
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
        private TextBox txtBusca;
        private Button btnBuscar;
        private Button btnAnterior;
        private Button btnProximo;
        private Label lblPagina;
    }
}
