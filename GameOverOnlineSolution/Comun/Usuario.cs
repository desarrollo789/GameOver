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
        public int UsuarioId { get; set; }

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
        public bool Username { get; set; } 


        ///<summary>
        /// Rol de Administrador
        ///</summary>
        public bool Administrador { get; set; }

        ///<summary>
        /// Sexo del Usuario
        ///</summary>
        public bool Eliminado { get; set; }

        /// <summary>
        /// Sexo del paciente
        /// </summary>
        public Sexo Sexo { get; set; }


        /////<summary>
        /////Ranking del Usuario
        /////</summary>
        
        //public Ranking Ranking { get; set; }

        ///<summary>
        ///Fecha de registro
        ///</summary>
        public DateTime Fechaderegistro { get; set; }


        /// <summary>
        /// Recupera la informacion del password mediante in ID del mismo
        /// </summary>

        #endregion
    }
}
