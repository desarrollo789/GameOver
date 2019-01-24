using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun
{
    class VideoJuego
    {
        #region atributos
        /// <summary>
        /// Id del Videojuego
        /// </summary>
        public int VideoJuegoId { get; set; }

        /// <summary>
        /// Titulo del Videojuego
        /// </summary>
        public string VideoJuegoNombre { get; set; }

        /// <summary>
        /// Precio del Videojuego
        /// </summary>
        public float Precio { get; set; }


        /// <summary>
        /// Portada del Videojuego
        /// </summary>
        
        public string Portada { get; set; }


        /// <summary>
        /// Trailer del Videojuego
        /// </summary>
        public string Trailer { get; set; }

        ///<summary>
        ///Detalles Tecnicos del Vieojuego
        ///</summary>
        public string DetalleTecnico { get; set; }

        #endregion
    }
}
