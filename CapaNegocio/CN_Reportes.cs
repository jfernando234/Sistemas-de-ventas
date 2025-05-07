using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Reportes
    {
        private CD_Reporte objcd_reporte = new CD_Reporte();

        public List<ReporteCompra> Compra(string fechainicio, string fechafin, int idproveedor)
        {
            return objcd_reporte.Compra(fechainicio, fechafin, idproveedor);
        }
        public List<ReporteCompra> Compra2()
        {
            return objcd_reporte.Compra2();
        }
        
        public List<ReporteVenta> ListarDetalle(string fechainicio, string fechafin)
        {
            return objcd_reporte.listarDetalle(fechainicio,fechafin);
        }

    }
}
