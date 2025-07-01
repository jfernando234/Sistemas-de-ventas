using CapaEntidad;
using CapaNegocio;
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
    public partial class frm_Servicio : Form
    {
        public frm_Servicio()
        {
            InitializeComponent();
        }

        private void frm_Servicio_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {

                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {
                    cbobusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbobusqueda.DisplayMember = "Texto";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 0;
            //MOSTRAR TODOS LOS USUARIOS
            List<Servicio> lista = new CN_Servicio().Listar();

            foreach (Servicio item in lista)
            {
                dgvdata.Rows.Add(new object[] {
                    "",
                    item.IdServicio,
                    item.Codigo,
                    item.Descripcion,
                    item.Cantidad,
                    item.Precio,

                });
            }
        }

      
        public void Limpiar()
        {
            txtprecio.Text = "";
            txtcodigo.Text = "";
            txtdescripcion.Text = "";
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            // Si la validación falla, no continuar
            if (!validarDatos())
            {
                return;
            }
            string mensaje = string.Empty;

            Servicio obj = new Servicio()
            {
                IdServicio = Convert.ToInt32(txtid.Text),
                Codigo = txtcodigo.Text,
                Descripcion = txtdescripcion.Text,
                Cantidad = 1,
                Precio = Convert.ToDecimal(txtprecio.Text)
                
            };

            if (obj.IdServicio == 0)
            {
                int idgenerado = new CN_Servicio().Registrar(obj, out mensaje);

                if (idgenerado != 0)
                {

                    dgvdata.Rows.Add(new object[] {
                        "",
                       idgenerado,
                       txtcodigo.Text,
                       txtdescripcion.Text,
                       1,
                       txtprecio.Text,
                    });

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }


            }
            else
            {
                bool resultado = new CN_Servicio().Editar(obj, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["IdServicio"].Value = txtid.Text;
                    row.Cells["Codigo"].Value = txtcodigo.Text;
                    row.Cells["Descripcion"].Value = txtdescripcion.Text;
                    row.Cells["Cantidad"].Value = 1;
                    row.Cells["Precio"].Value = txtprecio.Text;
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
        }
        private bool validarDatos()
        {
            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(txtcodigo.Text) ||
                string.IsNullOrWhiteSpace(txtdescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtprecio.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos: Código, Descripción y Precio.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar que el precio sea un número válido
            decimal precio;
            if (!decimal.TryParse(txtprecio.Text, out precio))
            {
                MessageBox.Show("Ingrese un precio válido.", "Precio inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void bntlimpiarr_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el producto", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string mensaje = string.Empty;
                    Servicio obj = new Servicio()
                    {
                        IdServicio = Convert.ToInt32(txtid.Text)
                    };

                    bool respuesta = new CN_Servicio().Eliminar(obj, out mensaje);

                    if (respuesta)
                    {
                        dgvdata.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {

                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtindice.Text = indice.ToString();
                    txtid.Text = dgvdata.Rows[indice].Cells["IdServicio"].Value.ToString();
                    txtcodigo.Text = dgvdata.Rows[indice].Cells["Codigo"].Value.ToString();
                    txtdescripcion.Text = dgvdata.Rows[indice].Cells["Descripcion"].Value.ToString();
                    txtprecio.Text = dgvdata.Rows[indice].Cells["Precio"].Value.ToString();
                }
            }
        }

        private void bntbuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbobusqueda.SelectedItem).Valor.ToString();

            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                {

                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void bntlimpiar_Click(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
