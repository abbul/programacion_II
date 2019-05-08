using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ej_09
    {
        private int numero;
        public void CargarNumero()
        {
            bool buffer;

            Console.Write("Ingrese la altura de la piramide: ");
            buffer = int.TryParse(Console.ReadLine(), out numero);

            if(numero<=0)
            {
                buffer = false;
            }

            while (!buffer)
            {
                Console.WriteLine("_______________________");
                Console.WriteLine("Error, debe ingresar un INT mayor a 0");
                buffer = int.TryParse(Console.ReadLine(), out numero);
            }
        }

        public void MostrarPiramide()
        {
            string buffer="*";

            Console.WriteLine(buffer);

            if(numero>1)
            {
                for (int i = 1; i < this.numero; i++)
                {
                    buffer += "**";
                    Console.WriteLine(buffer);
                }
            }
            
        }
    }
}
