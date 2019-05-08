using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ej_11_Validacion
    {
        private const int cantidad = 10;
        private const int min = -100;
        private const int max = 100;
        public static bool Validar(int valor)
        {
            return (valor >= min && valor <= max) ? true : false;
        }
        public static void PedirDatos()
        {
            bool buffer;
            int numero;
            int acumulador = 0;

            for (int i = 0; i < cantidad; i++)
            {
                do
                {
                    Console.Write("Ingrese Numro: ");
                    buffer = int.TryParse(Console.ReadLine(), out numero);

                    if (buffer)
                    {
                        buffer = Validar(numero);

                        if(buffer)
                        {
                            acumulador+= numero;
                        }
                    }
                    else if(!buffer)
                    {
                        Console.WriteLine("Error, debe ingresar un INT entre: " + min + " y " + max);
                    }

                } while (!buffer);
            }

            Console.WriteLine("Minimo: " + min);
            Console.WriteLine("Maximo: " + max);
            Console.WriteLine("Promedio: " + (acumulador/cantidad));

        }
    }
}
