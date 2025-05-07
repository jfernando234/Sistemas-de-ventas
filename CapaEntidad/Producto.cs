using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public int Stock { get; set; }
        public string Ubicacion { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal PrecioCompra { get; set; }      
        public string FechaRegistro { get; set; }
        public decimal PrecioLlevar { get; set; }
        public string Categoria { get; set; }
        public Categoria oCategoria { get; set; }
    }
}
