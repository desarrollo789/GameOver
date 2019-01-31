using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameOverOnlinePresentation.Models
{
    public class KeyValueSexoListModel : List<KeyValueSexoModel>
    {
        #region List
        /// <summary>
        /// Recuperacion del codigo dentro del modulo
        /// </summary>
        public static KeyValueSexoListModel Get()
        {
            KeyValueSexoListModel _sexoListModel = new KeyValueSexoListModel();
            foreach (var sexo in SexoBrl.KeyValueSexoListBrl.Get())
            {
                _sexoListModel.Add(new KeyValueSexorModel
                {
                    Codigo = sexo.SexoId,
                    Nombre = sexo.NombreCompletoSexo,

                });
            }
            return _sexoListModel;


        }
        #endregion
    }
}