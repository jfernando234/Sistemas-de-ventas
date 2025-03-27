using CapaEntidad;
using CapaNegocio;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using Sistemas_de_ventas.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistemas_de_ventas
{
    public partial class frm_DetalleSerCotizacion : Form
    {
        public frm_DetalleSerCotizacion()
        {
            InitializeComponent();
        }

        private void frm_DetalleSerCotizacion_Load(object sender, EventArgs e)
        {
            //LISTAR USUARIOS

            List<VentaServicio> lista = new CN_Venta().ListarServicioCoti();

            foreach (VentaServicio item in lista)
            {
                dgvtotal.Rows.Add(new object[] {"",
                    item.IdVentaServicio,                   
                    item.Placa,                  
                    item.NombreCliente,
                    item.detalleDescripcion,                 
                    item.MontoTotal,
                    item.TipoDocumento,
                    item.FechaRegistro
                });
            }
        }

        private void bntbuscar_Click(object sender, EventArgs e)
        {
            if (dgvtotal.Rows.Count > 0)
            {
                string busqueda = txtbusqueda.Text.Trim().ToUpper();

                foreach (DataGridViewRow row in dgvtotal.Rows)
                {
                    if (row.Cells["Placa"].Value != null &&
                        row.Cells["Placa"].Value.ToString().ToUpper().Contains(busqueda))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void bntlimpiar_Click(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";
            foreach (DataGridViewRow row in dgvtotal.Rows)
            {
                row.Visible = true;
            }
        }
        private void btndesarga_Click(object sender, EventArgs e)
        {
            string Texto_Html = Properties.Resources.PlantillaCservicio.ToString();
            Negocio odatos = new CN_Negocio().ObtenerDatos();
            
            
            Texto_Html = Texto_Html.Replace("@nombrenegocio", odatos.Nombre.ToUpper());
            Texto_Html = Texto_Html.Replace("@docnegocio", odatos.RUC);
            Texto_Html = Texto_Html.Replace("@direcnegocio", odatos.Direccion);

            Texto_Html = Texto_Html.Replace("@tipodocumento", txttipodocumento.Text);

            Texto_Html = Texto_Html.Replace("@placa", txtPlaca.Text);
            Texto_Html = Texto_Html.Replace("@nombrecliente", txtnombrecliente.Text);
            Texto_Html = Texto_Html.Replace("@fecharegistro", txtfecha.Text);
            string filas = string.Empty;
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Descripcion"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["PrecioVenta"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            Texto_Html = Texto_Html.Replace("@filas", filas);
            Texto_Html = Texto_Html.Replace("@montototal", txtmontototal.Text);

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("Cotizacion.pdf");
            savefile.Filter = "Pdf Files|*.pdf";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {

                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    bool obtenido = true;
                    byte[] byteImage = new CN_Negocio().ObtenerLogo(out obtenido);

                    if (obtenido)
                    {
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(byteImage);
                        img.ScaleToFit(60, 60);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;
                        img.SetAbsolutePosition(pdfDoc.Left, pdfDoc.GetTop(51));
                        pdfDoc.Add(img);
                    }

                    using (StringReader sr = new StringReader(Texto_Html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("Documento Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgvtotal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvtotal.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtindice.Text = indice.ToString();
                    txtid.Text = dgvtotal.Rows[indice].Cells["IdCotizacion"].Value.ToString();
                    txtPlaca.Text = dgvtotal.Rows[indice].Cells["Placa"].Value.ToString();                 
                    txtnombrecliente.Text = dgvtotal.Rows[indice].Cells["NombreCliente"].Value.ToString();
                    txtdescripcion.Text = dgvtotal.Rows[indice].Cells["DetalleDescripcion"].Value.ToString();                   
                    txtmontototal.Text = dgvtotal.Rows[indice].Cells["MontoTotal"].Value.ToString();
                    txttipodocumento.Text = dgvtotal.Rows[indice].Cells["TipoDocumento"].Value.ToString();
                    txtfecha.Text = dgvtotal.Rows[indice].Cells["FechaRegistro"].Value.ToString();

                    // Obtener el IdVenta para buscar los productos
                    int idVenta = Convert.ToInt32(txtid.Text);

                    dgvdata.Rows.Clear();
                    // Llamar al método para obtener los productos asociados a la venta
                    List<Detalle_Servicio> detalleVenta = new CN_Venta().ObtenerServicioCoti(idVenta);

                    foreach (Detalle_Servicio item in detalleVenta)
                    {
                        dgvdata.Rows.Add(new object[] {
                               item.Descripcion,
                               item.PrecioServicio
                        });
                    }
                }
            }
        }
    }
}
