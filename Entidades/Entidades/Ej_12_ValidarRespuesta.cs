using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ej_12_ValidarRespuesta
    {
        public static void PedirNumero()
        {
            int numero;
            int acumuador=0;
            bool buffer;
            bool seguir;
            char opcion;

            do
            {
                Console.Write("Ingrese Numero: ");
                buffer = int.TryParse(Console.ReadLine(), out numero);

                if(buffer)
                {
                    acumuador += numero;
                }
                else
                {
                    Console.WriteLine("Valor ERRONEO; debe ser un INT");
                    Console.WriteLine("_____________________________");
                }

                Console.Write("Desea continuar.? (S/N)");
                char.TryParse(Console.ReadLine(), out opcion);
                seguir = ValidaS_N(opcion);

            } while (seguir);
        }

        public static bool ValidaS_N(char c)
        {
            return (c == 'S') ? true : false;
        }
    }
}
