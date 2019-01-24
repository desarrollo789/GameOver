using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PracticaNro1Solution.Models
{
    public class EjercicioNro1
    {
        /// <summary>
        /// Obtiene  y controla el numero B
        /// </summary>
        [Required]
        [Display(Name = "numero_a")]
        [Range(0, int.MaxValue, ErrorMessage = "El numero debe ser entero positivo")]
        public int numero_a { get; set; }

        /// <summary>
        /// Obtiene  y controla el numero B
        /// </summary>
        [Required]
        [Display(Name = "numero_b")]
        [Range(0, int.MaxValue, ErrorMessage = "El numro bede ser entero positivo")]
        public int numero_b { get; set; }

        public int respuesta { get; set; }
    }
}