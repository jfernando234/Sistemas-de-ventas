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
    public partial class frm_DetalleCompra : Form
    {
        public frm_DetalleCompra()
        {
            InitializeComponent();
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
            txtfecha.Text = "";
            txttipodocumento.Text = "";
            txtusuario.Text = "";
            txtdocproveedor.Text = "";
            txtnombreproveedor.Text = "";

            dgvdata.Rows.Clear();
            txtmontototal.Text = "0.00";
        }

        private void btndesarga_Click(object sender, EventArgs e)
        {
            if (txttipodocumento.Text == "")
            {
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string Texto_Html = Properties.Resources.PlantillaCompra.ToString();
            Negocio odatos = new CN_Negocio().ObtenerDatos();

            Texto_Html = Texto_Html.Replace("@nombrenegocio", odatos.Nombre.ToUpper());
            Texto_Html = Texto_Html.Replace("@ruc", odatos.RUC);
            Texto_Html = Texto_Html.Replace("@direcnegocio", odatos.Direccion);

            Texto_Html = Texto_Html.Replace("@tipodocumento", txttipodocumento.Text.ToUpper());
            Texto_Html = Texto_Html.Replace("@numerodocumento", txtnumerodocumento.Text);


            Texto_Html = Texto_Html.Replace("@docproveedor", txtdocproveedor.Text);
            Texto_Html = Texto_Html.Replace("@nombreproveedor", txtnombreproveedor.Text);
            Texto_Html = Texto_Html.Replace("@fecharegistro", txtfecha.Text);
            Texto_Html = Texto_Html.Replace("@usuarioregistro", txtusuario.Text);
            Texto_Html = Texto_Html.Replace("@tipopago", txttipopago.Text);

            string filas = string.Empty;
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Producto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["PrecioCompra"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["SubTotal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            Texto_Html = Texto_Html.Replace("@filas", filas);
            Texto_Html = Texto_Html.Replace("@montototal", txtmontototal.Text);

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("Compra_{0}.pdf", txtnumerodocumento.Text);
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

        private void frm_DetalleCompra_Load(object sender, EventArgs e)
        {
            List<Compra> lista = new CN_Compra().Listar();

            foreach (Compra item in lista)
            {
                dgvtotal.Rows.Add(new object[] {"",    
                    item.IdCompra,
                    item.NumeroDocumento,       
                    item.TipoDocumento,
                    item.oUsuario,
                    item.oProveedor.Ruc,
                    item.oProveedor.RazonSocial,
                    item.TipoPago,
                    item.MontoTotal,
                    item.FechaRegistro,
                });
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
                    txtid.Text = dgvtotal.Rows[indice].Cells["IdCompra"].Value.ToString();
                    txtnumerodocumento.Text = dgvtotal.Rows[indice].Cells["NumeroDocumento"].Value.ToString();
                    txttipodocumento.Text = dgvtotal.Rows[indice].Cells["TipoDocumento"].Value.ToString();
                    txtusuario.Text = dgvtotal.Rows[indice].Cells["Usuario"].Value.ToString();
                    txtdocproveedor.Text = dgvtotal.Rows[indice].Cells["Ruc"].Value.ToString();
                    txttipopago.Text = dgvtotal.Rows[indice].Cells["TipoPago"].Value.ToString();
                    txtmontototal.Text = dgvtotal.Rows[indice].Cells["Total"].Value.ToString();
                    txtfecha.Text = dgvtotal.Rows[indice].Cells["Fecha"].Value.ToString();

                    // Obtener el IdVenta para buscar los productos
                    int idCompra = Convert.ToInt32(txtid.Text);

                    dgvdata.Rows.Clear();
                    // Llamar al método para obtener los productos asociados a la venta
                    List<Detalle_Compra> detalleCompra = new CN_Compra().ObtenerProductoPorIdCompra(idCompra);

                    foreach (Detalle_Compra item in detalleCompra)
                    {
                        dgvdata.Rows.Add(new object[] {
                               item.oProducto.Descripcion,
                               item.PrecioCompra,
                               item.Cantidad,
                               item.MontoTotal
                        });
                    }
                }
            }
        }
    }
}
