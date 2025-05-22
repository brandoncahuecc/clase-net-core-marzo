namespace Clase07Escritorio.Administracion
{
    partial class AdminitracionProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminitracionProductos));
            label1 = new Label();
            btnBack = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtProducto = new TextBox();
            txtCantidad = new TextBox();
            txtProveedor = new TextBox();
            btnAgregar = new Button();
            dgvProductos = new DataGridView();
            label5 = new Label();
            txtPrecioUnidad = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(63, 9);
            label1.Name = "label1";
            label1.Size = new Size(389, 47);
            label1.TabIndex = 5;
            label1.Text = "Administrar productos";
            // 
            // btnBack
            // 
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(45, 45);
            btnBack.TabIndex = 4;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 100);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 6;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 137);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 7;
            label3.Text = "Cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 205);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 8;
            label4.Text = "Proveedor";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(121, 97);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(162, 23);
            txtProducto.TabIndex = 9;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(121, 129);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(162, 23);
            txtCantidad.TabIndex = 10;
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(121, 197);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(162, 23);
            txtProveedor.TabIndex = 11;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(137, 235);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(328, 59);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(460, 280);
            dgvProductos.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 168);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 14;
            label5.Text = "Precio Unidad";
            // 
            // txtPrecioUnidad
            // 
            txtPrecioUnidad.Location = new Point(121, 165);
            txtPrecioUnidad.Name = "txtPrecioUnidad";
            txtPrecioUnidad.Size = new Size(162, 23);
            txtPrecioUnidad.TabIndex = 15;
            // 
            // AdminitracionProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPrecioUnidad);
            Controls.Add(label5);
            Controls.Add(dgvProductos);
            Controls.Add(btnAgregar);
            Controls.Add(txtProveedor);
            Controls.Add(txtCantidad);
            Controls.Add(txtProducto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AdminitracionProductos";
            Text = "AdminitracionProductos";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnBack;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtProducto;
        private TextBox txtCantidad;
        private TextBox txtProveedor;
        private Button btnAgregar;
        private DataGridView dgvProductos;
        private Label label5;
        private TextBox txtPrecioUnidad;
    }
}