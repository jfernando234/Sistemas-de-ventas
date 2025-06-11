using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_CargarProductos
    {
        private CD_Productos objcd_Producto = new CD_Productos();
        private CD_Productos productoData = new CD_Productos();

        public void CargarProductosDesdeExcel(string rutaArchivo)
        {
            List<Producto> productos = objcd_Producto.LeerExcel(rutaArchivo);

            foreach (var producto in productos)
            {
                productoData.InsertarProducto(
                    producto.Codigo,
                    producto.Descripcion,
                    producto.Stock,
                    producto.Ubicacion,
                    producto.PrecioCompra,
                    producto.PrecioVenta,
                    producto.PrecioLlevar,
                    producto.FechaRegistro,
                    producto.Categoria
                );
            }
        }
    }
}
