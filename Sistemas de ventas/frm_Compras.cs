﻿using CapaEntidad;
using CapaNegocio;
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
                    txtpreciocompra.Select();
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
                    txtproducto.Text = oProducto.Nombre;
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
            bool producto_existe = false;

            if (int.Parse(txtidproducto.Text) == 0)
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

            foreach (DataGridViewRow fila in dgvdata.Rows)
            {
                if (fila.Cells["IdProducto"].Value.ToString() == txtidproducto.Text)
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
                    preciocompra.ToString("0.00"),
                    precioventa.ToString("0.00"),
                    txtcantidad.Value.ToString(),
                    (txtcantidad.Value * preciocompra).ToString("0.00")

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
            if (Convert.ToInt32(txtidproveedor.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dgvdata.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos en la compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable detalle_compra = new DataTable();

            detalle_compra.Columns.Add("IdProducto", typeof(int));
            detalle_compra.Columns.Add("PrecioCompra", typeof(decimal));
            detalle_compra.Columns.Add("PrecioVenta", typeof(decimal));
            detalle_compra.Columns.Add("Cantidad", typeof(int));
            detalle_compra.Columns.Add("MontoTotal", typeof(decimal));

            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                detalle_compra.Rows.Add(
                    new object[] {
                       Convert.ToInt32(row.Cells["IdProducto"].Value.ToString()),
                       row.Cells["PrecioCompra"].Value.ToString(),
                       row.Cells["PrecioVenta"].Value.ToString(),
                       row.Cells["Cantidad"].Value.ToString(),
                       row.Cells["SubTotal"].Value.ToString()
                    });

            }

            

            Compra oCompra = new Compra()
            {
                oUsuario = new Usuario() { IdUsuario = _Usuario.IdUsuario },
                oProveedor = new Proveedor() { IdProveedor = Convert.ToInt32(txtidproveedor.Text) },
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

        private void txtfecha_KeyPress(object sender, KeyPressEventArgs e)
        {

        }


    }
}
