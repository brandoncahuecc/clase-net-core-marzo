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

namespace Clase07Escritorio.Cliente
{
    public partial class ListaProductos : Form
    {
        public ListaProductos()
        {
            InitializeComponent();
            CargarProductos();
        }

        private void CargarProductos()
        {
            dgvProductosCliente.DataSource = null;
            dgvProductosCliente.DataSource = Inicio.Productos.Select(item =>
            new Producto {
                Id = item.Id,
                Nombre = item.Nombre,
                Proveedor = item.Proveedor,
                Cantidad = item.Cantidad,
                PrecioUnidad  = item.PrecioUnidad + (item.PrecioUnidad * 0.05M)
            }).ToList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var inicio = (Inicio)Tag;
            inicio.Show();
            Close();
        }
    }
}
