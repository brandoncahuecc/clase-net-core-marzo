using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase07Escritorio.Cliente
{
    public partial class ListaProductos : Form
    {
        public ListaProductos()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var inicio = (Inicio)Tag;
            inicio.Show();
            Close();
        }
    }
}
