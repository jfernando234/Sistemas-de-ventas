using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Venta
    {
        public int IdVenta { get; set; }     
        public string TipoDocumento { get; set; }
        public string TipoPago { get; set; }
        public string NumeroDocumento { get; set; }      
        public string NombreCliente { get; set; }
        public string Placa { get; set; }
        public string Ruc { get; set; }
        public int Kilometraje { get; set; }
        public decimal MontoPago { get; set; }
        public decimal MontoCambio { get; set; }
        public decimal MontoTotal { get; set; }
        public string Descripcion { get; set; }
        public List<Detalle_Venta> oDetalle_Venta { get; set; }
        public string FechaRegistro { get; set; }
       
        
    }
}
