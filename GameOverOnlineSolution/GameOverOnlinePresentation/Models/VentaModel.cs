using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GameOverOnlinePresentation.Models
{
    public class VentaModel
    {
        #region Propiedades
        /// <summary>
        /// Recuperacion del codigo dentro del modulo
        /// </summary>
        [Display(Name = "SaleId")]
        public int VentaId
        {
            get;
            set;
        }
        [Display(Name = "VideoGameId")]
        public int VideoJuegoId
        {
            get;
            set;
        }

        [Display(Name = "ClientId")]
        public int ClienteId
        {
            get;
            set;
        }
        [Display(Name = "Date", ResourceType = typeof(Resource.Resource))]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Fecha
        {
            get;
            set;
        }
        #endregion
    }
}