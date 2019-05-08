using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ej_03
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
        public static void MostrarPrimos(int numero)
        {
            Console.WriteLine("primo" + numero);
        }
    }
}
