using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Reporte
    {
        //COMPRAS
        public List<ReporteCompra> Compra(string fechainicio, string fechafin, int ruc)
        {
            List<ReporteCompra> lista = new List<ReporteCompra>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    SqlCommand cmd = new SqlCommand("sp_ReporteCompras", oconexion);
                    cmd.Parameters.AddWithValue("fechainicio", fechainicio);
                    cmd.Parameters.AddWithValue("fechafin", fechafin);
                    cmd.Parameters.AddWithValue("ruc", ruc);
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ReporteCompra()
                            {
                                FechaRegistro = dr["FechaRegistro"].ToString(),
                                RazonSocial = dr["RazonSocial"].ToString(),
                                NombreProducto = dr["Descripcion"].ToString(),
                                Cantidad = dr["Cantidad"].ToString(),
                                PrecioCompra = dr["PrecioCompra"].ToString(),
                                MontoTotal = dr["MontoTotal"].ToString(),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {

                    lista = new List<ReporteCompra>();
                }
            }

            return lista;

        }
        public List<ReporteCompra> Compra2()
        {
            List<ReporteCompra> lista = new List<ReporteCompra>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT p.Descripcion,SUM(dv.Cantidad) AS TotalComprado,SUM(dv.MontoTotal) AS GastoTotal");
                    query.AppendLine("FROM DETALLE_COMPRA dv");
                    query.AppendLine("INNER JOIN PRODUCTO p ON p.IdProducto = dv.IdProducto");
                    query.AppendLine("GROUP BY p.Descripcion");
                    query.AppendLine("ORDER BY GastoTotal DESC;");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ReporteCompra()
                            {
                                NombreP = dr["Descripcion"].ToString(),
                                Cantidad = dr["TotalComprado"].ToString(),
                                MonTotal = dr["GastoTotal"].ToString(),                                
                            });
                        }
                    }
                }
                catch (Exception ex)
                {

                    lista = new List<ReporteCompra>();
                }
            }

            return lista;

        }
        //VENTAS
        public List<ReporteVenta> Venta(string fechainicio, string fechafin)
        {
            List<ReporteVenta> lista = new List<ReporteVenta>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    SqlCommand cmd = new SqlCommand("sp_ReporteVentas", oconexion);
                    cmd.Parameters.AddWithValue("fechainicio", fechainicio);
                    cmd.Parameters.AddWithValue("fechafin", fechafin);
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ReporteVenta()
                            {
                                FechaRegistro = dr["Id"].ToString(),
                                NombreCliente = dr["Descripcion"].ToString(),
                                CantidadVe = dr["TotalCantidadVendida"].ToString(),
                                PrecioUnitarioPromedio = Convert.ToInt32(dr["PrecioUnitarioPromedio"].ToString()),
                                TotalDetalle = Convert.ToInt32(dr["TotalRecaudado"].ToString()),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<ReporteVenta>();
                }
            }

            return lista;

        }
        public List<ReporteVenta> listarDetalle(string fechainicio, string fechafin)
        {
            List<ReporteVenta> lista = new List<ReporteVenta>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    SqlCommand cmd = new SqlCommand("sp_ReporteVentas", oconexion);
                    cmd.Parameters.AddWithValue("fechainicio", fechainicio);
                    cmd.Parameters.AddWithValue("fechafin", fechafin);
                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ReporteVenta()
                            {
                                Id = dr["Id"].ToString(),
                                Descripcion = Convert.ToString(dr["Descripcion"].ToString()),
                                TotalVendido = Convert.ToInt32(dr["TotalCantidadVendida"].ToString()),
                                PrecioUnitarioPromedio = Convert.ToDecimal(dr["PrecioUnitarioPromedio"].ToString()),
                                TotalDetalle = Convert.ToDecimal(dr["TotalRecaudado"].ToString())

                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<ReporteVenta>();
                }
            }
            return lista;
        }
        
    }
}
