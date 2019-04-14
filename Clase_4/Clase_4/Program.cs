using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_4
{
  class Program
  {
    static void Main(string[] args)
    {
      /* TOD DE BOLIGRAFO
      Boligrafo uno = new Boligrafo(ConsoleColor.Blue,100);
      Boligrafo dos = new Boligrafo(ConsoleColor.Red, 50);
      string dibujo;

      uno.Pintar(3,dibujo);
      Console.WriteLine("\n Queda:" +  uno.GetTinta());
      Console.ReadKey();

      dos.Pintar(5,dibujo);
      Console.WriteLine("\n Queda:" + dos.GetTinta());
      Console.ReadKey();
      */

      Sumador tres = new Sumador();

      Console.WriteLine("\n Mensaje: " + tres.Sumar("hola","chao"));
      Console.ReadKey();

    }
  }
}
