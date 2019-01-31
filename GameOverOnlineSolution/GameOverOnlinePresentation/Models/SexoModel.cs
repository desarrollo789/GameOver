using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GameOverOnlinePresentation.Models
{
    public class SexoModel
    {
        #region Propiedades
        /// <summary>
        /// Recuperacion del codigo dentro del modulo
        /// </summary>
        public byte SexoId
        {
            get;
            set;
        }

        public string Nombre
        {
            get;
            set;
        }
        #endregion
    }
}