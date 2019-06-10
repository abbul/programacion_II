using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        public int numero;

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
        public static void MostrarPrimos(int numero)
        {            

            if(numero>1)
            {
                Console.WriteLine("Sus Primos Son: ");

                Console.WriteLine(2);

                for (int i = 2; i <= numero; i++)
                {
                    if (i % 1 != 0 )
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("No tiene primos");
            }      
        }
    }
}
