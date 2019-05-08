using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Ej_19_Sumador
    {
        private int cantidadSumas;

        public Ej_19_Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Ej_19_Sumador() : this(0)
        {

        }

        public long Sumar(long a, long b)
        {
            cantidadSumas++;
            return (a + b);
        }

        public string Sumar(string a, string b)
        {
            cantidadSumas++;
            return (a + b);
        }

        public static explicit operator int(Ej_19_Sumador  s)
        {
            return s.cantidadSumas;
        }

        public static bool operator |(Ej_19_Sumador s1, Ej_19_Sumador s2)
        {
            return (s1.cantidadSumas == s2.cantidadSumas) ? true : false;
        }

        public static long operator +(Ej_19_Sumador s1, Ej_19_Sumador s2)
        {
            return (s1.cantidadSumas + s2.cantidadSumas );
        }

    }
}
