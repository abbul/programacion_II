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
            Numero numeros = new Numero();

            Console.WriteLine("Ingrese 5 numeros:");
            numeros.CargarNumero();

            Console.WriteLine("\n\nValor Maximo:   " + Numero.MaximoValor(numeros.valor));
            Console.WriteLine("Valor Minimo:   " + Numero.MinimoValor(numeros.valor));
            Console.WriteLine("Valor Promedio: " + Numero.PromedioValor(numeros.valor));

            Console.ReadKey();
        }
    }
}
