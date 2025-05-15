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
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var inicio = (Inicio)Tag;
            inicio.Show();
            Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;

            if (usuario == "Brandon" && password == "Abcd1234")
            {
                AdminitracionProductos adminitracion = new AdminitracionProductos();
                adminitracion.Tag = this;
                adminitracion.Show(this);
                Hide();
            }
            else
            {
                MessageBox.Show("Credenciales ingresadas incorrectas",
                    "Credenciales Invalidas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
