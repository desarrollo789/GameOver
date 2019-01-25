using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun
{
    public class Usuario
    {
        #region atributos
        /// <summary>
        /// Id del Usuario
        /// </summary>
        public int ClienteId { get; set; }

        /// <summary>
        /// Nombre del Usuario
        /// </summary>
        public string Nombre { get; set; }

        /// <sumary>
        /// Apellido del Usuario
        /// </sumary>
        public string Apellido { get; set; }

        /// <summary>
        /// Correo electronico del cliente
        /// </summary>
        public string CorreoElectronico { get; set; }


        /// <summary>
        /// Fecha de Nacimiento del Usuario
        /// </summary>
        public DateTime FechaNacimiento { get; set; }

        ///<summary>
        /// Nombre de Usuario(username)
        ///</summary>
        public string Username { get; set; } 


        ///<summary>
        /// Rol de Administrador
        ///</summary>
        public bool Admin { get; set; }
        
        /// <summary>
        /// Recupera la informacion del password mediante in ID del mismo
        /// </summary>
        

        #endregion
    }
}
