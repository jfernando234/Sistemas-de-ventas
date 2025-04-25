using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Detalle_Servicio
    {
        public int IdDetalleVenta { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioServicio { get; set; }       
        public string FechaRegistro { get; set; }
    }
}
