namespace Clase04
{
    partial class Meses
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
            txtNumeroMes = new TextBox();
            txtMes = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtEjecutar = new Button();
            SuspendLayout();
            // 
            // txtNumeroMes
            // 
            txtNumeroMes.Location = new Point(125, 31);
            txtNumeroMes.Name = "txtNumeroMes";
            txtNumeroMes.Size = new Size(100, 23);
            txtNumeroMes.TabIndex = 0;
            // 
            // txtMes
            // 
            txtMes.Location = new Point(12, 120);
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(213, 23);
            txtMes.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 2;
            label1.Text = "Ingrese un número";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 102);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 3;
            label2.Text = "Mes del año";
            // 
            // txtEjecutar
            // 
            txtEjecutar.Location = new Point(87, 60);
            txtEjecutar.Name = "txtEjecutar";
            txtEjecutar.Size = new Size(75, 23);
            txtEjecutar.TabIndex = 4;
            txtEjecutar.Text = "Ejecutar";
            txtEjecutar.UseVisualStyleBackColor = true;
            txtEjecutar.Click += txtEjecutar_Click;
            // 
            // Meses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(238, 450);
            Controls.Add(txtEjecutar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMes);
            Controls.Add(txtNumeroMes);
            Name = "Meses";
            Text = "Meses";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumeroMes;
        private TextBox txtMes;
        private Label label1;
        private Label label2;
        private Button txtEjecutar;
    }
}