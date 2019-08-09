using System;

namespace Clase_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Dolar dolar = new Dolar(10);
            Peso euro = new Peso(1);
            Peso salida= (Peso) dolar.GetCantidad();

            Console.WriteLine("Cantidad Euros:" + salida.GetCantidad());

            Console.ReadKey();
        }
    }
}
