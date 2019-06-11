using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Old
  {
    public int id;
    public bool estado;
    public bool presionado;

    public Old(int numId)
    {
      estado = false;
      presionado = false;
      id = numId;
    }
  }
}
