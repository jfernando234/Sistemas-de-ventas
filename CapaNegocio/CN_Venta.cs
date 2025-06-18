using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Venta
    {
        private CD_Venta objcd_venta = new CD_Venta();
        public List<Venta> Listar()
        {
            return objcd_venta.Listar();
        }

        public bool RestarStock(int idproducto, int cantidad)
        {
            return objcd_venta.RestarStock(idproducto, cantidad);
        }

        public bool SumarStock(string idproducto, int cantidad)
        {
            return objcd_venta.SumarStock(idproducto, cantidad);
        }

        public int ObtenerCorrelativo(string tipoDocumento)
        {
            return objcd_venta.ObtenerCorrelativo(tipoDocumento);
        }

        public bool Registrar(Venta obj, DataTable DetalleVenta, out string Mensaje)
        {
            return objcd_venta.Registrar(obj, DetalleVenta, out Mensaje);
        }
        

        public List<Detalle_Venta> ObtenerProductoPorIdVenta(int idVenta)
        {
            // Llamar al método que obtiene el detalle de la venta
            List<Detalle_Venta> oDetalleVenta = objcd_venta.ObtenerDetalleVenta(idVenta);

            // Retornar la lista de detalles directamente
            return oDetalleVenta;
        }
        //----------------------------COTIZACION
        public bool RegistrarCotizacion(Venta obj, DataTable DetalleVenta, out string Mensaje)
        {
            return objcd_venta.RegistrarCotizaciones(obj, DetalleVenta, out Mensaje);
        }

        public List<Venta> ListarCoti()
        {
            return objcd_venta.ListarCoti();
        }

        public List<Detalle_Venta> ObtenerProductoCoti(int idCotizacion)
        {
            // Llamar al método que obtiene el detalle de la venta
            List<Detalle_Venta> oDetalleVenta = objcd_venta.ObtenerDetalleCoti(idCotizacion);

            // Retornar la lista de detalles directamente
            return oDetalleVenta;
        }

    }
}
