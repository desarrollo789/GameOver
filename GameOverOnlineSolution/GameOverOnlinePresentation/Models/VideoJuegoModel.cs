using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GameOverOnlinePresentation.Models
{
    public class VideoJuegoModel
    {
        #region Propiedades
        /// <summary>
        /// Recuperacion del codigo dentro del modulo
        /// </summary>
        [Display(Name = "VideoGameId")]
        public int VideoJuegoId
        {
            get;
            set;
        }
        [Required(ErrorMessageResourceName = "FieldRequired", ErrorMessageResourceType = typeof(Resource.Resource))]
        [Display(Name = "FirstNameGame")]
        [StringLength(50, ErrorMessageResourceName = "FirstNameGameMessageError", MinimumLength = 3, ErrorMessageResourceType = typeof(Resource.Resource))]
        public string Nombre
        {
            get;
            set;
        }
        public float Precio
        {
            get;
            set;
        }
        [Required(ErrorMessageResourceName = "FieldRequired", ErrorMessageResourceType = typeof(Resource.Resource))]
        [Display(Name = "Portade")]
        [StringLength(50, ErrorMessageResourceName = "PortadeMessageError", MinimumLength = 3, ErrorMessageResourceType = typeof(Resource.Resource))]
        public string Portada
        {
            get;
            set;
        }
        [Required(ErrorMessageResourceName = "FieldRequired", ErrorMessageResourceType = typeof(Resource.Resource))]
        [Display(Name = "Trailer")]
        [StringLength(50, ErrorMessageResourceName = "TrailerMessageError", MinimumLength = 3, ErrorMessageResourceType = typeof(Resource.Resource))]
        public string Trailer
        {
            get;
            set;
        }
        public bool Eliminado
        {
            get;
            set;
        }
        [Display(Name = "RegisterDate", ResourceType = typeof(Resource.Resource))]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Fecha
        {
            get;
            set;
        }
        public Ranking Ranking
        {
            get;
            set;
        }
        public Categoria Categoria
        {
            get;
            set;
        }
        public Comentario Comentario
        {
            get;
            set;
        }
        public Proveedor Proveedor
        {
            get;
            set;
        }
        ///trailer
        #endregion
    }
}