using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameOverOnlineSolution.Models
{
    public class UsuarioModel
    {
        #region Propiedades
        /// <summary>
        /// Recuperacion del codigo dentro del modulo
        /// </summary>
        
        [Display(Name = "UserId")]
        public int UsuarioId
        {
            get;
            set;
        }


        [Required(ErrorMessageResourceName="FieldRequired", ErrorMessageResourceType= typeof(Resource.Resource))]
        [Display(Name = "FirstName")]
        [StringLength(50, ErrorMessageResourceName = "FirstNameMessageError", MinimumLength = 3, ErrorMessageResourceType = typeof(Resource.Resource))]
        public string Nombre
        {
            get;
            set;
        }


        [Required(ErrorMessageResourceName = "FieldRequired", ErrorMessageResourceType = typeof(Resource.Resource))]
        [Display(Name = "LastName", ResourceType = typeof(Resource.Resource))]
        [StringLength(50, ErrorMessageResourceName = "FirstNameMessageError", MinimumLength = 3, ErrorMessageResourceType = typeof(Resource.Resource))]
        public string Apellido
        {
            get;
            set;
        }

        [Required(ErrorMessageResourceName = "FieldRequired", ErrorMessageResourceType = typeof(Resource.Resource))]
        [Display(Name = "EmailUser", ResourceType = typeof(Resource.Resource))]
        [StringLength(50, ErrorMessageResourceName = "EmailUserMessageError", MinimumLength = 3, ErrorMessageResourceType = typeof(Resource.Resource))]
        public string CorreoElectronico
        {
            get;
            set;
        }

        [Display(Name = "Birthdate", ResourceType = typeof(Resource.Resource))]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode= true)]
        public DateTime? FechaNacimiento
        {
            get;
            set;
        }

        [Required(ErrorMessageResourceName = "FieldRequired", ErrorMessageResourceType = typeof(Resource.Resource))]
        [Display(Name = "Username")]
        [StringLength(50, ErrorMessageResourceName = "UserNameMessageError", MinimumLength = 3, ErrorMessageResourceType = typeof(Resource.Resource))]
        public string Usuario
        {
            get;
            set;
        }


        #endregion
    }
}