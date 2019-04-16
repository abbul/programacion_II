using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisClases
{
  class Negocio
  {
    private PuestoAtencion caja;
    private Queue<Cliente> clientes;
    private string nombre;

    public Cliente Clientes { get; set; }

    public Negocio()
    {
    }

    public Negocio(string nombre)
    {
      this.nombre = nombre;
    }

    public static bool operator ==(Negocio n, Cliente c)
    {
      foreach(Cliente uno in n.clientes )
       {
          if(uno.Numero == c.Numero)
          {
          return true;
          }
      }

      return  false;
    }

    public static bool operator !=(Negocio n, Cliente c)
    {
      foreach (Cliente uno in n.clientes)
      {
        if (uno.Numero != c.Numero)
        {
          return true;
        }
      }

      return false;
    }

    public static bool operator ~(Negocio n)
    {
      Cliente aux = n.Clientes;

      if (aux != null)
      {
        return n.caja.Atender(aux);
      }

      return false;
      
    }

    public static bool operator +(Negocio n, Cliente c)
    {
      bool flag=false;

      foreach(Cliente uno in n.clientes )
      {
        if(uno == c)
        {
          flag = true;
          break;
        }
      }

      if( flag== false)
      {
        n.Clientes = c;
      }

      return !flag;
      
    }
  }


}
