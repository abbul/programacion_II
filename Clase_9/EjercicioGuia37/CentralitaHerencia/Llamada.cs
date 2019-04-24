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

    public virtual string Mostrar()
    {
      StringBuilder cadena = new StringBuilder();

      cadena.Append("Duracion: " + this.duracion);
      cadena.Append("Origen: " + this.nroOrigen);
      cadena.AppendLine("Destino: " + this.NroDestino);

      return cadena.ToString();
    }

    public int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
    {
      return (llamada1.duracion > llamada2.duracion) ? 1 : 0;
    }

    public enum TipoLlamada
    {
      Local,
      Provincial,
      Todas
    }
  }
}
