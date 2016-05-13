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
    public partial class EventoEdicion : DevExpress.XtraEditors.XtraForm
    {
        public EventoEdicion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Evento evento = new Evento();
            evento.Show();
            this.Dispose();
        }
    }
}