using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Security.Cryptography;
using System.Xml.Linq;
using System.Reflection;

namespace CapaDatos
{
    public class CD_Venta
    {
        public List<Venta> Listar()
        {
            List<Venta> lista = new List<Venta>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT IdVenta,NumeroDocumento,Placa,NombreCliente,TipoDocumento,TipoPago,Ruc,Kilometraje,MontoPago,MontoCambio,MontoTotal,convert(char(10),FechaRegistro,103)[FechaRegistro] FROM VENTA");                    

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Venta()
                            {
                                IdVenta = Convert.ToInt32(dr["IdVenta"].ToString()),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                Placa = dr["Placa"].ToString(),
                                NombreCliente = dr["NombreCliente"].ToString(),
                                TipoDocumento = dr["TipoDocumento"].ToString(),
                                TipoPago = dr["TipoPago"].ToString(),
                                Ruc = dr["Ruc"].ToString(),
                                Kilometraje = Convert.ToInt32(dr["Kilometraje"].ToString()),
                                MontoPago = Convert.ToDecimal(dr["MontoPago"].ToString()),
                                MontoCambio = Convert.ToDecimal(dr["MontoCambio"].ToString()),
                                MontoTotal = Convert.ToDecimal(dr["MontoTotal"].ToString()),
                                FechaRegistro = dr["FechaRegistro"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    
                    lista = new List<Venta>();
                }
            }
            return lista;
        }

        public int ObtenerCorrelativo(string tipoDocumento)
        {
            int idCorrelativo = 0;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    // Construir la consulta para obtener el máximo correlativo por tipo de documento
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT ISNULL(MAX(NumeroDocumento), 0) AS MaxNumero");
                    query.AppendLine("FROM VENTA");
                    query.AppendLine("WHERE TipoDocumento = @TipoDocumento");
                    query.AppendLine("UNION ALL");
                    query.AppendLine("SELECT ISNULL(MAX(NumeroDocumento), 0) AS MaxNumero");
                    query.AppendLine("FROM VENTA_SERVICIO");
                    query.AppendLine("WHERE TipoDocumento = @TipoDocumento");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@TipoDocumento", tipoDocumento);

                    oconexion.Open();

                    // Obtener los valores de ambas tablas
                    List<int> maxValues = new List<int>();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            maxValues.Add(Convert.ToInt32(reader[0]));
                        }
                    }

                    // Determinar el máximo de ambos y sumar 1
                    idCorrelativo = maxValues.Max() + 1;
                }
                catch (Exception ex)
                {
                    idCorrelativo = 0;
                    // Manejar o registrar el error si es necesario
                }
            }

            return idCorrelativo;
        }


        public bool RestarStock(int idproducto, int cantidad)
        {
            bool respuesta = true;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update producto set stock = stock - @cantidad where idproducto = @idproducto");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@idproducto", idproducto);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception ex)
                {
                    respuesta = false;
                }
            }
            return respuesta;

        }
        public bool SumarStock(int idproducto, int cantidad)
        {
            bool respuesta = true;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update producto set stock = stock + @cantidad where idproducto = @idproducto");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@idproducto", idproducto);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception ex)
                {
                    respuesta = false;
                }
            }
            return respuesta;

        }
        
        public bool Registrar(Venta obj, DataTable DetalleVenta, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("usp_RegistrarVenta", oconexion);
                  
                    cmd.Parameters.AddWithValue("TipoDocumento", obj.TipoDocumento);
                    cmd.Parameters.AddWithValue("TipoPago", obj.TipoPago);
                    cmd.Parameters.AddWithValue("NumeroDocumento", obj.NumeroDocumento);
                    cmd.Parameters.AddWithValue("NombreCliente", obj.NombreCliente);
                    cmd.Parameters.AddWithValue("Placa", obj.Placa);
                    cmd.Parameters.AddWithValue("Ruc", obj.Ruc);
                    cmd.Parameters.AddWithValue("Kilometraje", obj.Kilometraje);
                    cmd.Parameters.AddWithValue("MontoPago", obj.MontoPago);
                    cmd.Parameters.AddWithValue("MontoCambio", obj.MontoCambio);
                    cmd.Parameters.AddWithValue("MontoTotal", obj.MontoTotal);
                    cmd.Parameters.AddWithValue("DetalleVenta", DetalleVenta);
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                Respuesta = false;
                Mensaje = ex.Message;
            }

            return Respuesta;
        }
        public List<Detalle_Venta> ObtenerDetalleVenta(int idVenta)
        {
            List<Detalle_Venta> oLista = new List<Detalle_Venta>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.Descripcion,dv.PrecioVenta,dv.Cantidad,dv.SubTotal from DETALLE_VENTA dv");
                    query.AppendLine("inner join PRODUCTO p on p.IdProducto = dv.IdProducto");
                    query.AppendLine(" where dv.IdVenta = @idventa");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@idventa", idVenta);
                    cmd.CommandType = System.Data.CommandType.Text;


                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new Detalle_Venta()
                            {
                                oProducto = new Producto() { Descripcion = dr["Descripcion"].ToString() },
                                PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"].ToString()),
                                cantidad = Convert.ToInt32(dr["Cantidad"].ToString()),
                                SubTotal = Convert.ToDecimal(dr["SubTotal"].ToString()),
                            });
                        }
                    }

                }
                catch
                {
                    oLista = new List<Detalle_Venta>();
                }
            }
            return oLista;
        }

        //---------------------------------------------------------------------------------------------------SERVICIO
        public List<VentaServicio> ListarServicio()
        {
            List<VentaServicio> lista = new List<VentaServicio>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT IdVentaServicio,NumeroDocumento,Placa,NombreCliente,TipoDocumento,TipoPago,Ruc,Kilometraje,MontoPago,MontoCambio,MontoTotal,convert(char(10),FechaRegistro,103)[FechaRegistro] FROM VENTA_SERVICIO");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new VentaServicio()
                            {
                                IdVentaServicio = Convert.ToInt32(dr["IdVentaServicio"].ToString()),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                Placa = dr["Placa"].ToString(),
                                NombreCliente = dr["NombreCliente"].ToString(),
                                TipoDocumento = dr["TipoDocumento"].ToString(),
                                TipoPago = dr["TipoPago"].ToString(),
                                Ruc = dr["Ruc"].ToString(),
                                Kilometraje = Convert.ToInt32(dr["Kilometraje"].ToString()),
                                MontoPago = Convert.ToDecimal(dr["MontoPago"].ToString()),
                                MontoCambio = Convert.ToDecimal(dr["MontoCambio"].ToString()),
                                MontoTotal = Convert.ToDecimal(dr["MontoTotal"].ToString()),
                                FechaRegistro = dr["FechaRegistro"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {

                    lista = new List<VentaServicio>();
                }
            }
            return lista;
        }
        public bool RegistrarServicio(VentaServicio obj, DataTable DetalleServicio, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("usp_RegistrarVentaServicio", oconexion);

                    cmd.Parameters.AddWithValue("TipoDocumento", obj.TipoDocumento);
                    cmd.Parameters.AddWithValue("TipoPago", obj.TipoPago);
                    cmd.Parameters.AddWithValue("NumeroDocumento", obj.NumeroDocumento);
                    cmd.Parameters.AddWithValue("NombreCliente", obj.NombreCliente);
                    cmd.Parameters.AddWithValue("Placa", obj.Placa);
                    cmd.Parameters.AddWithValue("Ruc", obj.Ruc);
                    cmd.Parameters.AddWithValue("Kilometraje", obj.Kilometraje);
                    cmd.Parameters.AddWithValue("MontoPago", obj.MontoPago);
                    cmd.Parameters.AddWithValue("MontoCambio", obj.MontoCambio);
                    cmd.Parameters.AddWithValue("MontoTotal", obj.MontoTotal);
                    cmd.Parameters.AddWithValue("DetalleServicio", DetalleServicio);
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                Respuesta = false;
                Mensaje = ex.Message;
            }

            return Respuesta;
        }

        public List<Detalle_Servicio> ObtenerDetalleVentaServicio(int idVenta)
        {
            List<Detalle_Servicio> oLista = new List<Detalle_Servicio>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select dv.Descripcion,dv.PrecioServicio from DETALLE_SERVICIO dv");
                    query.AppendLine("inner join Servicio p on p.IdServicio = dv.IdServicio");
                    query.AppendLine(" where dv.IdVentaServicio = @idventaservicio");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@idventaservicio", idVenta);
                    cmd.CommandType = System.Data.CommandType.Text;


                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new Detalle_Servicio()
                            {                               
                                Descripcion = dr["Descripcion"].ToString(),
                                PrecioServicio = Convert.ToDecimal(dr["PrecioServicio"].ToString()),                               
                            });
                        }
                    }
                }
                catch
                {
                    oLista = new List<Detalle_Servicio>();
                }
            }
            return oLista;
        }
        /*-----------------------------------------------------------------------------------------------------COTIZACIONES--------------------------------*/
        public bool RegistrarCotizaciones(Venta obj, DataTable DetalleVenta, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("usp_RegistrarCotizacion", oconexion);

                    cmd.Parameters.AddWithValue("TipoDocumento", obj.TipoDocumento);
                    cmd.Parameters.AddWithValue("NombreCliente", obj.NombreCliente);
                    cmd.Parameters.AddWithValue("Placa", obj.Placa);
                    cmd.Parameters.AddWithValue("Descripcion", obj.Descripcion);
                    cmd.Parameters.AddWithValue("MontoTotal", obj.MontoTotal);
                    cmd.Parameters.AddWithValue("DetalleVenta", DetalleVenta);
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                Respuesta = false;
                Mensaje = ex.Message;
            }

            return Respuesta;
        }

        public bool RegistrarServicioCoti(VentaServicio obj, DataTable DetalleServicio, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("usp_RegistrarSEERCotizacion", oconexion);

                    cmd.Parameters.AddWithValue("TipoDocumento", obj.TipoDocumento);
                    cmd.Parameters.AddWithValue("NombreCliente", obj.NombreCliente);
                    cmd.Parameters.AddWithValue("Placa", obj.Placa);
                    cmd.Parameters.AddWithValue("DetalleDescripcion", obj.detalleDescripcion);
                    cmd.Parameters.AddWithValue("MontoTotal", obj.MontoTotal);
                    cmd.Parameters.AddWithValue("Detalleservicio", DetalleServicio);
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                Respuesta = false;
                Mensaje = ex.Message;
            }

            return Respuesta;
        }
        /*-------------------------------productos*/
        public List<Venta> ListarCoti()
        {
            List<Venta> lista = new List<Venta>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT IdCotizacion,Placa,NombreCliente,TipoDocumento,Descripcion,MontoTotal,convert(char(10),FechaRegistro,103)[FechaRegistro] FROM COTIZACION");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Venta()
                            {
                                IdVenta = Convert.ToInt32(dr["IdCotizacion"].ToString()),                               
                                Placa = dr["Placa"].ToString(),
                                NombreCliente = dr["NombreCliente"].ToString(),
                                TipoDocumento = dr["TipoDocumento"].ToString(),
                                Descripcion = dr["Descripcion"].ToString(),
                                MontoTotal = Convert.ToDecimal(dr["MontoTotal"].ToString()),
                                FechaRegistro = dr["FechaRegistro"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {

                    lista = new List<Venta>();
                }
            }
            return lista;
        }


        public List<Detalle_Venta> ObtenerDetalleCoti(int idVenta)
        {
            List<Detalle_Venta> oLista = new List<Detalle_Venta>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.Descripcion,dv.PrecioVenta,dv.Cantidad,dv.SubTotal from DETALLE_COTIZACION dv");
                    query.AppendLine("inner join PRODUCTO p on p.IdProducto = dv.IdProducto");
                    query.AppendLine(" where dv.IdCotizacion = @idventa");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@idventa", idVenta);
                    cmd.CommandType = System.Data.CommandType.Text;


                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new Detalle_Venta()
                            {
                                oProducto = new Producto() { Descripcion = dr["Descripcion"].ToString() },
                                PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"].ToString()),
                                cantidad = Convert.ToInt32(dr["Cantidad"].ToString()),
                                SubTotal = Convert.ToDecimal(dr["SubTotal"].ToString()),
                            });
                        }
                    }

                }
                catch
                {
                    oLista = new List<Detalle_Venta>();
                }
            }
            return oLista;
        }
        /*-----------------------------------------------------cotizacion servicios------------------*/
        //---------------------------------------------------------------------------------------------------SERVICIO
        public List<VentaServicio> ListarServicioCoti()
        {
            List<VentaServicio> lista = new List<VentaServicio>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT IdCotizacion,Placa,NombreCliente,DetalleDescripcion,MontoTotal,TipoDocumento,convert(char(10),FechaRegistro,103)[FechaRegistro] FROM SERCOTIZACION");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new VentaServicio()
                            {
                                IdVentaServicio = Convert.ToInt32(dr["IdCotizacion"].ToString()),
                                Placa = dr["Placa"].ToString(),
                                NombreCliente = dr["NombreCliente"].ToString(),                                
                                detalleDescripcion = dr["DetalleDescripcion"].ToString(),
                                MontoTotal = Convert.ToDecimal(dr["MontoTotal"].ToString()),
                                TipoDocumento = dr["TipoDocumento"].ToString(),
                                FechaRegistro = dr["FechaRegistro"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {

                    lista = new List<VentaServicio>();
                }
            }
            return lista;
        }
        public List<Detalle_Servicio> ObtenerDetalleVentaServicioCoti(int idVenta)
        {
            List<Detalle_Servicio> oLista = new List<Detalle_Servicio>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select dv.Descripcion,dv.PrecioServicio from DETALLE_SERCOTIZACION dv");
                    query.AppendLine("inner join Servicio p on p.IdServicio = dv.IdServicio");
                    query.AppendLine("where dv.IdCotizacion = @idcotizacion");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@idcotizacion", idVenta);
                    cmd.CommandType = System.Data.CommandType.Text;


                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new Detalle_Servicio()
                            {
                                Descripcion = dr["Descripcion"].ToString(),
                                PrecioServicio = Convert.ToDecimal(dr["PrecioServicio"].ToString()),
                            });
                        }
                    }
                }
                catch
                {
                    oLista = new List<Detalle_Servicio>();
                }
            }
            return oLista;
        }
    }
}
