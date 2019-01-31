using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameOverOnlinePresentation.Models
{
    public class KeyValueUsuarioListModel : List<KeyValueUsuarioModel>
    {
        #region List
        ///<summary>
        ///Codigo
        ///</summary>
        public static KeyValueUsuarioListModel Get()
        {
            KeyValueUsuarioListModel _usuarioListModel = new KeyValueUsuarioListModel();
            foreach (var usuario in ClienteBrl.KeyValueUsuarioListBrl.Get())
            {
                _usuarioListModel.Add(new KeyValueUsuarioModel
                {
                    Codigo = usuario.UsuarioId,
                    Nombre = usuario.NombreCompleto,

                });
            }
            return _usuarioListModel;

        }
        #endregion
    }
}