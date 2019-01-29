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
        
        public Ranking RankingId { get; set; }

        ///<summary>
        ///Categoria del Videojuego
        ///</summary>
        
        public Categoria CategoriaId { get; set; }

        ///<summary>
        ///Comentario del Videojuego
        ///</summary>
        
        public Comentario ComentarioId { get; set; }

        ///<summary>
        ///Proveedor del VideoJuego
        ///</summary>
        
        public Proveedor ProveedorId { get; set; }
        
        #endregion


    }
}
