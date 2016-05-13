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
    public partial class Horario : DevExpress.XtraEditors.XtraForm
    {
        public Horario()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MenuS menu = new MenuS();
            menu.Show();
            this.Dispose();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HorarioEdicion horarioedicion = new HorarioEdicion();
            horarioedicion.Show();
            this.Dispose();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HorarioEdicion horarioedicion = new HorarioEdicion();
            horarioedicion.Show();
            this.Dispose();
        }
    }
}