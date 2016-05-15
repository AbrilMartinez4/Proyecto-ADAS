using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Evento.TipoEventoTableAdapters;
using Data.Evento;

namespace BL
{
    class TipoEventoBL
    {
        TipoEventoTableAdapter TA = new TipoEventoTableAdapter();

        #region inserciones
        public void Insertar(Guid TipoEventoID, String Descripcion)
        {
            TA.Insert(TipoEventoID, Descripcion);

        }
        #endregion

        #region Actualizaciones
        public void Actualizar(TipoEvento.TipoEventoDataTable dtb)
        {

            TA.Update(dtb);

        }

        public void Actualizar(Guid TipoEventoID, String Descripcion)
        {
            TA.Actualizar(Descripcion, TipoEventoID);
        }
        #endregion

        #region Selecciones
        public TipoEvento.TipoEventoDataTable Seleccionar()
        {
            TipoEvento.TipoEventoDataTable tabla = new TipoEvento.TipoEventoDataTable();
            TA.Fill(tabla);

            return tabla;
        }
        //public DSTipoEvento.TipoEventoDataTable Seleccionar(Guid TipoEventoID)
        //{
        //    DSTipoEvento.TipoEventoDataTable tabla = new DSTipoEvento.TipoEventoDataTable();
        //    tabla = TA.GetDataByTipoEventoID(TipoEventoID);

        //    return tabla;
        //}

        //public TipoEvento.tbTipoEventoTipoEventoVWDataTable SeleccionarTipoEventoTipoEventoVW()
        //{
        //    tbTipoEventoTipoEventoVWTableAdapter TATipoEvento = new tbTipoEventoTipoEventoVWTableAdapter();
        //    TipoEvento.tbTipoEventoTipoEventoVWDataTable tabla = TATipoEvento.GetData();

        //    return tabla;
        //}
        #endregion

        #region Eliminaciones
        public void Eliminar(Guid TipoEventoID)
        {

            TA.Eliminar(TipoEventoID);
        }
        #endregion
    }
}
