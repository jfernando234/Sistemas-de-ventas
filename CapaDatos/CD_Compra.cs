﻿using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Compra
    {
        

        public int ObtenerCorrelativo()
        {
            int idcorrelativo = 0;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {

                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select count(*) + 1 from COMPRA");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    idcorrelativo = Convert.ToInt32(cmd.ExecuteScalar());

                }
                catch (Exception ex)
                {
                    idcorrelativo = 0;
                }
            }
            return idcorrelativo;
        }


        public bool Registrar(Compra obj, DataTable DetalleCompra, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;


            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {

                try
                {
                    SqlCommand cmd = new SqlCommand("sp_RegistrarCompra", oconexion);
                    cmd.Parameters.AddWithValue("IdUsuario", obj.oUsuario.IdUsuario);
                    cmd.Parameters.AddWithValue("RazonSocial", obj.RazonSocial);
                    cmd.Parameters.AddWithValue("Ruc", obj.Ruc);
                    cmd.Parameters.AddWithValue("TipoDocumento", obj.TipoDocumento);
                    cmd.Parameters.AddWithValue("TipoPago", obj.TipoPago);
                    cmd.Parameters.AddWithValue("NumeroDocumento", obj.NumeroDocumento);
                    cmd.Parameters.AddWithValue("MontoTotal", obj.MontoTotal);
                    cmd.Parameters.AddWithValue("DetalleCompra", DetalleCompra);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
                catch (Exception ex)
                {
                    Respuesta = false;
                    Mensaje = ex.Message;
                }
            }
            return Respuesta;
        }

        public List<Compra> Listar()
        {
            List<Compra> lista = new List<Compra>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {

                try
                {

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT c.IdCOMPRA,c.RazonSocial,c.Ruc,c.NumeroDocumento,c.TipoDocumento,u.NombreCompleto,");
                    query.AppendLine("c.Ruc,c.RazonSocial,c.TipoPago,c.MontoTotal,convert(char(10),c.FechaCreacion,103)[FechaRegistro]");
                    query.AppendLine("FROM COMPRA c");
                    query.AppendLine("inner join USUARIO u on u.IdUsuario = c.IdUsuario");
                    

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Compra()
                            {
                                IdCompra = Convert.ToInt32(dr["IdCompra"]),
                                oUsuario = new Usuario() { NombreCompleto = dr["NombreCompleto"].ToString() },
                                Ruc = Convert.ToInt32(dr["Ruc"].ToString()),
                                RazonSocial = dr["RazonSocial"].ToString(),
                                TipoDocumento = dr["TipoDocumento"].ToString(),
                                TipoPago = dr["TipoPago"].ToString(),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                MontoTotal = Convert.ToDecimal(dr["MontoTotal"].ToString()),
                                FechaRegistro = dr["FechaRegistro"].ToString()

                            });
                        }

                    }
                }
                catch (Exception ex)
                {

                    lista = new List<Compra>();
                }
            }
            return lista;
        }

        public List<Detalle_Compra> ObtenerDetalleCompra(int idcompra)
        {
            List<Detalle_Compra> oLista = new List<Detalle_Compra>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("select p.Descripcion,dc.PrecioCompra,dc.Cantidad,dc.MontoTotal from DETALLE_COMPRA dc");
                    query.AppendLine("inner join PRODUCTO p on p.IdProducto = dc.IdProducto");
                    query.AppendLine("where dc.IdCompra =  @idcompra");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@idcompra", idcompra);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new Detalle_Compra()
                            {
                                oProducto = new Producto() { Descripcion = dr["Descripcion"].ToString() },
                                PrecioCompra = Convert.ToDecimal(dr["PrecioCompra"].ToString()),
                                Cantidad = Convert.ToInt32(dr["Cantidad"].ToString()),
                                MontoTotal = Convert.ToDecimal(dr["MontoTotal"].ToString()),
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                oLista = new List<Detalle_Compra>();
            }
            return oLista;
        }
    }
}
