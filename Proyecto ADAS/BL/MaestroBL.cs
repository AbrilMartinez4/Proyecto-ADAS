using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Maestro;
using Data.Maestro.MaestroTableAdapters;

namespace BL
{
    class MaestroBL
    {
        MaestroTableAdapter TA = new MaestroTableAdapter();

        #region inserciones
        public void Insertar(String Matricula, String Nombre, String ApPaterno, String ApMaterno, Int32 DepartamentoID)
        {
            TA.Insert(Matricula, Nombre, ApPaterno, ApMaterno,DepartamentoID);

        }
        #endregion

        #region Actualizaciones
        public void Actualizar(Maestro.MaestroDataTable dtb)
        {

            TA.Update(dtb);

        }

        public void Actualizar(String Matricula, String Nombre, String ApPaterno, String ApMaterno, Int32 DepartamentoID)
        {
            TA.Actualizar(Nombre, ApPaterno, ApMaterno, DepartamentoID, Matricula);

        }
        #endregion

        #region Selecciones
        public Maestro.MaestroDataTable Seleccionar()
        {
            Maestro.MaestroDataTable tabla = new Maestro.MaestroDataTable();
            TA.Fill(tabla);

            return tabla;
        }
        public Maestro.MaestroDataTable Seleccionar(string Matricula)
        {
            Maestro.MaestroDataTable tabla = new Maestro.MaestroDataTable();
            tabla = TA.GetDataByMatricula(Matricula);

            return tabla;
        }

        //public Maestro.tbMaestroDepartamentoVWDataTable SeleccionarMaestroDepartamentoVW()
        //{
        //    tbMaestroDepartamentoVWTableAdapter TAMaestro = new tbMaestroDepartamentoVWTableAdapter();
        //    Maestro.tbMaestroDepartamentoVWDataTable tabla = TAMaestro.GetData();

        //    return tabla;
        //}
        #endregion

        #region Eliminaciones
        public void Eliminar(string Matricula)
        {

            TA.Eliminar(Matricula);
        }
        #endregion
    }
}
