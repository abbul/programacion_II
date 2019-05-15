using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Provincial : Llamada
  {
    protected Franja franjaHoraria;

    public Provincial(Franja miFranja, Llamada llamada) : base(llamada.Duracion, llamada.NroOrigen, llamada.NroDestino)
    {
      franjaHoraria = miFranja;
      
    }

    public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion, origen, destino)
    {
      franjaHoraria = miFranja;

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
      StringBuilder sb = new StringBuilder();

      sb.Append(base.Mostrar());
      sb.Append("Franja: " +franjaHoraria + " Costo: " + CostoLlamada);

      return Convert.ToString(sb);

    }

    public enum Franja
    {
      Franja_1,
      Franja_2,
      Franja_3
    }

  }
}
