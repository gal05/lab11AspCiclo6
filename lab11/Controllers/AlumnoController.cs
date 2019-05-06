using lab11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab11.Controllers
{
    public class AlumnoController : Controller
    {
        // GET: Alumno
        public ActionResult Index()
        {
            return View();
        }
        //resultado
        public ActionResult resultadosAlumno()
        {
            Alumno al = new Alumno();
            al.codigo = Convert.ToInt32(Request.Form["txtcodigo"]);
            al.nombre = Request.Form["txtnombre"].ToString();
            al.curso = Request.Form["txtcurso"].ToString();
            al.exparcial = Convert.ToDouble(Request.Form["txtparcial"]);
            al.exFinal = Convert.ToDouble(Request.Form["txtfinal"]);
            al.practica = Convert.ToDouble(Request.Form["txtpractica"]);

            return View("final",al);
        }
    }
}