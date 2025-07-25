﻿using CapaEntidad;
using CapaNegocio;

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using Sistemas_de_ventas.Modales;
using Sistemas_de_ventas.Utilidades;
using System;

using System.Data;

using System.IO;

using System.Windows.Forms;

namespace Sistemas_de_ventas
{
    public partial class frm_Ventas : Form
    {        
        public frm_Ventas()
        {
            
            InitializeComponent();
        }

        private void frm_Ventas_Load(object sender, EventArgs e)
        {
            txtruc.ReadOnly = true;

            cbotipodocumento.Items.Add(new OpcionCombo() { Valor = "Boleta", Texto = "Boleta" });
            cbotipodocumento.Items.Add(new OpcionCombo() { Valor = "Factura", Texto = "Factura" });
            cbotipodocumento.Items.Add(new OpcionCombo() { Valor = "Proforma ", Texto = "Proforma" });
            cbotipodocumento.DisplayMember = "Texto";
            cbotipodocumento.ValueMember = "Valor";
            cbotipodocumento.SelectedIndex = 0;

            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            cmbtipopago.Items.Add(new OpcionCombo() { Valor = "Efectivo", Texto = "Efectivo" });
            cmbtipopago.Items.Add(new OpcionCombo() { Valor = "Yape", Texto = "Yape" });
            cmbtipopago.Items.Add(new OpcionCombo() { Valor = "Tarjeta", Texto = "Tarjeta" });
            cmbtipopago.Items.Add(new OpcionCombo() { Valor = "Plin", Texto = "Plin" });
            cmbtipopago.Items.Add(new OpcionCombo() { Valor = "Transferencia", Texto = "Transferencia" });
            cmbtipopago.DisplayMember = "Texto";
            cbotipodocumento.ValueMember = "Valor";
            cmbtipopago.SelectedIndex = 0;

            cbotipodocumento.SelectedIndexChanged += new EventHandler(cbotipodocumento_SelectedIndexChanged);

            txtpagocon.Text = "";
            txtcambio.Text = "";
            txttotalpagar.Text = "0";
            txtidproducto.Text = "0";
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
                    txtruc.Text = "";
                }
                else
                {
                    txtplaca.Select();
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
        

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btneliminar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    bool respuesta = new CN_Venta().SumarStock(
                        Convert.ToString(dgvdata.Rows[index].Cells["Id"].Value.ToString()),
                        Convert.ToInt32(dgvdata.Rows[index].Cells["Cantidad"].Value.ToString()));

                    if (respuesta)
                    {
                        dgvdata.Rows.RemoveAt(index);
                        calcularTotal();
                    }

                }
            }
        }

        private void txtpagocon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtpagocon.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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
        private void calcularcambio()
        {

            if (txttotalpagar.Text.Trim() == "")
            {
                MessageBox.Show("No existen productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            decimal pagacon;
            decimal total = Convert.ToDecimal(txttotalpagar.Text);

            if (txtpagocon.Text.Trim() == "")
            {
                txtpagocon.Text = "0";
            }

            if (decimal.TryParse(txtpagocon.Text.Trim(), out pagacon))
            {

                if (pagacon < total)
                {
                    txtcambio.Text = "0.00";
                }
                else
                {
                    decimal cambio = pagacon - total;
                    txtcambio.Text = cambio.ToString("0.00");

                }
            }
        }

        private void txtpagocon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                calcularcambio();
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

            if (Convert.ToInt32(txtstock.Text) < Convert.ToInt32(txtcantidad.Value.ToString()))
            {
                MessageBox.Show("La cantidad no puede ser mayor al stock", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                bool respuesta = new CN_Venta().RestarStock(
                    Convert.ToInt32(txtidproducto.Text),
                    Convert.ToInt32(txtcantidad.Value.ToString())
                    );

                if (respuesta)
                {
                    dgvdata.Rows.Add(new object[] {
                        txtcodproducto.Text,
                        txtproducto.Text,
                        txtcantidad.Value.ToString(),
                        precio.ToString("0.00"),
                        (txtcantidad.Value * precio).ToString("0.00")
                    });

                    calcularTotal();
                    limpiar();
                    txtcodproducto.Select();
                }
            }
        }
        public void limpiar()
        {
            txtcodproducto.Text = "";
            txtproducto.Text = "";
            txtcantidad.Value= 1;
            txtstock.Text = " ";
            txtprecio.Text = " ";

        }
        private void Descargar()
        {
           
                string Texto_Html = Properties.Resources.PlantillaVenta.ToString();
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

                string tipoDocumentoSeleccionado = ((OpcionCombo)cbotipodocumento.SelectedItem).Texto;
                int idcorrelativo = new CN_Venta().ObtenerCorrelativo(tipoDocumentoSeleccionado);
                string numeroDocumento = string.Format("{0:00000}", idcorrelativo);

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("Venta_{0}.pdf", idcorrelativo.ToString());
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
        private void btncrearventa_Click(object sender, EventArgs e)
        {
            if (txtplaca.Text == "")
            {
                MessageBox.Show("Debe ingresar documento del cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtkilometraje.Text == "")
            {
                MessageBox.Show("Debe ingresar el Kilometraje o Poner 0", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

            detalle_venta.Columns.Add("Id", typeof(string));
            detalle_venta.Columns.Add("Descripcion", typeof(string));
            detalle_venta.Columns.Add("Cantidad", typeof(int));
            detalle_venta.Columns.Add("Precio", typeof(decimal));
            detalle_venta.Columns.Add("SubTotal", typeof(decimal));           


            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                detalle_venta.Rows.Add(new object[] {
                    Convert.ToString(row.Cells["Id"].Value),
                    Convert.ToString(row.Cells["Descripcion"].Value),
                    Convert.ToInt32(row.Cells["Cantidad"].Value),
                    Convert.ToDecimal(row.Cells["Precio"].Value),
                    Convert.ToDecimal(row.Cells["SubTotal"].Value)
                });
            }
            
            foreach (DataGridViewRow row2 in dgvdataser.Rows)
            {
                detalle_venta.Rows.Add(new object[]
                {
                    Convert.ToString(row2.Cells["Ids"].Value),
                    Convert.ToString(row2.Cells["Descripcions"].Value),
                    Convert.ToInt32(row2.Cells["Cantidads"].Value),
                    Convert.ToDecimal(row2.Cells["Precios"].Value),
                    Convert.ToDecimal(row2.Cells["SubTotals"].Value)
                });
            }
            

            string tipoDocumentoSeleccionado = ((OpcionCombo)cbotipodocumento.SelectedItem).Texto;

            // Obtener el correlativo basado en el tipo de documento
            int idcorrelativo = new CN_Venta().ObtenerCorrelativo(tipoDocumentoSeleccionado);

            // Formatear el número de documento
            string numeroDocumento = string.Format("{0:00000}", idcorrelativo);
            calcularcambio();

            Venta oVenta = new Venta()
            {               
                TipoDocumento = tipoDocumentoSeleccionado,
                TipoPago = ((OpcionCombo)cmbtipopago.SelectedItem).Texto,
                NumeroDocumento = numeroDocumento,
                NombreCliente = txtnombrecliente.Text,
                Placa = txtplaca.Text,                
                Ruc = txtruc.Text,
                Kilometraje = Convert.ToInt32(txtkilometraje.Text),
                MontoPago = Convert.ToDecimal(txtpagocon.Text),
                MontoCambio = Convert.ToDecimal(txtcambio.Text),
                MontoTotal = Convert.ToDecimal(txttotalpagar.Text)
            };


            string mensaje = string.Empty;
            bool respuesta = new CN_Venta().Registrar(oVenta, detalle_venta, out mensaje);

            if (respuesta)
            {

                var result = MessageBox.Show("Numero de venta generada:\n" + numeroDocumento + "\n\n¿Desea Guardar el Comprobante?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                    Clipboard.SetText(numeroDocumento);
                Descargar();
                txtplaca.Text = "";
                txtnombrecliente.Text = "";
                txtruc.Text = "";
                txtkilometraje.Text = "";
                dgvdata.Rows.Clear();
                dgvdataser.Rows.Clear();
                calcularTotal();
                txtpagocon.Text = "";
                txtcambio.Text = "";
            }
            else
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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
        private void cbotipodocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica si el tipo de documento seleccionado es "Factura"
            if (cbotipodocumento.SelectedItem != null && ((OpcionCombo)cbotipodocumento.SelectedItem).Valor.ToString() == "Factura")
            {
                txtruc.ReadOnly = false; // Habilita la edición del campo RUC
            }
            else
            {
                txtruc.ReadOnly = true; // Deshabilita la edición del campo RUC
            }
        }

        private void txtkilometraje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtkilometraje.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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

        private void dgvdataser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btneliminars")
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
