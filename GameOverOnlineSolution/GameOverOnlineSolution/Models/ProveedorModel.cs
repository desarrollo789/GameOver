using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameOverOnlineSolution.Models
{
    public class ProveedorModel
    {
        [Display(Name = "ID")]
        public int ProveedorId
        {
            get;
            set;
        }



        [Required(ErrorMessageResourceName = "FieldRequired", ErrorMessageResourceType = typeof(Resource.Resource))]
        [Display(Name = "EmailProvider", ResourceType = typeof(Resource.Resource))]
        [StringLength(50, ErrorMessageResourceName = "EmailMessageError", MinimumLength = 3, ErrorMessageResourceType = typeof(Resource.Resource))]
        public string CorreoElectronico
        {
            get;
            set;
        }

        [Required(ErrorMessageResourceName = "FieldRequired", ErrorMessageResourceType = typeof(Resource.Resource))]
        [Display(Name = "FirstNameProvider", ResourceType = typeof(Resource.Resource))]
        [StringLength(50, ErrorMessageResourceName = "FirstNameProviderMessageError", MinimumLength = 3, ErrorMessageResourceType = typeof(Resource.Resource))]
        public string NombreProveedor
        {
            get;
            set;
        }

        [Required(ErrorMessageResourceName = "FieldRequired", ErrorMessageResourceType = typeof(Resource.Resource))]
        [Display(Name = "LastNameProvider", ResourceType = typeof(Resource.Resource))]
        [StringLength(50, ErrorMessageResourceName = "LastNameProviderMessageError", MinimumLength = 3, ErrorMessageResourceType = typeof(Resource.Resource))]
        public string ApellidoProveedor
        {
            get;
            set;
        }


    }
}