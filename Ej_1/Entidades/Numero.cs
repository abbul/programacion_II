using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        public int[] valor;
        const int cantidad = 5;

        public Numero()
        {
            valor = new int[cantidad];
        }

        public void CargarNumero()
        {
            bool buffer;

            for (int i = 0; i < cantidad; i++)
            {
                buffer = int.TryParse(Console.ReadLine(), out valor[i]);

                while(!buffer)
                {
                    Console.WriteLine("Error, debe ingresar un INT");
                    buffer = int.TryParse(Console.ReadLine(), out this.valor[i]);
                }
            }
            
        }

        public static int MaximoValor(int[] vector)
        {
            int max = vector[0];

            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] > max)
                {
                    max = vector[i];
                }
            }
            return max;

        }

        public static int MinimoValor(int[] vector)
        {
            int min = vector[0];

            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] < min)
                {
                    min = vector[i];
                }
            }
            return min;

        }

        public static int PromedioValor(int[] vector)
        {
            int acumulador=0;
            int salida = 0;

            for (int i = 0; i < vector.Length; i++)
            {
                acumulador += vector[i];
            }

            salida = (acumulador / vector.Length);

            return salida;

        }
    }
}
