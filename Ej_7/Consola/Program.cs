using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {

            Vida fecha = new Vida();

            fecha.Cargar();

            Console.WriteLine("Dias Vividos hasta hoy: " + fecha.Vivido());
            
            Console.ReadKey();

        }
    }
}
