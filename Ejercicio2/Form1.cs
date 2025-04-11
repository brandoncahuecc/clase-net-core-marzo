namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            decimal numeroUno = 0;

            if (!decimal.TryParse(txtNumeroUno.Text, out numeroUno))
            {
                MessageBox.Show("El número que ingreso no es valido");
                txtNumeroUno.Focus();
                return;
            }

            decimal numeroDos = 0;

            if (!decimal.TryParse(txtNumeroDos.Text, out numeroDos))
            {
                MessageBox.Show("El número que ingreso no es valido");
                txtNumeroDos.Focus();
                return;
            }

            Suma(numeroUno, numeroDos);
            Resta(numeroUno, numeroDos);
            Multiplicacion(numeroUno, numeroDos);
            Division(numeroUno, numeroDos);

            double poteciacion = Math.Pow(Convert.ToDouble(numeroUno), 2);

            MessageBox.Show(poteciacion.ToString());
        }

        private void Suma(decimal numeroUno, decimal numeroDos)
        {
            decimal respuesta = numeroUno + numeroDos;
            resultadoSuma.Text = respuesta.ToString();
        }

        private void Resta(decimal numeroUno, decimal numeroDos)
        {
            decimal respuesta = numeroUno - numeroDos;
            resultadoResta.Text = respuesta.ToString();
        }

        private void Multiplicacion(decimal numeroUno, decimal numeroDos)
        {
            decimal respuesta = numeroUno * numeroDos;
            resultadoMultiplicacion.Text = respuesta.ToString();
        }

        private void Division(decimal numeroUno, decimal numeroDos)
        {
            if (numeroDos == 0)
            {
                resultadoDivision.Text = "Indefinido";
            }
            else
            {
                decimal respuesta = numeroUno / numeroDos;
                resultadoDivision.Text = respuesta.ToString();
            }
        }
    }
}
