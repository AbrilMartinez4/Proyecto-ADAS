using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Data.Evento;
using Proyecto.Data.Evento.EventoTableAdapters;
using System.Data.SqlClient;

namespace Proyecto.BL
{
    public class EventoBL
    {
        EventoTableAdapter TA = new EventoTableAdapter();

        #region inserciones
        public void Insertar(Guid EventoID, String Descripcion, string Hora, string Fecha, Guid UsuarioID, Guid TipoEvento, Guid LugarID)
        {
            TA.Insert(EventoID,Descripcion,Hora,Fecha,UsuarioID,TipoEvento, LugarID);

        }
        #endregion

        #region Actualizaciones
        public void Actualizar(Evento.EventoDataTable dtb)
        {

            TA.Update(dtb);

        }

        public void Actualizar(Guid EventoID, String Descripcion, string Hora, string Fecha, Guid UsuarioID, Guid TipoEvento, Guid LugarID)
        {
            TA.Actualizar(Descripcion,Hora, Fecha, UsuarioID, TipoEvento, LugarID, EventoID);
        }
        #endregion

        #region Selecciones
        public Evento.EventoDataTable Seleccionar()
        {
            Evento.EventoDataTable tabla = new Evento.EventoDataTable();
            TA.Fill(tabla);

            return tabla;
        }
        public Evento.EventoDataTable Seleccionar(Guid EventoID)
        {
            Evento.EventoDataTable tabla = new Evento.EventoDataTable();
            tabla = TA.GetDataByEventoID(EventoID);

            return tabla;
        }

        //public Evento.tbEventoDepartamentoVWDataTable SeleccionarEventoDepartamentoVW()
        //{
        //    tbEventoDepartamentoVWTableAdapter TAEvento = new tbEventoDepartamentoVWTableAdapter();
        //    Evento.tbEventoDepartamentoVWDataTable tabla = TAEvento.GetData();

        //    return tabla;
        //}
        #endregion

        #region Eliminaciones
        public void Eliminar(Guid EventoID)
        {

            TA.Eliminar(EventoID);
        }
        #endregion
    }
}
