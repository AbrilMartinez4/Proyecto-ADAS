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
    public partial class MenuS : DevExpress.XtraEditors.XtraForm
    {
        public MenuS()
        {
            InitializeComponent();
        }

        private void btnMaestros_Click(object sender, EventArgs e)
        {
            Maestros maestros = new Maestros();
            maestros.Show();
            this.Dispose();
        }

        private void btnHorarios_Click(object sender, EventArgs e)
        {
            Horario horario = new Horario();
            horario.Show();
            this.Dispose();
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            Evento evento = new Evento();
            evento.Show();
            this.Dispose();
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            Calendario calendario = new Calendario();
            calendario.Show();
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Dispose();
        }

    }
}