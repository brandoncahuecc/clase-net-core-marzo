namespace Clase07Escritorio.Cliente
{
    partial class ListaProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaProductos));
            btnBack = new Button();
            label1 = new Label();
            dgvProductosCliente = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProductosCliente).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(45, 45);
            btnBack.TabIndex = 1;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(266, 9);
            label1.Name = "label1";
            label1.Size = new Size(324, 47);
            label1.TabIndex = 4;
            label1.Text = "Lista de Productos";
            // 
            // dgvProductosCliente
            // 
            dgvProductosCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductosCliente.Location = new Point(49, 105);
            dgvProductosCliente.Name = "dgvProductosCliente";
            dgvProductosCliente.Size = new Size(709, 298);
            dgvProductosCliente.TabIndex = 5;
            // 
            // ListaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvProductosCliente);
            Controls.Add(label1);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ListaProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListaProductos";
            ((System.ComponentModel.ISupportInitialize)dgvProductosCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label label1;
        private DataGridView dgvProductosCliente;
    }
}