using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ej_17_Boligrafo
    {
        public const short cantidadTintaMaxima= 100;
        private ConsoleColor color;
        private short tinta;

        public Ej_17_Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor()
        {
            return color;
        }

        public short GetTinta()
        {
            return tinta;
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            bool salida;
            dibujo = "";

            if (gasto <= tinta && gasto >0)
            {
                SetTinta(gasto);
                salida = true;

                for (int i = 0; i < gasto; i++)
                {
                    dibujo += "*";
                }
            }
            else
            {
                salida = false;
            }

            return salida;
            
        }

        public void Recargar()
        {
            tinta = cantidadTintaMaxima;
        }

        private void SetTinta(short tinta)
        {
            this.tinta += tinta;

            if(this.tinta<0)
            {
                this.tinta += tinta;
            }
            else if(this.tinta>100)
            {
                this.tinta -= tinta;
            }
        }
    }
}
