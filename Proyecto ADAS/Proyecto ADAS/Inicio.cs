using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            MenuS menu = new MenuS();
            menu.Show();
            this.Hide(); 
        }
    }
}
