using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GameOverOnlinePresentation.Models
{
    public class CompraModel
    {

        #region Propiedades
        /// <summary>
        /// Recuperacion del codigo dentro del modulo
        /// </summary>

        [Display(Name = "PurchaseId")]
        public int CompraId
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
        [Display(Name = "ProviderId")]
        public int ProveedorId
        {
            get;
            set;
        }

        #endregion
    }
}