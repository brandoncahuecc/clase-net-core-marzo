using Clase07Escritorio.Objetos;
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
            dgvProductos.DataSource = Inicio.Productos;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            InicioSesion inicioSesion = (InicioSesion)Tag;
            inicioSesion.Show();
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtProducto.Text;

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Debe de ingresar un nombre de producto valido",
                    "Agregar producto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtProducto.Focus();
                return;
            }

            if (!decimal.TryParse(txtCantidad.Text, out decimal cantidad))
            {
                MessageBox.Show("Debe de ingresar una cantidad de productos validos",
                    "Agregar producto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtCantidad.Focus();
                return;
            }

            if (!decimal.TryParse(txtPrecioUnidad.Text, out decimal precioUnidad))
            {
                MessageBox.Show("Debe de ingresar un precio de productos valido",
                    "Agregar producto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtPrecioUnidad.Focus();
                return;
            }

            string proveedor = txtProveedor.Text;

            if (string.IsNullOrWhiteSpace(proveedor))
            {
                MessageBox.Show("Debe de ingresar un nombre de proveedor valido",
                    "Agregar producto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtProveedor.Focus();
                return;
            }

            Producto? ultimoRegistro = Inicio.Productos.OrderByDescending(c => c.Id).FirstOrDefault();

            int id = 0;
            if (ultimoRegistro is null)
                id = 1;
            else
                id = ultimoRegistro.Id + 1;

            Producto producto = new Producto()
            {
                Id =id,
                Nombre = nombre,
                PrecioUnidad = precioUnidad,
                Proveedor = proveedor,
                Cantidad = cantidad
            };

            Inicio.Productos.Add(producto);

            txtCantidad.Text = string.Empty;
            txtProducto.Text = string.Empty;
            txtPrecioUnidad.Text = string.Empty;
            txtProveedor.Text = string.Empty;

            dgvProductos.DataSource = null;
            dgvProductos.DataSource = Inicio.Productos;
        }
    }
}
