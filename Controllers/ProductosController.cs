using MyPracticeCass.Models;
using System;
using System.Collections.Generic;
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
    }
}