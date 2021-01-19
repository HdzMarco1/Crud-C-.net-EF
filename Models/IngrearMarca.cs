using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class IngrearMarca
    {
        /*//precio
        public int Id { get; set; }
        [Required]
        [Display(Name = "Costo")]
        public decimal Costo { get; set; }
        [Required]
        [Display(Name = "Precio")]
        public decimal Precio { get; set; }
        public decimal Utilidad { get; set; }
        [Required]
        [Display(Name = "Id_Modelo")]
        public int Id_Modelo { get; set; }


        //modelo
        /*public int id { get; set; }
        [Required]
        [Display(Name = "Modelo")]
        public String Modelo { get; set; }
        [Required]
        [Display(Name = "Id_Marca")]
        public int Id_Marca { get; set; }*/

        //marca
        public int Id { get; set; }
        [Required]
        [Display(Name = "Marca")]
        public String Marca { get; set; }
    }
}