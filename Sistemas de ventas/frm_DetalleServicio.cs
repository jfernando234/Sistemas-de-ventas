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
    public partial class frm_DetalleServicio : Form
    {
        public frm_DetalleServicio()
        {
            InitializeComponent();
        }

        private void frm_DetalleServicio_Load(object sender, EventArgs e)
        {
            //LISTAR USUARIOS

            List<VentaServicio> lista = new CN_Venta().ListarServicio();

            foreach (VentaServicio item in lista)
            {
                dgvtotal.Rows.Add(new object[] {"",
                    item.IdVentaServicio,
                    item.NumeroDocumento,
                    item.Placa,
                    item.NombreCliente,
                    item.TipoDocumento,
                    item.TipoPago,
                    item.Ruc,
                    item.Kilometraje,
                    item.MontoPago,
                    item.MontoCambio,
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



        private void dgvtotal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvtotal.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtindice.Text = indice.ToString();
                    txtid.Text = dgvtotal.Rows[indice].Cells["IdVenta"].Value.ToString();
                    txtnumerodocumento.Text = dgvtotal.Rows[indice].Cells["NumeroDocumento"].Value.ToString();
                    txtPlaca.Text = dgvtotal.Rows[indice].Cells["Placa"].Value.ToString();
                    txtnombrecliente.Text = dgvtotal.Rows[indice].Cells["NombreCliente"].Value.ToString();
                    txttipodocumento.Text = dgvtotal.Rows[indice].Cells["TipoDocumento"].Value.ToString();
                    txttipopago.Text = dgvtotal.Rows[indice].Cells["TipoPago"].Value.ToString();
                    txtruc.Text = dgvtotal.Rows[indice].Cells["Ruc"].Value.ToString();
                    txtkilometraje.Text = dgvtotal.Rows[indice].Cells["Kilometraje"].Value.ToString();
                    txtmontopago.Text = dgvtotal.Rows[indice].Cells["MontoPago"].Value.ToString();
                    txtmontocambio.Text = dgvtotal.Rows[indice].Cells["MontoCambio"].Value.ToString();
                    txtmontototal.Text = dgvtotal.Rows[indice].Cells["MontoTotal"].Value.ToString();
                    txtfecha.Text = dgvtotal.Rows[indice].Cells["FechaRegistro"].Value.ToString();

                    // Obtener el IdVenta para buscar los productos
                    int idVenta = Convert.ToInt32(txtid.Text);

                    dgvdata.Rows.Clear();
                    // Llamar al método para obtener los productos asociados a la venta
                    List<Detalle_Servicio> detalleVenta = new CN_Venta().ObtenerProductoPorIdVentaServicio(idVenta);

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

        private void btndesarga_Click(object sender, EventArgs e)
        {
            if (txttipodocumento.Text == "")
            {
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string Texto_Html = Properties.Resources.PlantillaServicio.ToString();
            Negocio odatos = new CN_Negocio().ObtenerDatos();

            Texto_Html = Texto_Html.Replace("@nombrenegocio", odatos.Nombre.ToUpper());
            Texto_Html = Texto_Html.Replace("@docnegocio", odatos.RUC);
            Texto_Html = Texto_Html.Replace("@direcnegocio", odatos.Direccion);

            Texto_Html = Texto_Html.Replace("@tipodocumento", txttipodocumento.Text.ToUpper());
            Texto_Html = Texto_Html.Replace("@numerodocumento", txtnumerodocumento.Text);


            Texto_Html = Texto_Html.Replace("@placa", txtPlaca.Text);
            Texto_Html = Texto_Html.Replace("@nombrecliente", txtnombrecliente.Text);
            Texto_Html = Texto_Html.Replace("@fecharegistro", txtfecha.Text);
            Texto_Html = Texto_Html.Replace("@tipopago", txttipopago.Text);

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
            Texto_Html = Texto_Html.Replace("@pagocon", txtmontopago.Text);
            Texto_Html = Texto_Html.Replace("@cambio", txtmontocambio.Text);

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("Servicio_{0}.pdf", txtnumerodocumento.Text);
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
    }
}
