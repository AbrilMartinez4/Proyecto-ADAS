using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Data.Maestro;
using Proyecto.Data.Maestro.DSDepartamentoTableAdapters;
namespace Proyecto.BL
{
    public class DepartamentoBL
    {
        DepartamentoTableAdapter TA = new DepartamentoTableAdapter();

        #region inserciones
        public void Insertar(Int32 DepartamentoID, String Descripcion)
        {
            TA.Insert(DepartamentoID, Descripcion);

        }
        #endregion
       
        #region Actualizaciones
        public void Actualizar(DSDepartamento.DepartamentoDataTable dtb)
        {

            TA.Update(dtb);

        }

        public void Actualizar(Int32 DepartamentoID, String Descripcion)
        {
            TA.Actualizar(Descripcion, DepartamentoID);
        }
        #endregion

        #region Selecciones
        public DSDepartamento.DepartamentoDataTable Seleccionar()
        {
            DSDepartamento.DepartamentoDataTable tabla = new DSDepartamento.DepartamentoDataTable();
            TA.Fill(tabla);

            return tabla;
        }
        //public DSDepartamento.DepartamentoDataTable Seleccionar(Guid DepartamentoID)
        //{
        //    DSDepartamento.DepartamentoDataTable tabla = new DSDepartamento.DepartamentoDataTable();
        //    tabla = TA.GetDataByDepartamentoID(DepartamentoID);

        //    return tabla;
        //}

        //public Departamento.tbDepartamentoDepartamentoVWDataTable SeleccionarDepartamentoDepartamentoVW()
        //{
        //    tbDepartamentoDepartamentoVWTableAdapter TADepartamento = new tbDepartamentoDepartamentoVWTableAdapter();
        //    Departamento.tbDepartamentoDepartamentoVWDataTable tabla = TADepartamento.GetData();

        //    return tabla;
        //}
        #endregion

        #region Eliminaciones
        public void Eliminar(Int32 DepartamentoID)
        {

            TA.Eliminar(DepartamentoID);
            
        }
        #endregion
    }
}
