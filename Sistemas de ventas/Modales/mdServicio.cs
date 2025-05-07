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

namespace Sistemas_de_ventas.Modales
{
    public partial class mdServicio : Form
    {
        public Servicio _Servicio = new Servicio();
        public mdServicio()
        {
            InitializeComponent();
        }

        private void mdServicio_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {

                if (columna.Visible == true)
                {
                    cbobusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbobusqueda.DisplayMember = "Texto";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 0;

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
        public Servicio ServicioSelecionado { get; set; }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            if (iRow >= 0)
            {
                ServicioSelecionado = new Servicio()
                {
                    IdServicio = Convert.ToInt32(dgvdata.Rows[iRow].Cells["Id"].Value),
                    Descripcion = dgvdata.Rows[iRow].Cells["Descripcion"].Value.ToString(),
                    Cantidad = Convert.ToInt32(dgvdata.Rows[iRow].Cells["Cantidad"].Value),
                    Precio = Convert.ToDecimal(dgvdata.Rows[iRow].Cells["Precio"].Value)
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
    
}
