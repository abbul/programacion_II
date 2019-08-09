using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Centralita
  {
    private List<Llamada> listaDeLlamadas;
    protected string razonSocial;

    public float GananciaPorLocal { get; }
    public float GananciaPorProvincia { get; }
    public float GananciaPorTotal { get; }

    public List<Llamada> Llamadas { get {return listaDeLlamadas; } }

    public Centralita()
    {
      listaDeLlamadas = new List<Llamada>();
    }

    public Centralita(string nombreEmpresa): this()
    {
      razonSocial = nombreEmpresa;
    }

    public string Mostrar()
    {
      StringBuilder sb = new StringBuilder();

      sb.AppendLine("Razon Social: " + razonSocial + "\n");
      sb.AppendLine("Ganacia Por Local    : " + GananciaPorLocal);
      sb.AppendLine("Ganacia Por Provincia: " + GananciaPorProvincia);
      sb.AppendLine("Ganacia Por Total    : " + GananciaPorTotal);
      

      foreach (Llamada item in listaDeLlamadas)
      {
        sb.AppendLine (item.Mostrar());
      }

      sb.AppendLine("____________________________________________");

      return Convert.ToString(sb);
    }

    public void OrdenarLlamadas()
    {

    }

    private float CalcularGanancia(Llamada.TipoLlamada tipo)
    {
      return 12.4f;
    }
  }
}
