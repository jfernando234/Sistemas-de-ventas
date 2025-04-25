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

<<<<<<< HEAD
=======

>>>>>>> 7ab42f88e98eb044e7a945b29218bc6f3f55953d
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

<<<<<<< HEAD
       
        public List<Detalle_Compra> ObtenerProductoPorIdCompra(int IdCompra)
        {

            List<Detalle_Compra> oDetalleCompra = objcd_compra.ObtenerDetalleCompra(IdCompra);

            // Retornar la lista de detalles directamente
            return oDetalleCompra;
=======
        public Compra ObtenerCompra(string numero)
        {

            Compra oCompra = objcd_compra.ObtenerCompra(numero);

            if (oCompra.IdCompra != 0)
            {
                List<Detalle_Compra> oDetalleCompra = objcd_compra.ObtenerDetalleCompra(oCompra.IdCompra);

                oCompra.oDetalleCompra = oDetalleCompra;
            }
            return oCompra;
>>>>>>> 7ab42f88e98eb044e7a945b29218bc6f3f55953d
        }
    }
}
