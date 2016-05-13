using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Proyecto_ADAS
{
    public partial class MaestroEdicion : DevExpress.XtraEditors.XtraForm
    {
        public MaestroEdicion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Maestros maestros = new Maestros();
            maestros.Show();
            this.Dispose();
        }
    }
}