namespace Ejercicio2
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
            txtNumeroUno = new TextBox();
            txtNumeroDos = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            resultadoSuma = new TextBox();
            resultadoResta = new TextBox();
            resultadoMultiplicacion = new TextBox();
            resultadoDivision = new TextBox();
            btnOperar = new Button();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // txtNumeroUno
            // 
            txtNumeroUno.Location = new Point(85, 53);
            txtNumeroUno.Name = "txtNumeroUno";
            txtNumeroUno.Size = new Size(202, 23);
            txtNumeroUno.TabIndex = 0;
            // 
            // txtNumeroDos
            // 
            txtNumeroDos.Location = new Point(85, 103);
            txtNumeroDos.Name = "txtNumeroDos";
            txtNumeroDos.Size = new Size(202, 23);
            txtNumeroDos.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 56);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "Número 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 106);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Número 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 234);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 4;
            label3.Text = "Suma";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 269);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 5;
            label4.Text = "Resta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 310);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 6;
            label5.Text = "Multiplicación";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 349);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 7;
            label6.Text = "División";
            // 
            // resultadoSuma
            // 
            resultadoSuma.Enabled = false;
            resultadoSuma.Location = new Point(103, 231);
            resultadoSuma.Name = "resultadoSuma";
            resultadoSuma.Size = new Size(202, 23);
            resultadoSuma.TabIndex = 8;
            // 
            // resultadoResta
            // 
            resultadoResta.Enabled = false;
            resultadoResta.Location = new Point(103, 266);
            resultadoResta.Name = "resultadoResta";
            resultadoResta.Size = new Size(202, 23);
            resultadoResta.TabIndex = 9;
            // 
            // resultadoMultiplicacion
            // 
            resultadoMultiplicacion.Enabled = false;
            resultadoMultiplicacion.Location = new Point(103, 307);
            resultadoMultiplicacion.Name = "resultadoMultiplicacion";
            resultadoMultiplicacion.Size = new Size(202, 23);
            resultadoMultiplicacion.TabIndex = 10;
            // 
            // resultadoDivision
            // 
            resultadoDivision.Enabled = false;
            resultadoDivision.Location = new Point(103, 346);
            resultadoDivision.Name = "resultadoDivision";
            resultadoDivision.Size = new Size(202, 23);
            resultadoDivision.TabIndex = 11;
            // 
            // btnOperar
            // 
            btnOperar.Location = new Point(124, 134);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(75, 23);
            btnOperar.TabIndex = 12;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = true;
            btnOperar.Click += btnOperar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(103, 9);
            label7.Name = "label7";
            label7.Size = new Size(128, 30);
            label7.TabIndex = 13;
            label7.Text = "Calculadora";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(103, 182);
            label8.Name = "label8";
            label8.Size = new Size(119, 30);
            label8.TabIndex = 14;
            label8.Text = "Resultados";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 450);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnOperar);
            Controls.Add(resultadoDivision);
            Controls.Add(resultadoMultiplicacion);
            Controls.Add(resultadoResta);
            Controls.Add(resultadoSuma);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNumeroDos);
            Controls.Add(txtNumeroUno);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumeroUno;
        private TextBox txtNumeroDos;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox resultadoSuma;
        private TextBox resultadoResta;
        private TextBox resultadoMultiplicacion;
        private TextBox resultadoDivision;
        private Button btnOperar;
        private Label label7;
        private Label label8;
    }
}
