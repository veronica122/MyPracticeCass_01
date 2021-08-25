using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPracticeCass.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult MostrarProductos()
        {
            return View();
        }
    }
}