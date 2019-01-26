using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameOverOnlineSolution.Models
{
    public class VideojuegoModel
    {
        [Display(Name = "ID")]
        public int VideojuegoId
        {
            get;
            set;
        }

        [Required(ErrorMessageResourceName = "FieldRequired", ErrorMessageResourceType = typeof(Resource.Resource))]
        [Display(Name = "GameName", ResourceType = typeof(Resource.Resource))]
        [StringLength(50, ErrorMessageResourceName = "GameNameMessageError", MinimumLength = 3, ErrorMessageResourceType = typeof(Resource.Resource))]
        public string NombreVideojuego
        {
            get;
            set;
        }

        [Required(ErrorMessageResourceName= "FieldRequired", ErrorMessageResourceType = typeof(Resource.Resource))]
        [Display(Name = "GamePrice")]
        public float PrecioVideojuego
        {
            get;
            set;
        }

        [Required(ErrorMessageResourceName= "FieldRequired", ErrorMessageResourceType = typeof(Resource.Resource))]
        [Display (Name = "GamePortrait")]
        public string PortadaVideojuego
        {
            get;
            set;
        }

        [Required(ErrorMessageResourceName = "FieldRequired", ErrorMessageResourceType = typeof(Resource.Resource))]
        [Display (Name = "GameTrailer")]
        public string TrailerVideojuego
        {
            get;
            set;
        }


    }
}