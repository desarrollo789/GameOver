using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameOverOnlinePresentation.Models
{
    public class KeyValueProveedorListModel : List<KeyValueProveedorModel>
    {
        #region List
        /// <summary>
        /// Recuperacion del codigo dentro del modulo
        /// </summary>
        public static KeyValueProveedorListModel Get()
        {
            KeyValueProveedorListModel _proveedorListModel = new KeyValueProveedorListModel();
            foreach (var proveedor in ProveedorBrl.KeyValueProveedorListBrl.Get())
            {
                _proveedorListModel.Add(new KeyValueProveedorModel
                {
                    Codigo = proveedor.ProveedorId,
                    Nombre = proveedor.NombreCompletoProveedor,

                });
            }
            return _proveedorListModel;
           

    }
        #endregion
    }
}