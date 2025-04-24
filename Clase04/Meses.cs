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
    public partial class Meses : Form
    {
        public Meses()
        {
            InitializeComponent();
        }

        private void txtEjecutar_Click(object sender, EventArgs e)
        {
            int numeroMes = 0;

            if (!int.TryParse(txtNumeroMes.Text, out numeroMes))
            {
                MessageBox.Show("El número de mes que ingreso no es valido");
                txtNumeroMes.Focus();
                return;
            }

            string nombreMes = "";

            switch (numeroMes)
            {
                case 1: nombreMes = "Enero"; break;
                case 2: nombreMes = "Febrero"; break;
                case 3: nombreMes = "Marzo"; break;
                case 4: nombreMes = "Abril"; break;
                case 5: nombreMes = "Mayo"; break;
                case 6: nombreMes = "Junio"; break;
                case 7: nombreMes = "Julio"; break;
                case 8: nombreMes = "Agosto"; break;
                case 9: nombreMes = "Septiembre"; break;
                case 10: nombreMes = "Octubre"; break;
                case 11: nombreMes = "Noviembre"; break;
                case 12: nombreMes = "Diciembre"; break;
                default: nombreMes = $"El mes número {numeroMes} no existe"; break;
            }

            txtMes.Text = nombreMes;
        }
    }
}
