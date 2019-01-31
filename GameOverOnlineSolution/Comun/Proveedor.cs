using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun
{
    public class Proveedor
    {
        #region atributos
        /// <summary>
        /// Id del Proveedor
        /// </summary>
        public int ProveedorId { get; set; }

        /// <summary> 
        /// Correo Electronico del Proveedor
        /// </summary>
        public string CorreoElectronico { get; set; }

        /// <summary>
        /// Nombre del Proveedor
        /// </summary>
        public string NombreProveedor { get; set; }


        /// <summary>
        /// Apellido del Proveedor
        /// </summary>

        public string ApellidoProveedor { get; set; }

        ///<summary>
        /// Eliminado Logico del Proveedor
        ///</summary>
        public byte Eliminado { get; set; }
        #endregion
    }
}
