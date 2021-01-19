using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class IngresarPrecios
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Costo")]
        public Decimal Costo { get; set; }
        [Required]
        [Display(Name = "Precio")]
        public Decimal Precio { get; set; }
        public Decimal Utilidad { get; set; }
        [Required]
        [Display(Name = "Id_Modelo")]
        public int Id_Modelo { get; set; }
    }
}