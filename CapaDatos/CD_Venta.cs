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
        public bool SumarStock(string idproducto, int cantidad)
        {
            bool respuesta = true;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE producto SET stock = stock + @cantidad WHERE Codigo = @idproducto");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad); // cantidad sigue siendo numérico
                    cmd.Parameters.AddWithValue("@idproducto", idproducto); // ahora string

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
                    query.AppendLine("select p.id,p.Descripcion,p.PrecioVenta,p.Cantidad,p.SubTotal from VENTA dv");
                    query.AppendLine("inner join DETALLE_VENTA p on p.IdVenta = dv.IdVenta");
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
                                Id = Convert.ToString(dr["Id"].ToString()),
                                Descripcion = Convert.ToString(dr["Descripcion"].ToString()),
                                Precio = Convert.ToDecimal(dr["PrecioVenta"].ToString()),
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
                    cmd.Parameters.AddWithValue("Info", obj.Descripcion);
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
        
        /*-------------------------------productos*/
        public List<Venta> ListarCoti()
        {
            List<Venta> lista = new List<Venta>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT IdCotizacion,Placa,NombreCliente,TipoDocumento,Info,MontoTotal,convert(char(10),FechaRegistro,103)[FechaRegistro] FROM COTIZACION");

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
                                Descripcion = dr["Info"].ToString(),
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


        public List<Detalle_Venta> ObtenerDetalleCoti(int idCotizacion)
        {
            List<Detalle_Venta> oLista = new List<Detalle_Venta>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.Id,p.descripcion,p.PrecioCotizacion,p.Cantidad,p.SubTotal from COTIZACION dv");
                    query.AppendLine("inner join DETALLE_COTIZACION p on p.IdCotizacion = dv.IdCotizacion");
                    query.AppendLine("where dv.IdCotizacion = @idcotizacion");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@idcotizacion", idCotizacion);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new Detalle_Venta()
                            {
                                Id = Convert.ToString(dr["Id"].ToString()),
                                Descripcion = Convert.ToString(dr["Descripcion"].ToString()),
                                Precio = Convert.ToDecimal(dr["PrecioCotizacion"].ToString()),
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
    } 
}
