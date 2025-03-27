using CapaEntidad;
using CapaNegocio;
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
    public partial class frm_balance : Form
    {
        public frm_balance()
        {
            InitializeComponent();
        }

        private void frm_balance_Load(object sender, EventArgs e)
        {
            List<ReporteVenta> total = new CN_Reportes().Balance();
            foreach (ReporteVenta item in total) 
            { 
                dgvdata.Rows.Add(new object[]
                {
                    item.NombreProducto,
                    item.Cantidad,
                    item.CantidadVe,
                    item.Balance,
                    item.CostoT,
                    item.SubTotal,
                    item.GananciaT
                });

            }
        }
    }
}
