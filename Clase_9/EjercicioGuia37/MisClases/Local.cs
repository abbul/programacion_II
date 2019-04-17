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

    public float CostoLlamada { get; }

    public Local(Llamada llamada, float costoLlamada): base()
    {
      CostoLlamada = costoLlamada;
    }

    public Local(string origen, float duracion, string destino, float costoLlamada)
    {
      CostoLlamada = costoLlamada;
    }

    private float CalcularCosto()
    {
      return 13.5f;
    }

    public string Mostrar()
    {
      return "hola";
    }
  }
}
