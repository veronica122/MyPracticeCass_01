using MyPracticeCass.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPracticeCass.Controllers
{
    public class ProductosController : Controller
    {
        //Agregar contexto para acceder a la bd
        private Contexto contexto = new Contexto();
        // GET: Productos

        //Método para mostrar listado de productos
        public ActionResult MostrarProductos()
        {
            var model = contexto.Productos.ToList();
            return View(model);
        }


        public ActionResult CreateOrEditProductos(int idProducto = 0)
        {
            if (idProducto > 0)
            {
                var model = contexto.Productos.FirstOrDefault(x => x.IdProducto == idProducto);
                return View(model);
            }
            else
            {
                var model = new Productos();
                return View(model);
            }

        }

        [HttpPost]
        public ActionResult CreateOrEditProductos(Productos model)
        {

            if (ModelState.IsValid)
            {
                if (model.IdProducto != 0)
                {
                    contexto.Entry(model).State = EntityState.Modified;
                    contexto.SaveChanges();
                }
                else
                {
                    contexto.Entry(model).State = EntityState.Added;
                    contexto.SaveChanges();
                }

                return RedirectToAction("MostrarProductos");
            }

            return View(model);
        }

        public ActionResult EliminarProductos(int idProducto)
        {
            var model = contexto.Productos.FirstOrDefault(x => x.IdProducto == idProducto);
            contexto.Entry(model).State = EntityState.Deleted;
            contexto.SaveChanges();

            return RedirectToAction("MostrarProductos");
        }

    }
}