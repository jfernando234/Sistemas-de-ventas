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
        public List<ReporteCompra> Compra(string fechainicio, string fechafin, int idproveedor)
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
                    cmd.Parameters.AddWithValue("idproveedor", idproveedor);
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
                    query.AppendLine("INNER JOIN PRODUCTO p ON p.IdProducto = dv.IdCompra");
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
                                FechaRegistro = dr["FechaRegistro"].ToString(),
                                NombreProducto = dr["Descripcion"].ToString(),
                                Cantidad = dr["Cantidad"].ToString(),
                                PrecioVenta = dr["PrecioVenta"].ToString(),
                                SubTotal = dr["SubTotal"].ToString(),
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
        public List<ReporteVenta> Venta2()
        {
            List<ReporteVenta> lista = new List<ReporteVenta>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.Descripcion,sum(d.Cantidad) as TotalVendida,sum(d.SubTotal) as IngresoTotal");
                    query.AppendLine("from DETALLE_VENTA d");
                    query.AppendLine("inner join PRODUCTO p on p.IdProducto = d.IdProducto");
                    query.AppendLine("group by p.Descripcion");
                    query.AppendLine("order by IngresoTotal desc;");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ReporteVenta()
                            {
                                NombreProducto = dr["Descripcion"].ToString(),
                                Cantidad = dr["TotalVendida"].ToString(),
                                SubTotal = dr["IngresoTotal"].ToString()
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
        //SERVICIO
        public List<ReporteServicio> Servicio(string fechainicio, string fechafin)
        {
            List<ReporteServicio> lista = new List<ReporteServicio>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    SqlCommand cmd = new SqlCommand("sp_ReporteServicios", oconexion);
                    cmd.Parameters.AddWithValue("fechainicio", fechainicio);
                    cmd.Parameters.AddWithValue("fechafin", fechafin);
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ReporteServicio()
                            {
                                FechaRegistro = dr["FechaRegistro"].ToString(),
                                TipoDocumento = dr["TipoDocumento"].ToString(),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                MontoTotal = dr["MontoTotal"].ToString(),
                                Ruc = dr["Ruc"].ToString(),
                                Placa = dr["Placa"].ToString(),
                                NombreCliente = dr["NombreCliente"].ToString(),
                                Descripcion = dr["Descripcion"].ToString(),                                    
                                SubTotal = dr["SubTotal"].ToString(),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<ReporteServicio>();
                }
            }

            return lista;

        }
        public List<ReporteVenta> BalanceTotal()
        {
            List<ReporteVenta> lista = new List<ReporteVenta>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.Descripcion,coalesce(sum(dv.Cantidad), 0) as CantidadComprada,");
                    query.AppendLine("coalesce(sum(d.Cantidad), 0) as CantidadVendida,");
                    query.AppendLine("coalesce(sum(dv.Cantidad), 0) - coalesce(sum(d.Cantidad), 0) as BalanceInventario,");
                    query.AppendLine("coalesce(sum(dv.MontoTotal), 0) as CostoTotal,");
                    query.AppendLine("coalesce(sum(d.SubTotal), 0) as IngresoTotal,");
                    query.AppendLine("coalesce(sum(d.SubTotal) - sum(dv.MontoTotal), 0) as GananciaTotal ");
                    query.AppendLine("from PRODUCTO p");
                    query.AppendLine("left join DETALLE_COMPRA dv on p.IdProducto = dv.IdCompra");
                    query.AppendLine("left join DETALLE_VENTA d on p.IdProducto = d.IdProducto");
                    query.AppendLine("group by p.Descripcion");
                    query.AppendLine("order by GananciaTotal desc;");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ReporteVenta()
                            {
                                NombreProducto= dr["Descripcion"].ToString(),
                                Cantidad = dr["CantidadComprada"].ToString(),
                                CantidadVe= dr["CantidadVendida"].ToString(),
                                Balance = dr["BalanceInventario"].ToString(),
                                CostoT= dr["CostoTotal"].ToString(),
                                SubTotal = dr["IngresoTotal"].ToString(),
                                GananciaT = dr["GananciaTotal"].ToString()
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
