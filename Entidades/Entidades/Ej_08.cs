using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ej_08
    {
        private int valorPorHora;
        private string nombre;
        private int años;
        private int horasTrabajas;
        const int bonoAntiguedad = 150;

        public Ej_08(int valorPorHora, string nombre, int años, int horasTrabajas)
        {
            this.valorPorHora = valorPorHora;
            this.nombre = nombre;
            this.años = años;
            this.horasTrabajas = horasTrabajas;
        }

        public void CalcularSalario(out double bruto, out double descuento, out double neto)
        {
            bruto = (this.valorPorHora * this.horasTrabajas) + (this.años * bonoAntiguedad);
            descuento = bruto * 0.13;
            neto = bruto - descuento;
        }

        public void MostrarRecibo()
        {
            double bruto;
            double descuento;
            double neto;

            CalcularSalario(out bruto, out descuento, out neto);

            Console.WriteLine("Nombre: " + this.nombre);
            Console.WriteLine("Antiguedad: " + this.años);
            Console.WriteLine("Valor Por Hora: " + this.valorPorHora);
            Console.WriteLine("Salario Bruto: " + bruto);
            Console.WriteLine("Descuento de Salario: " + descuento);
            Console.WriteLine("Salario Neto: " + neto);
        }
    }
}
