namespace VendinhaPlena.Desktop
{
    partial class FormPagarDivida
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
            label1 = new Label();
            txtIdCliente = new TextBox();
            btnBuscar = new Button();
            gridDividas = new DataGridView();
            btnPagar = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridDividas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 68);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Id do Cliente";
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(30, 86);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(491, 23);
            txtIdCliente.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(305, 289);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(104, 38);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // gridDividas
            // 
            gridDividas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridDividas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridDividas.Location = new Point(12, 115);
            gridDividas.Name = "gridDividas";
            gridDividas.Size = new Size(545, 154);
            gridDividas.TabIndex = 3;
            // 
            // btnPagar
            // 
            btnPagar.Location = new Point(142, 289);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(104, 38);
            btnPagar.TabIndex = 4;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(161, 20);
            label3.Name = "label3";
            label3.Size = new Size(181, 37);
            label3.TabIndex = 6;
            label3.Text = "Pagar Divida";
            // 
            // FormPagarDivida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 339);
            Controls.Add(label3);
            Controls.Add(btnPagar);
            Controls.Add(gridDividas);
            Controls.Add(btnBuscar);
            Controls.Add(txtIdCliente);
            Controls.Add(label1);
            Name = "FormPagarDivida";
            Text = "FormPagarDivida";
            ((System.ComponentModel.ISupportInitialize)gridDividas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIdCliente;
        private Button btnBuscar;
        private DataGridView gridDividas;
        private Button btnPagar;
        private Label label3;
    }
}