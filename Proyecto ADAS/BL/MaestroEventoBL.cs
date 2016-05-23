using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Data.MaestroEvento;
using Proyecto.Data.MaestroEvento.DSMaestroEventoTableAdapters;
using Proyecto.Data.MaestroEvento.MaestroEventoVWTableAdapters;

namespace Proyecto.BL
{
    public class MaestroEventoBL
    {
        MaestroEventoTableAdapter TA = new MaestroEventoTableAdapter();

        #region inserciones
        public void Insertar(String Matricula, Guid EventoID)
        {
            TA.Insert(Matricula, EventoID);

        }
        #endregion

        #region Actualizaciones
        public void Actualizar(DSMaestroEvento.MaestroEventoDataTable dtb)
        {

            TA.Update(dtb);

        }

        public void Actualizar(String NewMatricula, Guid NewEventoID, String OldMatricula, Guid OldEventoID)
        {
            TA.Actualizar(NewMatricula, NewEventoID, OldMatricula, OldEventoID);
        }
        #endregion

        #region Selecciones
        public DSMaestroEvento.MaestroEventoDataTable Seleccionar()
        {
            DSMaestroEvento.MaestroEventoDataTable tabla = new DSMaestroEvento.MaestroEventoDataTable();
            TA.Fill(tabla);

            return tabla;
        }
        public MaestroEventoVW.MaestroEventoVWDataTable SeleccionarPorMatricula(String Matricula)
        {
            MaestroEventoVWTableAdapter TAVW = new MaestroEventoVWTableAdapter();
            MaestroEventoVW.MaestroEventoVWDataTable tabla = new MaestroEventoVW.MaestroEventoVWDataTable();
            tabla = TAVW.GetDataByMatricula(Matricula);

            return tabla;
        }
        public MaestroEventoVW.MaestroEventoVWDataTable SeleccionarPorEvento(Guid EventoID)
        {
            MaestroEventoVWTableAdapter TAVW = new MaestroEventoVWTableAdapter();
            MaestroEventoVW.MaestroEventoVWDataTable tabla = new MaestroEventoVW.MaestroEventoVWDataTable();
            tabla = TAVW.GetDataByEventoID(EventoID);

            return tabla;
        }
        #endregion

        #region Eliminaciones
        public void Eliminar(String Matricula,Guid EventoID)
        {

            TA.Eliminar(Matricula,EventoID);
        }
        #endregion
    }
}
