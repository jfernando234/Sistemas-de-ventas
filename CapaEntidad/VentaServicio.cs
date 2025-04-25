using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class VentaServicio
    {
        public int IdVentaServicio { get; set; }
        public string TipoDocumento { get; set; }
        public string TipoPago{ get; set; }
        public string NumeroDocumento { get; set; }
        public string NombreCliente { get; set; }
        public string Placa { get; set; }
        public decimal MontoPago { get; set; }
        public decimal MontoCambio { get; set; }
        public decimal MontoTotal { get; set; }
        public string detalleDescripcion { get; set; }
        public List<Detalle_Servicio> oDetalle_Servicio { get; set; }
        public string FechaRegistro { get; set; }
        public string Ruc { get; set; }
        public int Kilometraje { get; set; }

    }
}
