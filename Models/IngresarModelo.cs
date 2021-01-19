using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class IngresarModelo
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Modelo")]
        public String Modelo { get; set; }
        [Required]
        [Display(Name ="Id_Marca")]
        public int Id_Marca { get; set; }

        public int Idd { get; set; }

        public String Marca { get; set; }
    }
}