using System;
using Prueba.Datos;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class Mostrar
    {          
        //precio
        public int Id { get; set; }
        public decimal Costo { get; set; }
        public decimal Precio { get; set; }
        public decimal Utilidad { get; set; }
        public int Id_Modelo { get; set; }

       
        //modelo
        public int id { get; set; }
        public String Modelo { get; set; }
        public int Id_Marca { get; set; }

        //marca
        public int idd { get; set; }
        public String Marca { get; set; }
    }
}