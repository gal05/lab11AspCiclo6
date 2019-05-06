using lab11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab11.Controllers
{
    public class OperacionesController : Controller
    {
        // GET: Operaciones
        public ActionResult Index()
        {
            return View();
        }
        //crear un metodo llamado resultado
        public ActionResult resultados()
        {
            Producto prod = new Producto();
            prod.cantidad = Convert.ToInt32(Request.Form["txtcantidad"]);
            prod.precio = Convert.ToDouble(Request.Form["txtprecio"]);
            prod.subtotal = (prod.precio * prod.cantidad);
            prod.igv = prod.subtotal * 0.18;
            prod.total = prod.subtotal + prod.igv;
            return View("boleta",prod);
        }
    }
}