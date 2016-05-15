using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Usuario;
using Data.Usuario.DSUsuarioTableAdapters;

namespace BL
{
    class UsuarioBL
    {
        UsuarioTableAdapter TA = new UsuarioTableAdapter();

        #region inserciones
        public void Insertar(Guid UsuarioID, String Nombre, String Contraseña)
        {
            TA.Insert(UsuarioID, Nombre, Contraseña);

        }
        #endregion

        #region Actualizaciones
        public void Actualizar(DSUsuario.UsuarioDataTable dtb)
        {

            TA.Update(dtb);

        }

        public void Actualizar(Guid UsuarioID, String Nombre, String Contraseña)
        {
            TA.Actualizar(Nombre, Contraseña, UsuarioID);
        }
        #endregion

        #region Selecciones
        public DSUsuario.UsuarioDataTable Seleccionar()
        {
            DSUsuario.UsuarioDataTable tabla = new DSUsuario.UsuarioDataTable();
            TA.Fill(tabla);

            return tabla;
        }
        public DSUsuario.UsuarioDataTable Seleccionar(String Nombre)
        {
            DSUsuario.UsuarioDataTable tabla = new DSUsuario.UsuarioDataTable();
            tabla = TA.GetDataByNombre(Nombre);

            return tabla;
        }

        //public Usuario.tbUsuarioUsuarioVWDataTable SeleccionarUsuarioUsuarioVW()
        //{
        //    tbUsuarioUsuarioVWTableAdapter TAUsuario = new tbUsuarioUsuarioVWTableAdapter();
        //    Usuario.tbUsuarioUsuarioVWDataTable tabla = TAUsuario.GetData();

        //    return tabla;
        //}
        #endregion

        #region Eliminaciones
        public void Eliminar(Guid UsuarioID)
        {

            TA.Eliminar(UsuarioID);
        }
        #endregion
    }
}
