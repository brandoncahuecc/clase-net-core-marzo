using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase07Escritorio.Objetos
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Proveedor { get; set; }
        public decimal PrecioUnidad { get; set; }
        public decimal Cantidad { get; set; }
    }
}
