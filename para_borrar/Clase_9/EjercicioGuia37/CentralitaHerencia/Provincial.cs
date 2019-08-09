using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisClases
{
  public class Provincial : Llamada
  {
    protected Franja franjaHoraria;

    public float CostoLlamada
    {
      get
      {

        return CalcularCosto();
      }

    } 

    public Provincial(Franja miFranja, Llamada llamada)
    {
      this.franjaHoraria = miFranja;
      
    }

    public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion, origen, destino)
    {
      this.franjaHoraria = miFranja;

    }

    private float CalcularCosto()
    {
      float valor=0;

      switch ( (int)this.franjaHoraria)
      {
        case 1:
          valor = this.Duracion * 0.99f;
           break;
        case 2:
          valor = this.Duracion * 1.25f;
          break;
        case 3:
          valor = this.Duracion * 0.66f;
          break;
      }

       return valor;
    }

    public override string Mostrar()
    {
      StringBuilder cadena = new StringBuilder();

      cadena.Append(base.Mostrar());
      cadena.Append("Franja: " + this.franjaHoraria);
      cadena.AppendLine("Costo:" + CostoLlamada);

      return cadena.ToString();

    }

    public enum Franja
    {
      Franja_1,
      Franja_2,
      Franja_3
    }

  }
}
