using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vida
    {
        public int dia;
        public int mes;
        public int year;

        public void Cargar()
        {

            Console.Write("Dia de Nacimiento: ");
            int.TryParse(Console.ReadLine(), out dia);
        

            Console.Write("Mes de Nacimiento: ");
            int.TryParse(Console.ReadLine(), out mes);
          

            Console.Write("Año de Nacimiento: ");
            int.TryParse(Console.ReadLine(), out year);
            Console.WriteLine("_________________");
        }
        public int Vivido()
        {
            return 1;
        }
    }
}
