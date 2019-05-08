using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ej_16_Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        public void CalcularFinal()
        {
            if( nota1 >=4 && nota2 >=4)
            {
                Random rand = new Random();
                notaFinal = rand.Next();
            }
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            nota1 = notaUno;
            nota2 = notaDos;
        }

        public void Mostrar()
        {
            string final = (notaFinal == -1) ? Convert.ToString(notaFinal) : "Alumno Desaprobado";
            
            Console.Write("Alumno: "+ apellido + " " + nombre +" Legajo: " +legajo);
            Console.WriteLine(" Nota_1: " + nota1 + "Nota_2: " + nota2 + "Final: " +final);
        }
    }
}
