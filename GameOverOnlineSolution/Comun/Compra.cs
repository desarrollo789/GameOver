using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun
{
    class Compra
    {
        #region Atributos
        ///<summary>
        ///Id de la Compra
        ///</summary>
        public int CompraId { get; set; }

        ///<summary>
        ///Id del Usuario
        ///</summary>
        public int ClienteId { get; set; }

        ///<summary>
        ///Id del Proveedor
        ///</summary>
        public int ProveedorId { get; set; }
        #endregion
    }
}
