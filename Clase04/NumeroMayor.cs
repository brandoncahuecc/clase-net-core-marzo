using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase04
{
    public partial class NumeroMayor : Form
    {
        public NumeroMayor()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
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

            decimal numeroTres = 0;

            if (!decimal.TryParse(txtNumeroTres.Text, out numeroTres))
            {
                MessageBox.Show("El número que ingreso no es valido");
                txtNumeroTres.Focus();
                return;
            }

            if ((numeroUno > numeroDos || numeroUno == numeroDos)
                && (numeroUno > numeroTres || numeroUno == numeroTres))
            {
                txtResultado.Text = numeroUno.ToString();
            }
            else if ((numeroDos > numeroUno || numeroDos == numeroUno)
                && (numeroDos > numeroTres || numeroDos == numeroTres))
            {
                txtResultado.Text = numeroDos.ToString();
            }
            else if ((numeroTres > numeroUno || numeroTres == numeroUno)
                && (numeroTres > numeroDos || numeroTres == numeroDos))
            {
                txtResultado.Text = numeroTres.ToString();
            }
            else
            {
                txtResultado.Text = "Todos los números son iguales";
            }

        }
    }
}
