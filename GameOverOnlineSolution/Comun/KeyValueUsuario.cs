using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun
{
    /// <summary>
    /// Clase para manejar el id y el nombre completo
    /// </summary>
    public class KeyValueUsuario
    {
        #region Atributos
        ///<summary>
        ///Id del Usuario
        ///</summary>
        public int UsuarioId { get; set; }

        ///<summary>
        ///Nombre del Usuario
        ///</summary>
        public string NombreCompleto { get; set; }
        #endregion
    }
}
