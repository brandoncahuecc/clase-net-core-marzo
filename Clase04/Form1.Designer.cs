namespace Clase04
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
            txtSalidaTexto = new TextBox();
            label1 = new Label();
            txtResultado = new TextBox();
            SuspendLayout();
            // 
            // txtSalidaTexto
            // 
            txtSalidaTexto.Enabled = false;
            txtSalidaTexto.Location = new Point(12, 27);
            txtSalidaTexto.Multiline = true;
            txtSalidaTexto.Name = "txtSalidaTexto";
            txtSalidaTexto.Size = new Size(492, 195);
            txtSalidaTexto.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(181, 9);
            label1.Name = "label1";
            label1.Size = new Size(167, 15);
            label1.TabIndex = 1;
            label1.Text = "Practica con Cadenas de Texto";
            // 
            // txtResultado
            // 
            txtResultado.Enabled = false;
            txtResultado.Location = new Point(12, 228);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(492, 210);
            txtResultado.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 450);
            Controls.Add(txtResultado);
            Controls.Add(label1);
            Controls.Add(txtSalidaTexto);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSalidaTexto;
        private Label label1;
        private TextBox txtResultado;
    }
}
