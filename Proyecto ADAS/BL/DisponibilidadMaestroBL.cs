using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Maestro.DSDisponibilidadMaestroTableAdapters;
using Data.Maestro;

namespace BL
{
    public class DisponibilidadMaestroBL
    {
        DisponibilidadMaestroTableAdapter TA = new DisponibilidadMaestroTableAdapter();

        #region inserciones
        public void Insertar(Guid DisponibilidadMaestroID, String Matricula, string Hora, string Fecha)
        {
            TA.Insert(DisponibilidadMaestroID, Matricula, Hora, Fecha);

        }
        #endregion

        #region Actualizaciones
        public void Actualizar(DSDisponibilidadMaestro dtb)
        {

            TA.Update(dtb);

        }

        public void Actualizar(Guid DisponibilidadMaestroID, String Matricula, string Hora, string Fecha)
        {
            TA.Actualizar(Matricula, Hora, Fecha, DisponibilidadMaestroID);
        }
        #endregion

        #region Selecciones
        public DSDisponibilidadMaestro.DisponibilidadMaestroDataTable Seleccionar()
        {
            DSDisponibilidadMaestro.DisponibilidadMaestroDataTable tabla = new DSDisponibilidadMaestro.DisponibilidadMaestroDataTable();
            TA.Fill(tabla);

            return tabla;
        }
        public DSDisponibilidadMaestro.DisponibilidadMaestroDataTable Seleccionar(String Matricula)
        {
            DSDisponibilidadMaestro.DisponibilidadMaestroDataTable tabla = new DSDisponibilidadMaestro.DisponibilidadMaestroDataTable();
            tabla = TA.GetDataByMatricula(Matricula);
            return tabla;
        }

        //public DisponibilidadMaestro.tbDisponibilidadMaestroDepartamentoVWDataTable SeleccionarDisponibilidadMaestroDepartamentoVW()
        //{
        //    tbDisponibilidadMaestroDepartamentoVWTableAdapter TADisponibilidadMaestro = new tbDisponibilidadMaestroDepartamentoVWTableAdapter();
        //    DisponibilidadMaestro.tbDisponibilidadMaestroDepartamentoVWDataTable tabla = TADisponibilidadMaestro.GetData();

        //    return tabla;
        //}
        #endregion

        #region Eliminaciones
        public void Eliminar(Guid DisponibilidadMaestroID)
        {

            TA.Eliminar(DisponibilidadMaestroID);
        }
        #endregion
    }
}
