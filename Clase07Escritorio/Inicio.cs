using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase07Escritorio.Administracion;
using Clase07Escritorio.Cliente;

namespace Clase07Escritorio
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            InicioSesion inicioSesion = new InicioSesion();
            inicioSesion.Tag = this;
            inicioSesion.Show(this);
            Hide();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            ListaProductos listaProductos = new ListaProductos();
            listaProductos.Tag = this;
            listaProductos.Show(this);
            Hide();
        }
    }
}
