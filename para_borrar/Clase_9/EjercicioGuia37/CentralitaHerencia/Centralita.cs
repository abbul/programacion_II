using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisClases
{
  public class Centralita
  {
    private List<Llamada> listaDeLlamadas;
    protected string razonSocial;

    public float GananciaPorLocal { get; }
    public float GananciaPorProvincia { get; }
    public float GananciaPorTotal { get; }
    public List<Llamada> Llamadas { get; set; }

    public Centralita()
    {
    }

    public Centralita(string nombreEmpresa)
    {
    }

    public string Mostrar()
    {
      return "asd";
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
