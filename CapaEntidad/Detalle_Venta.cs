using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Detalle_Venta
    {
        public int IdDetalleVenta { get; set; }
        public string Id { get; set; }
        public string Descripcion { get; set; }  
        public int cantidad { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Precio { get; set; }
        public string FechaRegistro { get; set; }
    }
}
