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
            Numero numero = new Numero();

            Console.Write("Ingre Numero: ");
            numero.CargarNumero();

            Numero.MostrarPrimos(numero.numero);

            Console.ReadKey();

        }
    }
}
