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
    public partial class HorarioEdicion : DevExpress.XtraEditors.XtraForm
    {
        public HorarioEdicion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Horario horario = new Horario();
            horario.Show();
            this.Dispose();

        }
    }
}