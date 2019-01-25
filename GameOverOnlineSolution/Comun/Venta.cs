using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun
{
    class Venta
    {
        #region Atributos
        ///<summary>
        ///Id de la venta
        ///</summary>
        public int VentaId { get; set; }

        ///<summary>
        ///Id del VideoJuego
        ///</summary>
        public int VideoJuegoId { get; set; }

        ///<summary>
        ///Id del Cliente
        ///</summary>
        public int ClienteId { get; set; }

        ///<summary>
        ///Fecha de la Venta
        ///</summary>
        public DateTime Fecha { get; set; }
        #endregion
    }
}
