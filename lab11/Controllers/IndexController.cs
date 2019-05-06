using lab11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab11.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            Ventas ven = new Ventas();
            ven.precio = Convert.ToDouble(Request.Form["txtprecio"]);
            ven.cantidad = Convert.ToInt32(Request.Form["txtcantidad"]);


            return View(ven);
        }
    }
}