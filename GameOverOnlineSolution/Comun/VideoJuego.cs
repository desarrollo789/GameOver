using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun
{
    class VideoJuego
    {
        #region
        /// <summary>
        /// Identificador del videojuego
        /// </summary>
        public int VideoJuegoId { get; set; }
        /// <summary>
        /// Nombre del videojuego
        /// </summary>
        public string Nombre { get; set; }
      

        /// <summary>
        /// define el precio de un video juego
        /// </summary>
        public float Precio { get; set; }


        /// <summary>
        /// define la portada del juego
        /// </summary>
        
        public string Protada { get; set; }

        /// <summary>
        /// define la portada del juego
        /// </summary>

        public string Trailer { get; set; }
        /// <summary>
        /// define la trailer del juego
        /// </summary>
        
        public bool Eliminado { get; set; }
        #endregion


    }
}
