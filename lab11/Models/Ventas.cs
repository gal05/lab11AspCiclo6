using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab11.Models
{
    public class Ventas
    {
        public int cantidad { get; set; }
        public double precio { get; set; }
        public double subtotal()
        {
            return precio * cantidad;
        }

        public double igv()
        {
            return subtotal() * 0.10;
        }
        public double total()
        {
            return subtotal() + igv();
        }
    }
}