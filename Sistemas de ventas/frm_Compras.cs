using CapaEntidad;
using CapaNegocio;
using ClosedXML.Excel;
using iTextSharp.text.pdf.qrcode;
using Sistemas_de_ventas.Modales;
using Sistemas_de_ventas.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistemas_de_ventas
{
    public partial class frm_Compras : Form
    {
        private Usuario _Usuario;
        public frm_Compras(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;

            InitializeComponent();
        }

        private void frm_Compras_Load(object sender, EventArgs e)
        {
            cbotipodocumento.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Boleta" });
            cbotipodocumento.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Factura" });
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

            txtidproveedor.Text = "0";
            txtidproducto.Text = "0";

        }

        private void bntbuscarproveedor_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProveedor())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtidproveedor.Text = modal._Proveedor.IdProveedor.ToString();
                    txtdocproveedor.Text = modal._Proveedor.Ruc;
                    txtnombreproveedor.Text = modal._Proveedor.RazonSocial;
                }
                else
                {
                    txtdocproveedor.Select();
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
                    txtpreciocompra.Text = Convert.ToString(modal._Producto.PrecioCompra);
                    txtprecioventa.Text = Convert.ToString(modal._Producto.PrecioVenta);
                    txtpreciollevar.Text = Convert.ToString(modal._Producto.PrecioLlevar);

                }
                else
                {
                    txtcodproducto.Select();
                }

            }
        }

        private void txtcodproducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {

                Producto oProducto = new CN_Producto().Listar().Where(p => p.Codigo == txtcodproducto.Text ).FirstOrDefault();

                if (oProducto != null)
                {
                    txtcodproducto.BackColor = Color.Honeydew;
                    txtidproducto.Text = oProducto.IdProducto.ToString();
                    txtproducto.Text = oProducto.Descripcion;
                    txtpreciocompra.Select();
                }
                else
                {
                    txtcodproducto.BackColor = Color.MistyRose;
                    txtidproducto.Text = "0";
                    txtproducto.Text = "";
                }
            }
        }

        private void bntagregarproducto_Click(object sender, EventArgs e)
        {
            decimal preciocompra = 0;
            decimal precioventa = 0;
            decimal preciollevar = 0;
            bool producto_existe = false;

            if (txtcodproducto.Text.Trim() == "")
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(txtpreciocompra.Text, out preciocompra))
            {
                MessageBox.Show("Precio Compra - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtpreciocompra.Select();
                return;
            }

            if (!decimal.TryParse(txtprecioventa.Text, out precioventa))
            {
                MessageBox.Show("Precio Venta - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtprecioventa.Select();
                return;
            }
            if (!decimal.TryParse(txtpreciollevar.Text, out preciollevar))
            {
                MessageBox.Show("Precio Cambio - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtprecioventa.Select();
                return;
            }

            foreach (DataGridViewRow fila in dgvdata.Rows)
            {
                if (fila.Cells["Codigo"].Value != null &&
                    fila.Cells["Codigo"].Value.ToString().ToLower() == txtcodproducto.Text.ToLower())
                {
                    producto_existe = true;
                    break;
                }
            }

            if (!producto_existe)
            {
                dgvdata.Rows.Add(new object[] {
                    txtcodproducto.Text,
                    txtproducto.Text,
                    txtcantidad.Value.ToString(),
                    txtpreciocompra.Text,
                    txtprecioventa.Text,
                    txtpreciollevar.Text,

                    //txtubicacion.Text,
                    txtfecha.Text,
                    //txtcategoria.Text,
                    (txtcantidad.Value * preciocompra).ToString("0.00"),
                    string.IsNullOrWhiteSpace(txtidproducto.Text) ? "" : txtidproducto.Text

                });
                calcularTotal();
                limpiarProducto();
                txtcodproducto.Select();
            }
        }
        private void limpiarProducto()
        {
            txtidproducto.Text = "0";
            txtcodproducto.Text = "";
            txtcodproducto.BackColor = Color.White;
            txtproducto.Text = "";
            txtpreciocompra.Text = "";
            txtpreciollevar.Text = "";
            txtprecioventa.Text = "";
            txtcantidad.Value = 1;
        }

        private void calcularTotal()
        {
            decimal total = 0;
            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
            }
            txttotalpagar.Text = total.ToString("0.00");
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btneliminar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    dgvdata.Rows.RemoveAt(indice);
                    calcularTotal();
                }
            }
        }

        private void txtpreciocompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtpreciocompra.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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

        private void txtprecioventa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtprecioventa.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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
            if(txtdocproveedor.Text == "")
            {
                MessageBox.Show("Debe ingresar el ruc del Proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtcorrelativo.Text == "")
            {
                MessageBox.Show("Debe ingresar el El numero Documento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtnombreproveedor.Text == "")
            {
                MessageBox.Show("Debe ingresar la Razon social del proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dgvdata.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos en la compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable detalle_compra = new DataTable();

            detalle_compra.Columns.Add("IdProducto", typeof(string));
            //detalle_compra.Columns.Add("Descripcion", typeof(string));
            detalle_compra.Columns.Add("Cantidad", typeof(int));
            //detalle_compra.Columns.Add("Ubicacion", typeof(string));
            detalle_compra.Columns.Add("PrecioCompra", typeof(decimal));
            detalle_compra.Columns.Add("PrecioVenta", typeof(decimal));
            detalle_compra.Columns.Add("PrecioLlevar", typeof(decimal));
            //detalle_compra.Columns.Add("FechaRegistro", typeof(string));
            //detalle_compra.Columns.Add("Categoria", typeof(string));
            detalle_compra.Columns.Add("MontoTotal", typeof(decimal));
         

            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                detalle_compra.Rows.Add(
                    new object[] {
                       row.Cells["IdProducto"].Value.ToString(),
                       //row.Cells["Descripcion"].Value.ToString(),
                       row.Cells["Cantidad"].Value.ToString(),
                       //row.Cells["Ubicacion"].Value.ToString(),
                       row.Cells["PrecioCompra"].Value.ToString(),
                       row.Cells["PrecioVenta"].Value.ToString(),
                       row.Cells["PrecioLlevar"].Value.ToString(),
                       //row.Cells["FechaRegistro"].Value.ToString(),
                       //row.Cells["Categoria"].Value.ToString(),
                       row.Cells["SubTotal"].Value.ToString(),
                       
                    });

            }
          
            Compra oCompra = new Compra()
            {
                oUsuario = new Usuario() { IdUsuario = _Usuario.IdUsuario },
                RazonSocial = txtnombreproveedor.Text,
                Ruc = Convert.ToInt32(txtdocproveedor.Text),
                TipoDocumento = ((OpcionCombo)cbotipodocumento.SelectedItem).Texto,
                TipoPago = ((OpcionCombo)cmbtipopago.SelectedItem).Texto,
                NumeroDocumento = txtcorrelativo.Text,
                MontoTotal = Convert.ToDecimal(txttotalpagar.Text)
            };

            string mensaje = string.Empty;
            bool respuesta = new CN_Compra().Registrar(oCompra, detalle_compra, out mensaje);

            if (respuesta)
            {
                var result = MessageBox.Show("Numero de compra generada");


                txtidproveedor.Text = "0";
                txtcorrelativo.Text = "";
                txtdocproveedor.Text = "";
                txtnombreproveedor.Text = "";
                dgvdata.Rows.Clear();
                calcularTotal();

            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtprecioventa.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos Excel (*.xlsx)|*.xlsx",
                Title = "Seleccionar Archivo Excel"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog.FileName;

                try
                {
                    List<Producto> productos = Leerdatos(rutaArchivo);

                    // Obtener códigos ya cargados en el DataGridView
                    HashSet<string> codigosExistentes = new HashSet<string>(
                        dgvdata.Rows
                            .Cast<DataGridViewRow>()
                            .Where(row => row.Cells["Codigo"].Value != null)
                            .Select(row => row.Cells["Codigo"].Value.ToString().ToLower())
                    );

                    // Filtrar productos no repetidos (ignorando mayúsculas/minúsculas)
                    var nuevosProductos = productos
                        .Where(p => !codigosExistentes.Contains(p.Codigo.ToLower()))
                        .ToList();

                    // Agregar al DataGridView
                    foreach (var producto in nuevosProductos)
                    {
                        decimal subtotal = producto.PrecioCompra * producto.Stock;
                        dgvdata.Rows.Add(
                            producto.Codigo,
                            producto.Descripcion,
                            producto.Stock,
                            producto.Ubicacion,
                            producto.PrecioCompra,
                            producto.PrecioVenta,
                            producto.PrecioLlevar,
                            producto.FechaRegistro,
                            producto.Categoria,
                            subtotal
                        );
                    }
                    calcularTotal();
                    MessageBox.Show("Productos cargados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private List<Producto> Leerdatos(string rutaArchivo)
        {
            List<Producto> productos = new List<Producto>();

            using (var workbook = new XLWorkbook(rutaArchivo))
            {
                var worksheet = workbook.Worksheet(1);
                var rows = worksheet.RangeUsed().RowsUsed().Skip(1); // Asumiendo que la primera fila son encabezados

                foreach (var row in rows)
                {
                    try
                    {
                        Producto producto = new Producto
                        {
                            Codigo = row.Cell(1).GetValue<string>().Trim(),
                            Descripcion = row.Cell(2).GetValue<string>().Trim(),
                            Stock = row.Cell(3).TryGetValue<int>(out int stock) ? stock : 0,
                            Ubicacion = row.Cell(4).GetValue<string>().Trim(),
                            PrecioCompra = row.Cell(5).TryGetValue<decimal>(out decimal precioCompra) ? precioCompra : 0m,
                            PrecioVenta = row.Cell(6).TryGetValue<decimal>(out decimal precioVenta) ? precioVenta : 0m,
                            PrecioLlevar = row.Cell(7).TryGetValue<decimal>(out decimal precioLlevar) ? precioLlevar : 0m,
                            FechaRegistro = row.Cell(8).TryGetValue<DateTime>(out DateTime fecha) ? fecha.ToString("dd/MM/yyyy") : string.Empty,
                            Categoria = row.Cell(9).GetValue<string>().Trim()
                        };

                        // Validar campos obligatorios
                        if (!string.IsNullOrWhiteSpace(producto.Codigo) && !string.IsNullOrWhiteSpace(producto.Descripcion))
                        {
                            productos.Add(producto);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"Error en la fila {row.RowNumber()}: {ex.Message}");
                    }
                }
            }

            return productos;

        }

        private void txtdocproveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtdocproveedor.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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

        private void txtpreciollevar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtprecioventa_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtpreciocompra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
