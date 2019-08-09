using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisClases
{
  public class Cliente
  {
    private string nombre;
    private int numero;

    public string Nombre { get; set; }
    public int Numero { get; }

    public Cliente(int numero)
    {
      Numero = numero;
    }

    public Cliente(string nombre, int numero)
    {
      Nombre = nombre;
      Numero = numero;
    }

    public static bool operator ==(Cliente c1, Cliente c2)
    {
      return c1.numero == c2.numero ? true : false;
    }

    public static bool operator !=(Cliente c1, Cliente c2)
    {
      return c1.numero != c2.numero ? true : false;
    }
  }
}
