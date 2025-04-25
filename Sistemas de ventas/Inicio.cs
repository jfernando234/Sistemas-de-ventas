using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;

using CapaEntidad;
using FontAwesome.Sharp;
using Sistemas_de_ventas.Modales;

namespace Sistemas_de_ventas
{
    public partial class Inicio : Form
    {
        private static Usuario usuarioactual;
        private static IconMenuItem MenuActivo = null;

        private static Form FormularioActivo = null;


        public Inicio(Usuario objusuario = null)
        {
            if (objusuario == null) 
            {
                usuarioactual = new Usuario() { NombreCompleto = "PREDETERMINANDO", IdUsuario = 1 }; 
            }else
                usuarioactual = objusuario;


            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            List<Permiso> ListaPermisos = new CN_Permiso().Listar(usuarioactual.IdUsuario);
            
            foreach (IconMenuItem iconmenu in menu.Items)
            {
                bool encontrado = ListaPermisos.Any(m => m.NombreMenu  == iconmenu.Name);
                if(encontrado == false)
                {
                    iconmenu.Visible = false;
                }

            }
            lbusuario.Text = usuarioactual.NombreCompleto;
        }

        private void Abrir_From(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            MenuActivo = menu;
            
            if (FormularioActivo!= null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.SteelBlue;

            contenedor.Controls.Add(formulario);
            formulario.Show();

        }

        private void menuusuario_Click(object sender, EventArgs e)
        {
            Abrir_From((IconMenuItem)sender, new FRM_Usuarios());
        }

        private void submenucategoria_Click(object sender, EventArgs e)
        {
            Abrir_From(menumantenedor, new frm_Categoria());
        }

        private void submenuproducto_Click(object sender, EventArgs e)
        {
            Abrir_From(menumantenedor, new frm_Producto());
        }

        private void submenuregistrarventa_Click(object sender, EventArgs e)
        {
            Abrir_From(menuventas, new frm_Ventas());
        }

        private void submenuverdetalleventa_Click(object sender, EventArgs e)
        {
            Abrir_From(menuventas, new frm_DetalleVenta());
        }

        private void submenuregistrarcompra_Click(object sender, EventArgs e)
        {
            Abrir_From(menucompras, new frm_Compras(usuarioactual));

        }

        private void submenuverdetallecompra_Click(object sender, EventArgs e)
        {
            Abrir_From(menucompras, new frm_DetalleCompra());
        }

        private void menuclientes_Click(object sender, EventArgs e)
        {
            Abrir_From((IconMenuItem)sender, new frm_Clientes());
        }

        private void menuproveedor_Click(object sender, EventArgs e)
        {
            Abrir_From((IconMenuItem)sender, new frm_Proveedores());
        }
       

        private void submenunegocio_Click(object sender, EventArgs e)
        {
             Abrir_From(menuventas, new frm_Negocio());
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir_From(menuventas, new frm_Servicios());
        }

        private void verDetalleServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir_From(menuventas, new frm_DetalleServicio());
        }

        private void reporteComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir_From(menureportes, new frm_ReporteCompras());
        }

        private void reporteVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir_From(menureportes, new frm_ReporteVentas());
        }

        private void reporteServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir_From(menureportes, new frm_ReporteServicios());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir_From(menucotizacion, new frm_Cotizacion());
        }

        private void serviciosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Abrir_From(menucotizacion, new frm_serCotizacion());
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir_From(menucotizacion, new frm_DetalleCotizacion());
        }

        private void serviciosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Abrir_From(menucotizacion, new frm_DetalleSerCotizacion());
        }

        private void balanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir_From(menucotizacion, new frm_balance());
        }

        private void menumantenedor_Click(object sender, EventArgs e)
        {

        }

        
    }
}
