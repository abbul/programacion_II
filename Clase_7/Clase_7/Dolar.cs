using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_7
{
    public class Dolar
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        private Dolar()
        {
            cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion) : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public double GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public static explicit operator Euro(Dolar p)
        {
            Euro euro = new Euro(p.cantidad);

            double valor = euro.GetCantidad() / euro.GetCotizacion(); 

            return euro;
           

        }

        public static explicit operator Peso(Dolar d)
        {
            Peso peso = new Peso(d.cantidad);

            double valor = peso.GetCantidad() / d.GetCotizacion();

            return peso;

        }

        public static implicit operator Dolar(double d)
        {
            Dolar dolar = new Dolar(d);

            return dolar;

        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return (d.GetCantidad() != e.GetCantidad()) ? true : false;
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            return (d.GetCantidad() == e.GetCantidad()) ? true : false;
        }

        public static bool operator +(Dolar d, Euro e)
        {
            return (d.GetCantidad() > e.GetCantidad()) ? true : false;
        }

        public static bool operator -(Dolar d, Euro e)
        {
            return (d.GetCantidad() < e.GetCantidad()) ? true : false;
        }

        public static bool operator !=(Dolar d, Peso p)
        {
            return (d.GetCantidad() != p.GetCantidad()) ? true : false;
        }

        public static bool operator ==(Dolar d, Peso p)
        {
            return (d.GetCantidad() == p.GetCantidad()) ? true : false;
        }

        public static bool operator +(Dolar d, Peso p)
        {
            return (d.GetCantidad() > p.GetCantidad()) ? true : false;
        }

        public static bool operator -(Dolar d, Peso p)
        {
            return (d.GetCantidad() < p.GetCantidad()) ? true : false;
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return (d1.GetCantidad() != d2.GetCantidad()) ? true : false;
        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return (d1.GetCantidad() == d2.GetCantidad()) ? true : false;
        }

    }
}
