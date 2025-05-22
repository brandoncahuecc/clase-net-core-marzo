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
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            btnBack = new ReaLTaiizor.Controls.Button();
            parrotSlidingPanel1 = new ReaLTaiizor.Controls.ParrotSlidingPanel();
            btnIngresar = new ReaLTaiizor.Controls.CyberButton();
            txtPassword = new ReaLTaiizor.Controls.CyberTextBox();
            txtUsuario = new ReaLTaiizor.Controls.CyberTextBox();
            thunderLabel2 = new ReaLTaiizor.Controls.ThunderLabel();
            thunderLabel1 = new ReaLTaiizor.Controls.ThunderLabel();
            parrotSlidingPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25F);
            bigLabel1.ForeColor = Color.White;
            bigLabel1.Location = new Point(105, 11);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(253, 46);
            bigLabel1.TabIndex = 1;
            bigLabel1.Text = "Inicio de Sesión";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.BorderColor = Color.Transparent;
            btnBack.EnteredBorderColor = Color.Transparent;
            btnBack.EnteredColor = Color.FromArgb(32, 34, 37);
            btnBack.Font = new Font("Microsoft Sans Serif", 12F);
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.ImageAlign = ContentAlignment.MiddleLeft;
            btnBack.InactiveColor = Color.Transparent;
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnBack.PressedColor = Color.FromArgb(165, 37, 37);
            btnBack.Size = new Size(45, 45);
            btnBack.TabIndex = 0;
            btnBack.TextAlignment = StringAlignment.Center;
            btnBack.Click += btnBack_Click;
            // 
            // parrotSlidingPanel1
            // 
            parrotSlidingPanel1.BottomLeft = Color.Black;
            parrotSlidingPanel1.BottomRight = Color.DodgerBlue;
            parrotSlidingPanel1.CollapseControl = null;
            parrotSlidingPanel1.Collapsed = true;
            parrotSlidingPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotSlidingPanel1.Controls.Add(btnBack);
            parrotSlidingPanel1.Controls.Add(btnIngresar);
            parrotSlidingPanel1.Controls.Add(txtPassword);
            parrotSlidingPanel1.Controls.Add(txtUsuario);
            parrotSlidingPanel1.Controls.Add(thunderLabel2);
            parrotSlidingPanel1.Controls.Add(thunderLabel1);
            parrotSlidingPanel1.Controls.Add(bigLabel1);
            parrotSlidingPanel1.Dock = DockStyle.Left;
            parrotSlidingPanel1.HideControls = false;
            parrotSlidingPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotSlidingPanel1.Location = new Point(0, 0);
            parrotSlidingPanel1.Name = "parrotSlidingPanel1";
            parrotSlidingPanel1.PanelWidthCollapsed = 50;
            parrotSlidingPanel1.PanelWidthExpanded = 200;
            parrotSlidingPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotSlidingPanel1.PrimerColor = Color.White;
            parrotSlidingPanel1.Size = new Size(479, 566);
            parrotSlidingPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotSlidingPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            parrotSlidingPanel1.TabIndex = 9;
            parrotSlidingPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotSlidingPanel1.TopLeft = Color.Black;
            parrotSlidingPanel1.TopRight = Color.Black;
            // 
            // btnIngresar
            // 
            btnIngresar.Alpha = 20;
            btnIngresar.BackColor = Color.Transparent;
            btnIngresar.Background = true;
            btnIngresar.Background_WidthPen = 4F;
            btnIngresar.BackgroundPen = true;
            btnIngresar.ColorBackground = Color.FromArgb(37, 52, 68);
            btnIngresar.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnIngresar.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnIngresar.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnIngresar.ColorLighting = Color.FromArgb(29, 200, 238);
            btnIngresar.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnIngresar.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnIngresar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnIngresar.Effect_1 = true;
            btnIngresar.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnIngresar.Effect_1_Transparency = 25;
            btnIngresar.Effect_2 = true;
            btnIngresar.Effect_2_ColorBackground = Color.White;
            btnIngresar.Effect_2_Transparency = 20;
            btnIngresar.Font = new Font("Arial", 11F);
            btnIngresar.ForeColor = Color.FromArgb(245, 245, 245);
            btnIngresar.Lighting = false;
            btnIngresar.LinearGradient_Background = false;
            btnIngresar.LinearGradientPen = false;
            btnIngresar.Location = new Point(162, 315);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.PenWidth = 15;
            btnIngresar.Rounding = true;
            btnIngresar.RoundingInt = 70;
            btnIngresar.Size = new Size(130, 50);
            btnIngresar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnIngresar.TabIndex = 6;
            btnIngresar.Tag = "Cyber";
            btnIngresar.TextButton = "Ingresar";
            btnIngresar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnIngresar.Timer_Effect_1 = 5;
            btnIngresar.Timer_RGB = 300;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtPassword
            // 
            txtPassword.Alpha = 20;
            txtPassword.BackColor = Color.Transparent;
            txtPassword.Background_WidthPen = 3F;
            txtPassword.BackgroundPen = true;
            txtPassword.ColorBackground = Color.FromArgb(37, 52, 68);
            txtPassword.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            txtPassword.ColorLighting = Color.FromArgb(29, 200, 238);
            txtPassword.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtPassword.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtPassword.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtPassword.Font = new Font("Arial", 10F);
            txtPassword.ForeColor = Color.FromArgb(245, 245, 245);
            txtPassword.Lighting = false;
            txtPassword.LinearGradientPen = false;
            txtPassword.Location = new Point(158, 210);
            txtPassword.Name = "txtPassword";
            txtPassword.Password = true;
            txtPassword.PasswordChar = '*';
            txtPassword.PenWidth = 15;
            txtPassword.RGB = false;
            txtPassword.Rounding = true;
            txtPassword.RoundingInt = 60;
            txtPassword.Size = new Size(200, 40);
            txtPassword.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtPassword.TabIndex = 5;
            txtPassword.Tag = "Cyber";
            txtPassword.TextButton = "";
            txtPassword.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtPassword.Timer_RGB = 300;
            // 
            // txtUsuario
            // 
            txtUsuario.Alpha = 20;
            txtUsuario.BackColor = Color.Transparent;
            txtUsuario.Background_WidthPen = 3F;
            txtUsuario.BackgroundPen = true;
            txtUsuario.ColorBackground = Color.FromArgb(37, 52, 68);
            txtUsuario.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            txtUsuario.ColorLighting = Color.FromArgb(29, 200, 238);
            txtUsuario.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtUsuario.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtUsuario.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtUsuario.Font = new Font("Arial", 10F);
            txtUsuario.ForeColor = Color.FromArgb(245, 245, 245);
            txtUsuario.Lighting = false;
            txtUsuario.LinearGradientPen = false;
            txtUsuario.Location = new Point(158, 124);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PenWidth = 15;
            txtUsuario.RGB = false;
            txtUsuario.Rounding = true;
            txtUsuario.RoundingInt = 60;
            txtUsuario.Size = new Size(200, 40);
            txtUsuario.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtUsuario.TabIndex = 4;
            txtUsuario.Tag = "Cyber";
            txtUsuario.TextButton = "";
            txtUsuario.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtUsuario.Timer_RGB = 300;
            // 
            // thunderLabel2
            // 
            thunderLabel2.BackColor = Color.Transparent;
            thunderLabel2.ForeColor = Color.WhiteSmoke;
            thunderLabel2.Location = new Point(65, 220);
            thunderLabel2.Name = "thunderLabel2";
            thunderLabel2.Size = new Size(84, 16);
            thunderLabel2.TabIndex = 3;
            thunderLabel2.Text = "Contraseña";
            // 
            // thunderLabel1
            // 
            thunderLabel1.BackColor = Color.Transparent;
            thunderLabel1.ForeColor = Color.WhiteSmoke;
            thunderLabel1.Location = new Point(85, 136);
            thunderLabel1.Name = "thunderLabel1";
            thunderLabel1.Size = new Size(55, 16);
            thunderLabel1.TabIndex = 2;
            thunderLabel1.Text = "Usuario";
            // 
            // InicioSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 566);
            Controls.Add(parrotSlidingPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "InicioSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InicioSesion";
            parrotSlidingPanel1.ResumeLayout(false);
            parrotSlidingPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.Button btnBack;
        private ReaLTaiizor.Controls.ParrotSlidingPanel parrotSlidingPanel1;
        private ReaLTaiizor.Controls.CyberTextBox txtUsuario;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel2;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel1;
        private ReaLTaiizor.Controls.CyberTextBox txtPassword;
        private ReaLTaiizor.Controls.CyberButton btnIngresar;
    }
}