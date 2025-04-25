using CapaEntidad;
using CapaNegocio;
using Sistemas_de_ventas.Modales;
using Sistemas_de_ventas.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistemas_de_ventas
{
    public partial class frm_Servicios : Form
    {
        public frm_Servicios()
        {
            InitializeComponent();
        }
        private void frm_Servicios_Load(object sender, EventArgs e)
        {
            txtruc.ReadOnly = true;

            cbotipodocumento.Items.Add(new OpcionCombo() { Valor = "Boleta", Texto = "Boleta" });
            cbotipodocumento.Items.Add(new OpcionCombo() { Valor = "Factura", Texto = "Factura" });
            cbotipodocumento.Items.Add(new OpcionCombo() { Valor = "Proforma", Texto = "Proforma" });
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

        private void txtpagocon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                calcularcambio();
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
                MessageBox.Show("Debe ingresar el kilometraje o Colocar 0", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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


            string tipoDocumentoSeleccionado = ((OpcionCombo)cbotipodocumento.SelectedItem).Texto;

            // Obtener el correlativo basado en el tipo de documento
            int idcorrelativo = new CN_Venta().ObtenerCorrelativo(tipoDocumentoSeleccionado);

            // Formatear el número de documento
            string numeroDocumento = string.Format("{0:00000}", idcorrelativo);

            calcularcambio();

            VentaServicio oVentaServicio = new  VentaServicio()
            {
                TipoDocumento = ((OpcionCombo)cbotipodocumento.SelectedItem).Texto,
                TipoPago = ((OpcionCombo)cmbtipopago.SelectedItem).Texto,
                NumeroDocumento = numeroDocumento,
                Placa = txtplaca.Text,
                NombreCliente = txtnombrecliente.Text,
                Ruc = txtruc.Text,
                Kilometraje = Convert.ToInt32(txtkilometraje.Text),
                MontoPago = Convert.ToDecimal(txtpagocon.Text),
                MontoCambio = Convert.ToDecimal(txtcambio.Text),
                MontoTotal = Convert.ToDecimal(txttotalpagar.Text)
            };


            string mensaje = string.Empty;
            bool respuesta = new CN_Venta().RegistrarServicio(oVentaServicio, detalle_venta, out mensaje);

            if (respuesta)
            {
                var result = MessageBox.Show("Numero de venta generada:\n" + numeroDocumento + "\n\n¿Desea copiar al portapapeles?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                    Clipboard.SetText(numeroDocumento);

                txtplaca.Text = "";
                txtnombrecliente.Text = "";
                dgvdata.Rows.Clear();
                calcularTotal();
                txtpagocon.Text = "";
                txtcambio.Text = "";
            }
            else
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
    }
}
