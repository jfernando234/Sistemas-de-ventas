using CapaEntidad;
using CapaNegocio;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using Sistemas_de_ventas.Modales;
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
    public partial class frm_serCotizacion : Form
    {
        public frm_serCotizacion()
        {
            InitializeComponent();
        }

        private void frm_serCotizacion_Load(object sender, EventArgs e)
        {

            cbotipodocumento.Items.Add(new OpcionCombo() { Valor = "Cotizacion", Texto = "Cotizacion" });

            cbotipodocumento.DisplayMember = "Texto";
            cbotipodocumento.ValueMember = "Valor";
            cbotipodocumento.SelectedIndex = 0;

            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txttotalpagar.Text = "0";
        }

        private void bntbuscarcliente_Click(object sender, EventArgs e)
        {
            using (var modal = new mdCliente())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtplaca.Text = modal._Cliente.Placa;
                    txtnombrecliente.Text = modal._Cliente.NombreCompleto;
                }
                else
                {
                    txtplaca.Select();
                }
            }
        }

        private void bntagregarservicio_Click(object sender, EventArgs e)
        {
            decimal precio = 0;
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtservicio.Text) || string.IsNullOrWhiteSpace(txtprecio.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            if (!decimal.TryParse(txtprecio.Text, out precio))
            {
                MessageBox.Show("Precio - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtprecio.Select();
                return;
            }

            dgvdata.Rows.Add(new object[]
            {
                 txtservicio.Text.Trim(),    // Nombre del servicio
                 precio                      // Precio del servicio
            });


            calcularTotal();
            // Limpiar los campos de entrada
            txtservicio.Clear();
            txtprecio.Clear();

        }
        private void calcularTotal()
        {
            decimal total = 0;
            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                    total += Convert.ToDecimal(row.Cells["Precio"].Value.ToString());
            }
            txttotalpagar.Text = total.ToString("0.00");
        }

        private void btncrearventa_Click(object sender, EventArgs e)
        {
            if (txtplaca.Text == "")
            {
                MessageBox.Show("Debe ingresar documento del cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtnombrecliente.Text == "")
            {
                MessageBox.Show("Debe ingresar nombre del cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dgvdata.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable detalle_venta = new DataTable();

            detalle_venta.Columns.Add("Descripcion", typeof(string));
            detalle_venta.Columns.Add("Precio", typeof(decimal));


            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                detalle_venta.Rows.Add(new object[] {
                    row.Cells["Descripcion"].Value.ToString(),
                    row.Cells["Precio"].Value.ToString(),
                });
            }

            VentaServicio oVentaServicio = new VentaServicio()
            {
                TipoDocumento = ((OpcionCombo)cbotipodocumento.SelectedItem).Texto,              
                Placa = txtplaca.Text,
                NombreCliente = txtnombrecliente.Text,              
                MontoTotal = Convert.ToDecimal(txttotalpagar.Text),
                detalleDescripcion = txtdescripcion.Text
            };


            string mensaje = string.Empty;
            bool respuesta = new CN_Venta().RegistrarServicioCOTI(oVentaServicio, detalle_venta, out mensaje);

            if (respuesta)
            {
                var result = MessageBox.Show("Numero de venta generada:\n" + "\n\n¿Desea copiar al portapapeles?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                descargar();

                txtplaca.Text = "";
                txtnombrecliente.Text = "";
                dgvdata.Rows.Clear();
                calcularTotal();
            }
            else
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void descargar()
        {
            string Texto_Html = Properties.Resources.PlantillaCservicio.ToString();
            Negocio odatos = new CN_Negocio().ObtenerDatos();

            string tipodocumetno = ((OpcionCombo)cbotipodocumento.SelectedItem).Texto;

            Texto_Html = Texto_Html.Replace("@nombrenegocio", odatos.Nombre.ToUpper());
            Texto_Html = Texto_Html.Replace("@docnegocio", odatos.RUC);
            Texto_Html = Texto_Html.Replace("@direcnegocio", odatos.Direccion);

            Texto_Html = Texto_Html.Replace("@tipodocumento", tipodocumetno.ToUpper());

            Texto_Html = Texto_Html.Replace("@placa", txtplaca.Text);
            Texto_Html = Texto_Html.Replace("@nombrecliente", txtnombrecliente.Text);
            Texto_Html = Texto_Html.Replace("@fecharegistro", txtfecha.Text);
            string filas = string.Empty;
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Descripcion"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Precio"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            Texto_Html = Texto_Html.Replace("@filas", filas);
            Texto_Html = Texto_Html.Replace("@montototal", txttotalpagar.Text);
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

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btneliminar")
            {
                int index = e.RowIndex;

                // Validar que el índice sea válido
                if (index >= 0)
                {
                    // Eliminar la fila del DataGridView
                    dgvdata.Rows.RemoveAt(index);
                }
            }
        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtprecio.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }

            }
        }
    }
}
