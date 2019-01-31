using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GameOverOnlinePresentation.Models
{
    public class VentaDetalleModel
    {
        #region Propiedades
        /// <summary>
        /// Recuperacion del codigo dentro del modulo
        /// </summary>
        [Required(ErrorMessageResourceName = "FieldRequired", ErrorMessageResourceType = typeof(Resource.Resource))]
        [Display(Name = "SellDetailId")]
        [StringLength(50, ErrorMessageResourceName = "SellDetailIdMessageError", MinimumLength = 3, ErrorMessageResourceType = typeof(Resource.Resource))]
        public string VentaDetalleId
        {
            get;
            set;
        }
        [Required(ErrorMessageResourceName = "FieldRequired", ErrorMessageResourceType = typeof(Resource.Resource))]
        [Display(Name = "VDetalle")]
        [StringLength(50, ErrorMessageResourceName = "VDetalleMessageError", MinimumLength = 3, ErrorMessageResourceType = typeof(Resource.Resource))]
        public string VDetalle
        {
            get;
            set;
        }
        #endregion
    }
}