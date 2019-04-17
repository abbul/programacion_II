using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisClases
{
  public class Llamada
  {
    protected float duracion;
    protected string nroOrigen;
    protected string nroDestino;

    public float Duracion { get;  }
    public string NroOrigen { get; }
    public string NroDestino { get; }

    public Llamada(float duracion, string nroOrigen, string nroDestino)
    {
      this.duracion = duracion;
      this.nroOrigen = nroOrigen;
      this.nroDestino = nroDestino;
    }

    public string Mostrar()
    {
      return "ORIGEN:" + NroOrigen;
    }

    public int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
    {
      return 1;
    }

    public enum TipoLlamada
    {
      Local,
      Provincial,
      Todas
    }
  }
}
