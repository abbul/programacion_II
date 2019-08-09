using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisClases
{
    public class Sobreescrito
    {

    public override string ToString()
    {
      string cadena = "¡Este es mi método ToString sobreescrito!";
      //return "¡Este es mi método ToString sobreescrito!";

      return cadena.ToString();
    }

    public override bool Equals(object obj)
    {
      return (obj is Sobreescrito);
    }

    public override int GetHashCode()
    {
      int numero = 1142510187;

      return numero.GetHashCode();

      //return 1142510187;
    }

  }
}
