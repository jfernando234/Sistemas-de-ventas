using CapaEntidad;
using CapaNegocio;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
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
    public partial class frm_DetalleCotizacion : Form
    {
        public frm_DetalleCotizacion()
        {
            InitializeComponent();
        }

        private void frm_DetalleCotizacion_Load(object sender, EventArgs e)
        {

            List<Venta> lista = new CN_Venta().ListarCoti();

            foreach (Venta item in lista)
            {
                dgvtotal.Rows.Add(new object[] {"",
                    item.IdVenta,
                    item.Placa,
                    item.NombreCliente,
                    item.TipoDocumento,
                    item.Descripcion,
                    item.MontoTotal,
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
            string Texto_Html = Properties.Resources.PlantillaCotizacion.ToString();
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
                filas += "<td>" + row.Cells["Descripcionn"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["PrecioVenta"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["SubTotal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            Texto_Html = Texto_Html.Replace("@filas", filas);

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
                    txtid.Text = dgvtotal.Rows[indice].Cells["IdVenta"].Value.ToString();
                    txtPlaca.Text = dgvtotal.Rows[indice].Cells["Placa"].Value.ToString();
                    txtnombrecliente.Text = dgvtotal.Rows[indice].Cells["NombreCliente"].Value.ToString();
                    txttipodocumento.Text = dgvtotal.Rows[indice].Cells["TipoDocumento"].Value.ToString();
                    txtinfo.Text = dgvtotal.Rows[indice].Cells["Descripcion"].Value.ToString();
                    txtmontototal.Text = dgvtotal.Rows[indice].Cells["MontoTotal"].Value.ToString();
                    txtfecha.Text = dgvtotal.Rows[indice].Cells["FechaRegistro"].Value.ToString();

                    // Obtener el IdVenta para buscar los productos
                    int idVenta = Convert.ToInt32(txtid.Text);

                    dgvdata.Rows.Clear();
                    // Llamar al método para obtener los productos asociados a la venta
                    List<Detalle_Venta> detalleVenta = new CN_Venta().ObtenerProductoCoti(idVenta);

                    foreach (Detalle_Venta item in detalleVenta)
                    {
                        dgvdata.Rows.Add(new object[] {
                               item.Id,
                               item.Descripcion,
                               item.Precio,
                               item.cantidad,
                               item.SubTotal
                        });
                    }
                }
            }
        }
    }
}
