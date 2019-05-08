using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ej_15_Calculadora
    {
        public static double Calcular(double n1, double n2, char operacion)
        {
            switch (operacion)
            {
                case '+':
                    return n1 + n2;

                case '-':
                    return n1 - n2;

                case '*':
                    return n1 * n2;

                case '/':
                    return (Validar(n2)) ? n1 / n2 : 0.00;

                default:
                    return 0.0;
            }
        }

        private static bool Validar(double numero)
        {
            return (numero != 0) ? true : false;
        }
    }
}
    