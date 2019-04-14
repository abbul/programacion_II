using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_4
{
  class Boligrafo
  {
    const short cantidadTintaMaxima = 100;
    private ConsoleColor color;
    private short tinta;

    public Boligrafo(ConsoleColor color, short tinta)
    {
      this.color = color;
      this.tinta = tinta;
    }

    public ConsoleColor GetColor()
    {
      return this.color;
    }

    public short GetTinta()
    {
      return this.tinta;
    }

    public bool Pintar(short gasto  /*, out string dibujo*/)
    {
      bool flag= false;
      short valor;

      if (gasto > 0 && gasto <= 100 && this.tinta >= gasto )
      {
          Console.ForegroundColor = this.color;
          valor = (short) (this.tinta - gasto);
          this.SetTinta(valor);

        for(int i=0;i<gasto;i++)
        {
         // dibujo = ("*");
        }

        Console.WriteLine("\n\n");

        flag = true;
      }

      return flag;
    }

    public void Recargar()
    {
      this.tinta = cantidadTintaMaxima;
    }

    private void SetTinta(short tinta)
    {
        this.tinta= tinta;
    }

  }
}
