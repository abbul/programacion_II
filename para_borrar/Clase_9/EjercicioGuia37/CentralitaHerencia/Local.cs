using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisClases
{
  public class Local : Llamada
  {
    protected float costo;

    public float CostoLlamada {
      get{

        return CalcularCosto();
      }
        
    }

    public Local(Llamada llamada, float costo)
    {
      this.costo = costo;
    }

    public Local(string origen, float duracion, string destino, float costoLlamada): base(duracion,origen,destino)
    {
      this.costo = costoLlamada;
    }

    private float CalcularCosto()
    {
      int minutos = Convert.ToInt32(Duracion);
      float segundos = minutos - Duracion;
    
      return (minutos * this.costo) + (segundos * (this.costo/60));
    }

    public override string Mostrar()
    {
      StringBuilder cadena = new StringBuilder();

      cadena.Append(base.Mostrar());
      cadena.AppendLine("Costo:" + this.costo);

      return cadena.ToString();

    }
  }
}
