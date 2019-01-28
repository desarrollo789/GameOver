using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace GameOverOnlineSolution.Models
{
    public class ComentarioModel
    {
        [Display(Name = "ComentarioId")]
        public int ComentarioId
        {
            get;
            set;
        }
        [Display(Name = "UsuarioId")]
        public int UsuarioId
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessageResourceName = "CommentMessageError", MinimumLength = 3, ErrorMessageResourceType = typeof(Resource.Resource))]
        [Required(ErrorMessageResourceName = "FieldRequired", ErrorMessageResourceType = typeof(Resource.Resource))]
        [Display(Name = "CommentText", ResourceType = typeof(Resource.Resource))]
        public string Comentarios
        {
            get;
            set;
        }

        public bool Eliminado
        {
            get;
            set;
        }

    }
}