using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GameOverOnlinePresentation.Models
{
    public class CategoriaModel
    {
        #region Propiedades
        /// <summary>
        /// Recuperacion del codigo dentro del modulo
        /// </summary>

        [Display(Name = "CategoryId")]
        public int CategoriaId
        {
            get;
            set;
        }
        [Required(ErrorMessageResourceName = "FieldRequired", ErrorMessageResourceType = typeof(Resource.Resource))]
        [Display(Name = "FirstName")]
        [StringLength(50, ErrorMessageResourceName = "FirstNameMessageError", MinimumLength = 3, ErrorMessageResourceType = typeof(Resource.Resource))]
        public string Nombre
        {
            get;
            set;
        }

        #endregion
    }
}