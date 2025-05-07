using CapaEntidad;
using CapaNegocio;
using DocumentFormat.OpenXml.Spreadsheet;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using Sistemas_de_ventas.Utilidades;
using Sistemas_de_ventas.Modales;
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
    public partial class frm_Cotizacion : Form
    {
        public frm_Cotizacion()
        {
            InitializeComponent();
        }

        private void frm_Cotizacion_Load(object sender, EventArgs e)
        {

            cbotipodocumento.Items.Add(new OpcionCombo() { Valor = "Cotizacion", Texto = "Cotizacion" });
            
            cbotipodocumento.DisplayMember = "Texto";
            cbotipodocumento.ValueMember = "Valor";
            cbotipodocumento.SelectedIndex = 0;

            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtidproducto.Text = "0";

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
                    txtcodproducto.Select();
                }
                else
                {
                    txtplaca.Select();
                }
            }
        }
        private void bntbuscarproducto_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProducto())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtidproducto.Text = modal._Producto.IdProducto.ToString();
                    txtcodproducto.Text = modal._Producto.Codigo;
                    txtproducto.Text = modal._Producto.Descripcion;
                    txtprecio.Text = modal._Producto.PrecioVenta.ToString("0.00");
                    txtstock.Text = modal._Producto.Stock.ToString();
                    txtcantidad.Select();
                }
                else
                {
                    txtcodproducto.Select();
                }
            }
        }

        private void bntagregarproducto_Click(object sender, EventArgs e)
        {
            decimal precio = 0;
            bool producto_existe = false;

            if (int.Parse(txtidproducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(txtprecio.Text, out precio))
            {
                MessageBox.Show("Precio - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtprecio.Select();
                return;
            }

            foreach (DataGridViewRow fila in dgvdata.Rows)
            {
                if (fila.Cells["Id"].Value.ToString() == txtidproducto.Text)
                {
                    producto_existe = true;
                    break;
                }
            }

            if (!producto_existe)
            {
                dgvdata.Rows.Add(new object[] {
                    txtidproducto.Text,
                    txtproducto.Text,                   
                    txtcantidad.Value.ToString(),
                    precio.ToString("0.00"),
                    (txtcantidad.Value * precio).ToString("0.00")
                });
                calcularTotal();
                limpiarProducto();
                txtcodproducto.Select();

            }
        }

        private void txtcodproducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Producto oProducto = new CN_Producto().Listar()
                    .Where(p => string.Equals(p.Codigo, txtcodproducto.Text, StringComparison.OrdinalIgnoreCase))
                    .FirstOrDefault();

                if (oProducto != null)
                {
                    
                    txtidproducto.Text = oProducto.IdProducto.ToString();
                    
                    txtprecio.Text = oProducto.PrecioVenta.ToString("0.00");

                    txtcantidad.Select();
                }
                else
                {
                    
                    txtidproducto.Text = "0";
                    txtproducto.Text = "";
                    txtprecio.Text = "";

                    txtcantidad.Value = 1;
                }
            }
        }
        private void calcularTotal()
        {
            decimal totalProductos = 0;
            decimal totalServicios = 0;

            // Sumar subtotales de productos
            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    if (row.Cells["SubTotal"] != null && row.Cells["SubTotal"].Value != null)
                    {
                        totalProductos += Convert.ToDecimal(row.Cells["SubTotal"].Value);
                    }
                }
            }

            // Sumar subtotales de servicios
            if (dgvdataser.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdataser.Rows)
                {
                    if (row.Cells["SubTotals"] != null && row.Cells["SubTotals"].Value != null)
                    {
                        totalServicios += Convert.ToDecimal(row.Cells["SubTotals"].Value);
                    }
                }
            }

            // Sumar totales de ambos
            decimal totalFinal = totalProductos + totalServicios;

            txttotalpagar.Text = totalFinal.ToString("0.00");
        }

        private void limpiarProducto()
        {
            txtidproducto.Text = "0";
            txtcodproducto.Text = "";
            txtproducto.Text = "";
            txtprecio.Text = "";
            txtstock.Text = "";
            txtcantidad.Value = 1;
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

            detalle_venta.Columns.Add("Id", typeof(int));
            detalle_venta.Columns.Add("Descripcion", typeof(string));          
            detalle_venta.Columns.Add("Cantidad", typeof(int));
            detalle_venta.Columns.Add("Precio", typeof(decimal));
            detalle_venta.Columns.Add("SubTotal", typeof(decimal));


            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                detalle_venta.Rows.Add(new object[] {
                    row.Cells["Id"].Value.ToString(),
                    row.Cells["Descripcion"].Value.ToString(),
                    row.Cells["Cantidad"].Value.ToString(),
                    row.Cells["Precio"].Value.ToString(),
                    row.Cells["SubTotal"].Value.ToString()
                });
            }
            foreach (DataGridViewRow row2 in dgvdataser.Rows)
            {
                detalle_venta.Rows.Add(new object[] {
                    row2.Cells["Ids"].Value.ToString(),
                    row2.Cells["Descripcions"].Value.ToString(),
                    row2.Cells["Cantidads"].Value.ToString(),
                    row2.Cells["Precios"].Value.ToString(),
                    row2.Cells["SubTotals"].Value.ToString()
                });
            }
            Venta oVenta = new Venta()
            {
                TipoDocumento = ((OpcionCombo)cbotipodocumento.SelectedItem).Texto,             
                NombreCliente = txtnombrecliente.Text,
                Placa = txtplaca.Text,
                Descripcion = txtdescripcion.Text,
                MontoTotal = Convert.ToDecimal(txttotalpagar.Text)
            };


            string mensaje = string.Empty;
            bool respuesta = new CN_Venta().RegistrarCotizacion(oVenta, detalle_venta, out mensaje);

            if (respuesta)
            {
                var result = MessageBox.Show("Numero de venta generada:"+"\n\n¿Desea Descargar la Cotizacion?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

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
            string Texto_Html = Properties.Resources.PlantillaCotizacion.ToString();
            Negocio odatos = new CN_Negocio().ObtenerDatos();

            string tipodocumetno = ((OpcionCombo)cbotipodocumento.SelectedItem).Texto;

            Texto_Html = Texto_Html.Replace("@nombrenegocio", odatos.Nombre.ToUpper());
            Texto_Html = Texto_Html.Replace("@docnegocio", odatos.RUC);
            Texto_Html = Texto_Html.Replace("@direcnegocio", odatos.Direccion);

            Texto_Html = Texto_Html.Replace("@tipodocumento", tipodocumetno.ToUpper());

            Texto_Html = Texto_Html.Replace("@placa", txtplaca.Text);
            Texto_Html = Texto_Html.Replace("@nombrecliente", txtnombrecliente.Text);
            Texto_Html = Texto_Html.Replace("@fecharegistro", txtfecha.Text);
            string filas = "";

            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                filas += "<div class='detalle-item'>";
                filas += "<label>" + row.Cells["Descripcion"].Value.ToString() + "</label>";
                filas += "<label>Cant: " + row.Cells["Cantidad"].Value.ToString() +
                         " | P.U.: " + row.Cells["Precio"].Value.ToString() +
                         " | SubTotal: " + row.Cells["SubTotal"].Value.ToString() + "</label>";
                filas += "</div>";
            }

            foreach (DataGridViewRow row in dgvdataser.Rows)
            {
                filas += "<div class='detalle-item'>";
                filas += "<label>" + row.Cells["Descripcions"].Value.ToString() + "</label>";
                filas += "<label>Cant: " + row.Cells["Cantidads"].Value.ToString() +
                         " | P.U.: " + row.Cells["Precios"].Value.ToString() +
                         " | SubTotal: " + row.Cells["SubTotals"].Value.ToString() + "</label>";
                filas += "</div>";
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
                if (index >= 0)
                {
                     dgvdata.Rows.RemoveAt(index);
                     calcularTotal();
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            using (var modal = new mdServicio())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var servicio = modal.ServicioSelecionado;

                    bool servicio_existe = false;
                    foreach (DataGridViewRow fila in dgvdata.Rows)
                    {
                        if (fila.Cells["Id"].Value.ToString() == servicio.IdServicio.ToString())
                        {
                            servicio_existe = true;
                            break;
                        }
                    }

                    if (!servicio_existe)
                    {
                        int cantidad = 1; // Puedes mostrar un input para que el usuario elija
                        bool respuesta = servicio.Cantidad >= cantidad;

                        if (respuesta)
                        {
                            dgvdataser.Rows.Add(new object[] {
                                servicio.IdServicio,
                                servicio.Descripcion,
                                cantidad.ToString(),
                                servicio.Precio,
                                (cantidad * servicio.Precio).ToString("0.00")

                            });

                            calcularTotal();
                        }
                        else
                        {
                            MessageBox.Show("No hay stock disponible.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El producto ya fue agregado.");
                    }
                }
            }
        }

  

        private void dgvdataser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdataser.Columns[e.ColumnIndex].Name == "btneliminar2")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    dgvdataser.Rows.RemoveAt(index);
                    calcularTotal();
                }
            }
        }
    }
}
