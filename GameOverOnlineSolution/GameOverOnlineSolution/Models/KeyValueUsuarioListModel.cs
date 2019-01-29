using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameOverOnlineSolution.Models
{
    public class KeyValueUsuarioListModel : List<KeyValueUsuarioListModel>
    {
        public static KeyValueUsuarioListModel Get()
        {
            KeyValueUsuarioListModel _pacienteListModel = new KeyValueUsuarioListModel();
            foreach (var usuario in UsuarioBrl.KeyValueUsuarioListBrl.Get())
            {
                _usuarioListModel.Add(new KeyValueUsuarioModel
                {
                    Codigo = usuario.UsuarioId,
                    Nombre = usuario.NombreCompleto,

                });
            }
            return _usuarioListModel;

        }
    }
}