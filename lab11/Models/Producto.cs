using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab11.Models
{
    public class Producto
    {
        public int cantidad { get; set; }
        public double precio { get; set; }
        public double subtotal { get; set; }
        public double igv { get; set; }
        public double total { get; set; }
    }
}