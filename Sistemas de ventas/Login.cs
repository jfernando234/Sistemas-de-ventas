using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Windows.Forms.Design;
using CapaNegocio;
using CapaEntidad;

namespace Sistemas_de_ventas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntingresar_Click(object sender, EventArgs e)
        {         
            Usuario ousuario = new CN_Usuario().Listar().Where(u => u.Documento == txtdocumento.Text && u.Clave == txtcontraseña.Text).FirstOrDefault();
            if (ousuario != null)
            {
                if (!ousuario.Estado) 
                {
                    MessageBox.Show("El usuario está deshabilitado. Contacte al administrador.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return; 
                }
 
                Inicio from = new Inicio(ousuario);
                

                from.Show();
                this.Hide();
                from.FormClosing += frm_closing;
            }
            else
            {
                MessageBox.Show(" Contraseña Incorrecta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtdocumento.Text = "";
            txtcontraseña.Text = "";
            this.Show();
        }
    }
}
