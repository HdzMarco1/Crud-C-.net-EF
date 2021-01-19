using Prueba.Models;
using Prueba.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Prueba.Controllers
{
    public class AutosController : Controller
    {
        // GET: Autos
        public ActionResult Index()
        {
            List<Mostrar> lst;
            
          

            using (AutosEntities2 db = new AutosEntities2()) {

                lst = (from m in db.Modelo
                       join ma in db.Marca on m.Id_Marca equals ma.Id
                       join p in db.precios on m.Id equals p.Id_Modelo
                       select new Mostrar{

                           idd = ma.Id,
                           id = m.Id,
                           Id = p.Id,
                           Modelo = m.Modelo1,
                           Id_Marca = m.Id_Marca.Value,
                           Marca = ma.Marca1,
                           Costo = p.Costo.Value,
                           Precio = p.Precio.Value,
                           Utilidad = p.Utilidad.Value,
                           Id_Modelo = p.Id_Modelo.Value,


                       }).ToList();           
              
            }

            return View(lst);
            
        }

        public ActionResult ingresar()
        {

            return View();
        }

        public ActionResult ingresarmarca()
        {

            return View();
        }

        [HttpPost]
        public ActionResult ingresarmarca(IngrearMarca model) {

            try
            {
                if (ModelState.IsValid) {

                   using (AutosEntities2 db = new AutosEntities2())
                    {
                        
                        var oMarca = new Marca();
                        oMarca.Marca1 = model.Marca;
                        

                        db.Marca.Add(oMarca);
                        db.SaveChanges();
                    }

                    return Redirect("~/Autos/Index");
                }
                return View(model);
            }
            catch (Exception e) {
                throw new Exception(e.Message);
            }
        
        }


        public ActionResult ingresarmodelo()
        {
            Wrapper wrapper = new Wrapper();
            Servicios.Servicio autoService = new Servicios.Servicio();
            wrapper.Marcas = autoService.obtenerMarcas();
            return View(wrapper);
        }

        [HttpPost]
        public ActionResult ingresarmodelo(Wrapper wrapper_)
        {

            try
            {
                
              if (ModelState.IsValid)
                {

                    using (AutosEntities2 db = new AutosEntities2())
                    {

                        var oModelo = new Modelo();
                        oModelo.Modelo1 = wrapper_.Modelo.Modelo;
                        oModelo.Id_Marca = wrapper_.Modelo.Id_Marca;

                        db.Modelo.Add(oModelo);
                        db.SaveChanges();
                    }


                    return Redirect("~/Autos/Index");
                }
                
                return View(wrapper_);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public ActionResult ingresarprecios()
        {
            Wrapper pre = new Wrapper();
            Servicios.Servicio cio = new Servicios.Servicio();
            pre.Modelos = cio.obtenerModelos();
            return View(pre);
        }

        [HttpPost]
        public ActionResult ingresarprecios(Wrapper pre_)
        {

            try
            {
                if (ModelState.IsValid)
                {

                    using (AutosEntities2 db = new AutosEntities2())
                     {

                         var oPrecios = new precios();
                        oPrecios.Costo = pre_.Precios.Costo;
                        oPrecios.Precio = pre_.Precios.Precio;
                        oPrecios.Id_Modelo = pre_.Precios.Id_Modelo;

                         db.precios.Add(oPrecios);
                         db.SaveChanges();
                     }

                    return Redirect("~/Autos/Index");
                }
                return View(pre_);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }


        public ActionResult Editar( int idd) {

              


            return View();
        }


    }
}