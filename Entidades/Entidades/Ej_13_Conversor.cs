using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ej_13_Conversor
    {

        public string DecimalBinario(double numero)
        {
            int entero;
            string salida = "";

            entero = Convert.ToInt32(numero);

            if (entero != 0 )
            {
                if (entero > 0)
                {

                    while (entero > 0)
                    {
                        salida = (entero % 2).ToString() + salida;
                        entero = entero / 2;
                    }

                    return salida;
                }

                else if (entero == 0)
                {
                    return "0";
                }
                else
                {
                    return "Debe ser >= 0";
                }

            }

            return "Valor Invalido";
        }
        public static string BinarioDecimal(string binario)
        {
            int i;
            int entero = 0;
            string returnAux = "";

            foreach (char c in binario)
            {
                if (c != '0' && c != '1')
                {
                    return "Valor no binario";
                }

            }


            if (binario == "" || ReferenceEquals(binario, null))
            {
                returnAux = "Valor inválido";
            }
            else
            {
                for (i = 1; i <= binario.Length; i++)
                {
                    entero += int.Parse(binario[i - 1].ToString()) * (int)Math.Pow(2, binario.Length - i);
                }
                returnAux = entero.ToString();
            }

            return returnAux;
        }
    }
}
