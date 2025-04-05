using CapaEntidad;
using CapaNegocio;
using ClosedXML.Excel;
using Sistemas_de_ventas.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistemas_de_ventas
{
    public partial class frm_ReporteVentas : Form
    {
        public frm_ReporteVentas()
        {
            InitializeComponent();
        }

        private void frm_ReporteVentas_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                cbobusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
            }
            cbobusqueda.DisplayMember = "Texto";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 0;

            List<ReporteVenta> venta = new CN_Reportes().Venta2();
            foreach (ReporteVenta item in venta)
            {
                dgvgeneral.Rows.Add(new object[] {
                    item.NombreProducto,
                    item.Cantidad,
                    item.SubTotal
                });
            }
        }

        private void btnbuscarresultado_Click(object sender, EventArgs e)
        {
            List<ReporteVenta> lista = new List<ReporteVenta>();

            lista = new CN_Reportes().Venta(
                txtfechainicio.Value.ToString(),
                txtfechafin.Value.ToString()
                );


            dgvdata.Rows.Clear();

            foreach (ReporteVenta rc in lista)
            {
                dgvdata.Rows.Add(new object[] {
                    rc.FechaRegistro,
                    rc.NombreProducto,
                    rc.Cantidad,
                    rc.PrecioVenta,
                    rc.SubTotal
                });

            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
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

        private void exportarexcel_Click(object sender, EventArgs e)
        {
            if (dgvdata.Rows.Count < 1)
            {

                MessageBox.Show("No hay registros para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {

                DataTable dt = new DataTable();


                List<DataGridViewColumn> columnavisible = new List<DataGridViewColumn>();

                foreach (DataGridViewColumn columna in dgvdata.Columns)
                {
                    if (columna.HeaderText !="" && columna.Visible)
                    {
                        dt.Columns.Add(columna.HeaderText, typeof(string));
                        columnavisible.Add(columna);
                    }
                }

                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    if (row.Visible)
                    {
                        List<String> fila = new List<String>();
                        foreach (DataGridViewColumn col in columnavisible)
                        {
                            fila.Add(row.Cells[col.Index].Value?.ToString() ?? "");
                        }
                        dt.Rows.Add(fila.ToArray());
                    }
                }

                
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("ReporteVentas_{0}_{1}.xlsx", txtfechainicio.Value.ToString("dd/MM/yyyy"),
                                                                            txtfechafin.Value.ToString("dd/MM/yyyy"));


                savefile.Filter = "Excel Files | *.xlsx";

                if (savefile.ShowDialog() == DialogResult.OK)
                {

                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt, "Informe");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(savefile.FileName);
                        MessageBox.Show("Reporte Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch
                    {
                        MessageBox.Show("Error al generar reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }

            }
        }
    }
}
