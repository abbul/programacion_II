using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        public int num;

        public void CargarNumero()
        {
            bool buffer;

            do
            {
                Console.Write("Ingrese Numero: ");
                buffer = int.TryParse(Console.ReadLine(), out num);

                if(buffer == false)
                {
                    Console.WriteLine("ERROR. Debe ingresar un INT:");
                }

            } while (buffer == false);
        }

        public static void CuadradoDelNumero(int numero)
        {
            double buffer; 

            if( numero > 0 )
            {
                buffer =  Math.Pow(numero, 2);
                Console.WriteLine("Cuadrado del Numero: " + buffer);
            }
            else
            {
                Console.WriteLine("ERROR; Reingresar Numero!");
            }
        }

        public static void CuboDelNumero(int numero)
        {
            double buffer;

            if (numero > 0)
            {
                buffer = Math.Pow(numero, 4);
                Console.WriteLine("Cubo del Numero: " + buffer);
            }
            else
            {
                Console.WriteLine("ERROR; Reingresar Numero!");
            }
        }

    }
}
