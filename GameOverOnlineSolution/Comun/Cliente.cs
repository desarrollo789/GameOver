using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun
{
    class Cliente
    {
        #region atributos
        /// <summary>
        /// Nombre del paciente
        /// </summary>
        public int ClienteId { get; set; }

        /// <summary>
        /// Nombre del paciente
        /// </summary>
        public string Nombre { get; set; }

        /// <sumary>
        /// Apellido del cliente
        /// </sumary>
        public string Apellido { get; set; }
        /// <summary>
        /// Sexo del paciente
        /// </summary>
        
        /// <summary>
        /// Correo electronico del cliente
        /// </summary>
        public string CorreoElectronico { get; set; }

        /// <summary>
        /// Recupera la informacion del password mediante in ID del mismo
        /// </summary>
        /// 
        #endregion
    }
}
