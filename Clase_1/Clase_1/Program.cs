using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_1
{
    class Program
    {

        static float uno;
        static float dos;
        static float opcion;
        static string buffer;

        static void Main(string[] args)
        {

            // imprimimos una linea
            System.Console.WriteLine("Ingrese primero: ");
            // leemos un string y lo guardanos en una var sting
            buffer = Console.ReadLine();
            // colocamos el tipo de dato, y llamamos al parse, q le pasamos el dato y donde lo guardara.
            float.TryParse(buffer, out uno);

            System.Console.WriteLine("\n Ingrese segundo: ");
            buffer = Console.ReadLine();
            // igual a TryParse, pero este si esta mal rompe todo, el otro reporta un boleano
            dos = float.Parse(buffer);

            System.Console.WriteLine("\n Ingrese Opcion: ");
            buffer = Console.ReadLine();
            opcion = float.Parse(buffer);

            System.Console.WriteLine("\n Resultado: ");
            System.Console.WriteLine(operacion(uno, dos, opcion));

            // es una pausa en el codigo
            System.Console.ReadKey();

        }


        static float operacion(float uno, float dos, float opcion)
        {
            float salida = 0;

            switch (opcion)
            {

                case 1:
                    salida = (float)(uno + dos);
                    break;

                case 2:
                    salida = uno - dos;
                    break;

                case 3:
                    salida = uno * dos;
                    break;

            }

            return salida;

        }
    }

}
