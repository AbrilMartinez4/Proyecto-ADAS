using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Proyecto.BL;
using Proyecto.Data.Usuario;
using Proyecto_ADAS;

namespace Proyecto_ADAS
{
    public partial class Inicio : DevExpress.XtraEditors.XtraForm
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            string NombreUsuario = txtUsuario.Text;
            string Contraseña = txtContraseña.Text;
            if (NombreUsuario != "")
            {
                if (Contraseña != "")
                {
                    UsuarioBL obj = new UsuarioBL();
                    DSUsuario.UsuarioDataTable dst = obj.VerificarUsuario(NombreUsuario, Contraseña);
                    if (dst.Count > 0)
                    {
                        MenuS menu = new MenuS();
                        menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario y/o contraseña inválida","Error");
                        txtUsuario.Focus();
                    }
                     
                }
                else
                {
                    MessageBox.Show("Capturar la contraseña");
                    txtContraseña.Focus();
                }
            }
            else
            {
                MessageBox.Show("Capturar el nombre de usuario");
                txtUsuario.Focus();
            }

            
        }
    }
}
