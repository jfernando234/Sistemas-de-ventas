using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Producto
    {
        private CD_Productos objcd_Producto = new CD_Productos();


        public List<Producto> Listar()
        {
            return objcd_Producto.Listar();
        }

        public int Registrar(Producto obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Codigo == "")
            {
                Mensaje += "Es necesario el codigo del Producto\n";
            }

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el nombre del Producto\n";
            }

            if (obj.Descripcion == "")
            {
                Mensaje += "Es necesario la Descripcion del Producto\n";
            }
            
            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_Producto.Registrar(obj, out Mensaje);
            }


        }
        public bool Editar(Producto obj, out string Mensaje)
        {

            Mensaje = string.Empty;


            if (obj.Codigo == "")
            {
                Mensaje += "Es necesario el codigo del Producto\n";
            }

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el nombre del Producto\n";
            }

            if (obj.Descripcion == "")
            {
                Mensaje += "Es necesario la Descripcion del Producto\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Producto.Editar(obj, out Mensaje);
            }
        }


        public bool Eliminar(Producto obj, out string Mensaje)
        {
            return objcd_Producto.Eliminar(obj, out Mensaje);
        }


        private CD_Productos productoData = new CD_Productos();

        public void CargarProductosDesdeExcel(string rutaArchivo)
        {
            List<Producto> productos = objcd_Producto.LeerExcel(rutaArchivo);

            foreach (var producto in productos)
            {
                productoData.InsertarProducto(
<<<<<<< HEAD
                    producto.Codigo, 
                    producto.Descripcion, 
                    producto.Categoria,
                    producto.Ubicacion, 
                    producto.Stock, 
                    producto.PrecioCompra, 
                    producto.PrecioVenta,
                    producto.UnidadMedida,
                    producto.FechaRegistro
=======
                    producto.Codigo, producto.Descripcion, producto.Categoria,
                    producto.Ubicacion, producto.Stock, producto.PrecioCompra, producto.PrecioVenta,
                    producto.UnidadMedida, producto.FechaRegistro
>>>>>>> 7ab42f88e98eb044e7a945b29218bc6f3f55953d
                );
            }
        }

    }
}
