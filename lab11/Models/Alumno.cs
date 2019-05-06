using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab11.Models
{
    public class Alumno
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string curso { get; set; }
        public double exparcial { get; set; }
        public double exFinal { get; set; }
        public double practica { get; set; }

        public double estadoFinal()
        {
            return ((exparcial * 2 + exFinal * 5 + practica * 3)/10);
        }
        public string textoFinal()
        {
            string resultado = "";
            if (estadoFinal() > 13)
            {
                resultado = "APROBADO";
            }
            else
            {
                resultado = "DESAPROBADO";
            }
            return resultado;
        }

    }
}