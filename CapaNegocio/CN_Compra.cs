using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Compra
    {
        private CD_Compra objcd_compra = new CD_Compra();

        public List<Compra> Listar()
        {
            return objcd_compra.Listar();
        }
        public int ObtenerCorrelativo()
        {
            return objcd_compra.ObtenerCorrelativo();
        }

        public bool Registrar(Compra obj, DataTable DetalleCompra, out string Mensaje)
        {
            return objcd_compra.Registrar(obj, DetalleCompra, out Mensaje);
        }

       
        public List<Detalle_Compra> ObtenerProductoPorIdCompra(int IdCompra)
        {

            List<Detalle_Compra> oDetalleCompra = objcd_compra.ObtenerDetalleCompra(IdCompra);

            // Retornar la lista de detalles directamente
            return oDetalleCompra;
        }
    }
}
