using Prueba.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class Wrapper
    {

        public List<Marca> Marcas { get; set; }
        public IngresarModelo  Modelo { get; set; }

        public List<Modelo> Modelos { get; set; }

        public IngresarPrecios Precios { get; set; }

    }
}