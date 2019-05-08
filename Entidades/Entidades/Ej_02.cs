using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ej_02
    {
        private int numero;

        public void CargarNumero()
        {
            bool buffer;

                buffer = int.TryParse(Console.ReadLine(), out numero);

                while (!buffer)
                {
                    Console.WriteLine("Error, debe ingresar un INT");
                    buffer = int.TryParse(Console.ReadLine(), out numero);
                }
        }

        public static void CuadradoDelNumero(int numero)
        {
            double buffer; 

            if( numero > 0 )
            {
                buffer =  Math.Pow(numero, 2);
                Console.Write("Cuadrado del Numero: " + buffer);
            }
            else
            {
                Console.Write("ERROR; Reingresar Numero!");
            }
        }

        public static void CuboDelNumero(int numero)
        {
            double buffer;

            if (numero > 0)
            {
                buffer = Math.Pow(numero, 4);
                Console.Write("Cuadrado del Numero: " + buffer);
            }
            else
            {
                Console.Write("ERROR; Reingresar Numero!");
            }
        }

    }
}
