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

            numero.CargarNumero();

            Numero.CuadradoDelNumero(numero.num);
            Numero.CuboDelNumero(numero.num);

            Console.ReadKey();

        }
    }
}
