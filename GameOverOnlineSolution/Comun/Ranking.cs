using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun
{
    /// <summary>
    /// clase que defina el ranking de un juego
    /// </summary>
    public class Ranking
    {
        /// <summary>
        /// Definicion de un ranking de juego
        /// </summary>
        public int RankingId { get; set; }
        /// <summary>
        /// Define la puntuacion obtenida el ranking
        /// </summary>
        public int Puntuacion { get; set; }

        /// <summary>
        /// Define estado de eliminado del juego
        /// </summary>
        public byte Eliminado { get; set; }

    }
}
