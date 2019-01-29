using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun
{
    public class VideoJuego
    {
        #region Atributos
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
        
        public string Portada { get; set; }

        /// <summary>
        /// define la portada del juego
        /// </summary>

        public string Trailer { get; set; }
        /// <summary>
        /// define la trailer del juego
        /// </summary>
        
        public bool Eliminado { get; set; }

        /// <summary>
        /// Fecha lanzamiento de juego
        /// </summary>

        public DateTime Fecha { get; set; }

        /// <summary>
        /// Rankin del Juego
        /// </summary>
        
        public Ranking Rankin { get; set; }

        ///<summary>
        ///Categoria del Videojuego
        ///</summary>
        
        public Categoria Categoria { get; set; }

        ///<summary>
        ///Comentario del Videojuego
        ///</summary>
        
        public Comentario Comentario { get; set; }

        ///<summary>
        ///Fecha de lazamiento
        ///</summary>
        
        #endregion


    }
}
