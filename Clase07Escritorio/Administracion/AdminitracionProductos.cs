using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase07Escritorio.Administracion
{
    public partial class AdminitracionProductos : Form
    {
        public AdminitracionProductos()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            InicioSesion inicioSesion = (InicioSesion)Tag;
            inicioSesion.Show();
            Close();
        }
    }
}
