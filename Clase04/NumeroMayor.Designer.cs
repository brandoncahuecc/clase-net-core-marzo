namespace Clase04
{
    partial class NumeroMayor
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
            txtNumeroUno = new TextBox();
            txtNumeroDos = new TextBox();
            txtNumeroTres = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtResultado = new TextBox();
            btnVerificar = new Button();
            SuspendLayout();
            // 
            // txtNumeroUno
            // 
            txtNumeroUno.Location = new Point(108, 16);
            txtNumeroUno.Name = "txtNumeroUno";
            txtNumeroUno.Size = new Size(100, 23);
            txtNumeroUno.TabIndex = 0;
            // 
            // txtNumeroDos
            // 
            txtNumeroDos.Location = new Point(108, 54);
            txtNumeroDos.Name = "txtNumeroDos";
            txtNumeroDos.Size = new Size(100, 23);
            txtNumeroDos.TabIndex = 1;
            // 
            // txtNumeroTres
            // 
            txtNumeroTres.Location = new Point(108, 88);
            txtNumeroTres.Name = "txtNumeroTres";
            txtNumeroTres.Size = new Size(100, 23);
            txtNumeroTres.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 19);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 3;
            label1.Text = "Numero 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 57);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 4;
            label2.Text = "Numero 2:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 91);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 5;
            label3.Text = "Numero 3:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 191);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 6;
            label4.Text = "Numero Mayor:";
            // 
            // txtResultado
            // 
            txtResultado.Enabled = false;
            txtResultado.Location = new Point(108, 188);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(273, 23);
            txtResultado.TabIndex = 7;
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(51, 138);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(127, 23);
            btnVerificar.TabIndex = 8;
            btnVerificar.Text = "Verificar Números";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // NumeroMayor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 450);
            Controls.Add(btnVerificar);
            Controls.Add(txtResultado);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNumeroTres);
            Controls.Add(txtNumeroDos);
            Controls.Add(txtNumeroUno);
            Name = "NumeroMayor";
            Text = "NumeroMayor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumeroUno;
        private TextBox txtNumeroDos;
        private TextBox txtNumeroTres;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtResultado;
        private Button btnVerificar;
    }
}