using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ej_14_CalculoDeArea
    {
        public static double CalcularCuadrado(double numero)
        {
            return (numero * numero);
        }

        public static double CalcularTriangulo(double numero, double numeroDos)
        {
            return (numero * numero) + (numeroDos * numeroDos);
        }

        public static double CalcularCirculo(double numero)
        {
            return (numero * numero);
        }
    }
}
