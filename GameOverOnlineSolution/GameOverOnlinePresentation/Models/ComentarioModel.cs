using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GameOverOnlinePresentation.Models
{
    public class ComentarioModel
    {
        #region Propiedades
        /// <summary>
        /// Recuperacion del codigo dentro del modulo
        /// </summary>

        [Display(Name = "CommentaryId")]
        public int ComentarioId
        {
            get;
            set;
        }
        [Display(Name = "UserId")]
        public int UsuarioId
        {
            get;
            set;
        }
        [Required(ErrorMessageResourceName = "FieldRequired", ErrorMessageResourceType = typeof(Resource.Resource))]
        [Display(Name = "FirstName")]
        [StringLength(50, ErrorMessageResourceName = "FirstNameMessageError", MinimumLength = 3, ErrorMessageResourceType = typeof(Resource.Resource))]
        public string ComentarioText
        {
            get;
            set;
        }
        public bool Eliminado
        {
            get;
            set;
        }

        #endregion
    }
}