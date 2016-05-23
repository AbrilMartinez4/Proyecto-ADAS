using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Data.Evento;
using Proyecto.Data.Evento.LugarTableAdapters;

namespace Proyecto.BL
{
    public class LugarBL
    {
        LugarTableAdapter TA = new LugarTableAdapter();

        #region inserciones
        public void Insertar(Guid LugarID, String Descripcion)
        {
            TA.Insert(LugarID, Descripcion);

        }
        #endregion

        #region Actualizaciones
        public void Actualizar(Lugar.LugarDataTable dtb)
        {

            TA.Update(dtb);

        }

        public void Actualizar(Guid LugarID, String Descripcion)
        {
            TA.Actualizar(Descripcion, LugarID);
        }
        #endregion

        #region Selecciones
        public Lugar.LugarDataTable Seleccionar()
        {
            Lugar.LugarDataTable tabla = new Lugar.LugarDataTable();
            TA.Fill(tabla);

            return tabla;
        }
        //public DSLugar.LugarDataTable Seleccionar(Guid LugarID)
        //{
        //    DSLugar.LugarDataTable tabla = new DSLugar.LugarDataTable();
        //    tabla = TA.GetDataByLugarID(LugarID);

        //    return tabla;
        //}

        //public Lugar.tbLugarLugarVWDataTable SeleccionarLugarLugarVW()
        //{
        //    tbLugarLugarVWTableAdapter TALugar = new tbLugarLugarVWTableAdapter();
        //    Lugar.tbLugarLugarVWDataTable tabla = TALugar.GetData();

        //    return tabla;
        //}
        #endregion

        #region Eliminaciones
        public void Eliminar(Guid LugarID)
        {

            TA.Eliminar(LugarID);
        }
        #endregion
    }
}
