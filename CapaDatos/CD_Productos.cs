using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.IO;
using ClosedXML.Excel;
using System.Linq;

namespace CapaDatos
{
    public class CD_Productos
    {
        public List<Producto> Listar()
        {
            List<Producto> lista = new List<Producto>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {

                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select IdProducto, Codigo, p.Descripcion,c.IdCategoria,Stock,Ubicacion,p.PrecioCompra,p.PrecioVenta,p.PrecioLlevar,c.Descripcion[DescripcionCategoria],convert(char(10),p.FechaRegistro,103)[FechaRegistro] from PRODUCTO p");
                    query.AppendLine("inner join CATEGORIA c on c.IdCategoria = p.IdCategoria");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Producto()
                            {
                                IdProducto = Convert.ToInt32(dr["IdProducto"]),
                                Codigo = dr["Codigo"].ToString(),
                                Descripcion = dr["Descripcion"].ToString(),                   
                                Stock = Convert.ToInt32(dr["Stock"].ToString()),
                                Ubicacion = dr["Ubicacion"].ToString(),                                
                                PrecioCompra = Convert.ToDecimal(dr["PrecioCompra"].ToString()),
                                PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"].ToString()),                                
                                PrecioLlevar = Convert.ToDecimal(dr["PrecioLlevar"].ToString()),
                                FechaRegistro = Convert.ToString(dr["FechaRegistro"].ToString()),
                                oCategoria = new Categoria() { IdCategoria = Convert.ToInt32(dr["IdCategoria"]), Descripcion = dr["DescripcionCategoria"].ToString() },
                            });

                        }

                    }


                }
                catch (Exception ex)
                {

                    lista = new List<Producto>();
                }
            }

            return lista;

        }
        public int Registrar(Producto obj, out string Mensaje)
        {
            int idProductogenerado = 0;
            Mensaje = string.Empty;


            try
            {

                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand cmd = new SqlCommand("SP_RegistrarProducto", oconexion);
                    cmd.Parameters.AddWithValue("Codigo", obj.Codigo);
                    cmd.Parameters.AddWithValue("Descripcion", obj.Descripcion);                
                    cmd.Parameters.AddWithValue("Stock", obj.Stock);
                    cmd.Parameters.AddWithValue("Ubicacion", obj.Ubicacion);
                    cmd.Parameters.AddWithValue("PrecioVenta", obj.PrecioVenta);
                    cmd.Parameters.AddWithValue("PrecioCompra", obj.PrecioCompra);
                    cmd.Parameters.AddWithValue("PrecioLlevar", obj.PrecioLlevar);
                    cmd.Parameters.AddWithValue("FechaRegistro", obj.FechaRegistro);
                    cmd.Parameters.AddWithValue("IdCategoria", obj.oCategoria.IdCategoria);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    idProductogenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }

            }
            catch (Exception ex)
            {
                idProductogenerado = 0;
                Mensaje = ex.Message;
            }

            return idProductogenerado;
        }



        public bool Editar(Producto obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;


            try
            {

                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand cmd = new SqlCommand("SP_ModificarProducto", oconexion);
                    cmd.Parameters.AddWithValue("IdProducto", obj.IdProducto);
                    cmd.Parameters.AddWithValue("Codigo", obj.Codigo);
                    cmd.Parameters.AddWithValue("Descripcion", obj.Descripcion);
                    cmd.Parameters.AddWithValue("Stock", obj.Stock);
                    cmd.Parameters.AddWithValue("Ubicacion", obj.Ubicacion);
                    cmd.Parameters.AddWithValue("PrecioVenta", obj.PrecioVenta);
                    cmd.Parameters.AddWithValue("PrecioCompra", obj.PrecioCompra);
                    cmd.Parameters.AddWithValue("PrecioLlevar", obj.PrecioLlevar);
                    cmd.Parameters.AddWithValue("FechaRegistro", obj.FechaRegistro);
                    cmd.Parameters.AddWithValue("IdCategoria", obj.oCategoria.IdCategoria);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }
            return respuesta;
        }
        public bool Eliminar(Producto obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {

                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand cmd = new SqlCommand("SP_EliminarProducto", oconexion);
                    cmd.Parameters.AddWithValue("IdProducto", obj.IdProducto);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }

            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }

            return respuesta;
        }

        public void InsertarProducto(

            string codigo, string descripcion,
            int stock, string ubicacion, decimal precioCompra, decimal precioVenta,decimal precioLlevar, string fechaRegistro, string categoria)

        {
            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand("CargarProductos", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Codigo", codigo);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);          
                cmd.Parameters.AddWithValue("@Stock", stock);
                cmd.Parameters.AddWithValue("@Ubicacion", ubicacion ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@PrecioCompra", precioCompra);
                cmd.Parameters.AddWithValue("@PrecioVenta", precioVenta);
                cmd.Parameters.AddWithValue("@PrecioLlevar", precioLlevar);
                cmd.Parameters.AddWithValue("@FechaRegistro", fechaRegistro);
                cmd.Parameters.AddWithValue("@Categoria", categoria);

                SqlParameter resultado = new SqlParameter("@Resultado", SqlDbType.Bit) { Direction = ParameterDirection.Output };
                SqlParameter mensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 500) { Direction = ParameterDirection.Output };

                cmd.Parameters.Add(resultado);
                cmd.Parameters.Add(mensaje);

                conn.Open();
                cmd.ExecuteNonQuery();

                bool exito = (bool)resultado.Value;
                if (!exito)
                {
                    throw new Exception(mensaje.Value.ToString());
                }
            }
        }

        public List<Producto> LeerExcel(string rutaArchivo)
        {
            List<Producto> productos = new List<Producto>();

            using (var workbook = new XLWorkbook(rutaArchivo))
            {
                var worksheet = workbook.Worksheet(1); // Selecciona la primera hoja del archivo
                var rows = worksheet.RangeUsed().RowsUsed().Skip(1); // Salta la primera fila si es de encabezados

                foreach (var row in rows)
                {
                    try
                    {
                        Producto producto = new Producto
                        {
                            Codigo = row.Cell(1).GetValue<string>().Trim(),
                            Descripcion = row.Cell(2).GetValue<string>().Trim(),                                                     
                            Stock = row.Cell(3).TryGetValue<int>(out int stock) ? stock : 0, // Manejo seguro
                            Ubicacion = row.Cell(4).GetValue<string>().Trim(),
                            PrecioCompra = row.Cell(5).TryGetValue<decimal>(out decimal precioCompra) ? precioCompra : 0m,
                            PrecioVenta = row.Cell(6).TryGetValue<decimal>(out decimal precioVenta) ? precioVenta : 0m,
                            PrecioLlevar = row.Cell(7).TryGetValue<decimal>(out decimal precioLlevar) ? precioLlevar : 0m,
                            FechaRegistro = row.Cell(8).TryGetValue<DateTime>(out DateTime fecha) ? fecha.ToString("dd/MM/yyyy") : string.Empty,
                            Categoria = row.Cell(9).GetValue<string>().Trim()
                        };

                        productos.Add(producto);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"Error en la fila {row.RowNumber()}: {ex.Message}");
                    }
                }
            }

            return productos;
        }

    }
}
