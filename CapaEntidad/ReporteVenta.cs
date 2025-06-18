using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ReporteVenta
    {
        public string FechaRegistro { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string MontoTotal { get; set; }
        public string Placa { get; set; }
        public string NombreCliente { get; set; }

        public string Id { get; set; }
        public string Descripcion { get; set; }
        public int TotalVendido { get; set; }
        public decimal PrecioUnitarioPromedio { get; set; }
        public decimal TotalDetalle { get; set; }

        public string CantidadVe { get; set; }
        public string Balance { get; set; }
        public string CostoT { get; set; }
        public string GananciaT { get; set; }
        public string SubTotal { get; set; }
    }
}
