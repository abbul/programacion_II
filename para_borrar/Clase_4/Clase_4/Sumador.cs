using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_4
{
  class Sumador
  {
    private int cantidadSumas;

    public Sumador(): this(0)
    {
      
    }

    public Sumador(int cantidadSumas)
    {
      this.cantidadSumas = cantidadSumas;
    }

    public long Sumar(long a, long b)
    {
      this.cantidadSumas++;

      return a + b;
    }

    public string Sumar(string a, string b)
    {
      this.cantidadSumas++;

      return a + "_" + b;
    }

  }
}
