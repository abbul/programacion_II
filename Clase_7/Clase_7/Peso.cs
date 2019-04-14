using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_7
{
    public class Peso
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        private Peso()
        {
            cotizRespectoDolar = 38.33;
        }

        public Peso(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public Peso(double cantidad, double cotizacion) : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }
    }
}
