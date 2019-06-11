using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Index
  {
    public List<Old> listaOld;
    private const int cantidad=4;

    public Index()
    {
      listaOld = new List<Old>();
    }

    public void Iniciar()
    {
      for (int i = 0; i < cantidad; i++)
      {
        listaOld.Add(new Old(i));
      }
    }
  }
}
