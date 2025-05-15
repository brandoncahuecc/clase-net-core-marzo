namespace Clase07Escritorio.Administracion
{
    partial class InicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            btnBack = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            btnIngresar = new Button();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(45, 45);
            btnBack.TabIndex = 0;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(73, 12);
            label1.Name = "label1";
            label1.Size = new Size(278, 47);
            label1.TabIndex = 3;
            label1.Text = "Inicio de Sesión";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 120);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 4;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 173);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 5;
            label3.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(126, 117);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Ingrese su usuario";
            txtUsuario.Size = new Size(163, 23);
            txtUsuario.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(126, 170);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Ingrese su contraseña";
            txtPassword.Size = new Size(163, 23);
            txtPassword.TabIndex = 7;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnIngresar
            // 
            btnIngresar.Image = (Image)resources.GetObject("btnIngresar.Image");
            btnIngresar.ImageAlign = ContentAlignment.MiddleRight;
            btnIngresar.Location = new Point(126, 226);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(91, 41);
            btnIngresar.TabIndex = 8;
            btnIngresar.Text = "Ingresar";
            btnIngresar.TextAlign = ContentAlignment.MiddleLeft;
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // InicioSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 450);
            Controls.Add(btnIngresar);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "InicioSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InicioSesion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Button btnIngresar;
    }
}