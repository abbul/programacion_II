using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Local : Llamada
  {
    protected float costo;

    public Local(float costoLlamada, Llamada llamada) :
      base(llamada.Duracion, llamada.NroOrigen, llamada.NroDestino)
    {
      costo = costoLlamada;
    }

    public Local(string origen, float duracion, string destino, float costoLlamada) :
      base(duracion,origen,destino)
    {
      costo = costoLlamada;
    }

    public float CostoLlamada
    {

      get
      {

        return CalcularCosto();
      }

    }

    private float CalcularCosto()
    {
      int minutos = Convert.ToInt32(duracion);
    
      return (minutos * costo);
    }

    public override string Mostrar()
    {
      StringBuilder sb = new StringBuilder();

      sb.Append(base.Mostrar());
      sb.AppendLine("Costo Llamada: " + CostoLlamada);

      return Convert.ToString(sb);

    }
  }
}
