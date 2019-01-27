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
        /// Codigo
        /// </summary>
        
        [Display(Name = "UserId")]
        public int UsuarioId
        {
            get;
            set;
        }


        [Required(ErrorMessageResourceName="FieldRequired", ErrorMessageResourceType= typeof(Resource.Resource))]
        [Display(Name = "FirstName")]
        [StringLenght(50,ErrorMessageResourceName="FirstNameMessageError",MinimumLenght=3,ErrorMessageResourceType=typeof(Resource.Resource))]
        public int Nombre
        {
            get;
            set;
        }


        [Required(ErrorMessageResourceName = "FieldRequired", ErrorMessageResourceType = typeof(Resource.Resource))]
        [Display(Name = "LastName", ResourceType = typeof(Resource.Resource))]
        [StringLenght(50, ErrorMessageResourceName = "LastNameMessageError", MinimumLenght = 3, ErrorMessageResourceType = typeof(Resource.Resource))]
        public int Nombre
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
        [StringLenght(50, ErrorMessageResourceName = "UserNameMessageError", MinimumLenght = 3, ErrorMessageResourceType = typeof(Resource.Resource))]
        public string Usuario
        {
            get;
            set;
        }


        #endregion
    }
}