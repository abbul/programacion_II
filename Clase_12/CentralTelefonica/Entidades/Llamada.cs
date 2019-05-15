using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Llamada
  {
    protected float duracion;
    protected string nroOrigen;
    protected string nroDestino;

    public Llamada(float duracion, string nroOrigen, string nroDestino)
    {
      this.duracion = duracion;
      this.nroOrigen = nroOrigen;
      this.nroDestino = nroDestino;
    }


    public float Duracion { get; }
    public string NroOrigen { get; }
    public string NroDestino { get; }

    public virtual string Mostrar()
    {
      StringBuilder sb = new StringBuilder();

      sb.AppendLine("Duracion: " + Duracion + " Origen: " + NroOrigen + " Destino: " + NroDestino);

      return Convert.ToString(sb);
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
