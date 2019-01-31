using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameOverOnlinePresentation.Models
{
    public class KeyValueUsuarioModel
    {
        #region Propiedades
        ///<summary>
        ///Codigo
        ///</summary>
        [Display(Name = "ID")]
        public int Codigo
        {
            get;
            set;
        }
        [Required]
        [Display(Name = "FullName", ResourceType = typeof(Resource.Resource))]
        public string Nombre
        {
            get;
            set;
        }
        #endregion;
    }
}