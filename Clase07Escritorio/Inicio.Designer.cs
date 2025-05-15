namespace Clase07Escritorio
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            btnCliente = new Button();
            btnAdministracion = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnCliente
            // 
            btnCliente.Image = (Image)resources.GetObject("btnCliente.Image");
            btnCliente.Location = new Point(292, 113);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(100, 125);
            btnCliente.TabIndex = 0;
            btnCliente.Text = "Cliente";
            btnCliente.TextAlign = ContentAlignment.BottomCenter;
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnAdministracion
            // 
            btnAdministracion.Image = (Image)resources.GetObject("btnAdministracion.Image");
            btnAdministracion.Location = new Point(70, 113);
            btnAdministracion.Name = "btnAdministracion";
            btnAdministracion.Size = new Size(100, 125);
            btnAdministracion.TabIndex = 1;
            btnAdministracion.Text = "Administración";
            btnAdministracion.TextAlign = ContentAlignment.BottomCenter;
            btnAdministracion.UseVisualStyleBackColor = true;
            btnAdministracion.Click += btnAdministracion_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 9);
            label1.Name = "label1";
            label1.Size = new Size(432, 47);
            label1.TabIndex = 2;
            label1.Text = "Bienvenidos a mi sistema";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(162, 70);
            label2.Name = "label2";
            label2.Size = new Size(133, 25);
            label2.TabIndex = 3;
            label2.Text = "Ingresar como";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAdministracion);
            Controls.Add(btnCliente);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCliente;
        private Button btnAdministracion;
        private Label label1;
        private Label label2;
    }
}