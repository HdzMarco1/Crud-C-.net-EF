using Prueba.Datos;
using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba.Servicios
{
    public class Servicio
    {


        public List<Marca> obtenerMarcas()
        {
            using (AutosEntities2 db = new AutosEntities2())
            {
                return (from marca in db.Marca
                        select marca).ToList();

            }
        }

        public List<Modelo> obtenerModelos() {

            using (AutosEntities2 db = new AutosEntities2()) {
                return (from modelo in db.Modelo
                        select modelo).ToList();
            }
        }

        
    }
}