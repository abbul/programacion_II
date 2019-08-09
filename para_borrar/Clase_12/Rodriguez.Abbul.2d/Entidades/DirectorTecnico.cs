using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class DirectorTecnico : Persona
  {
    private int añosExperiencia;

    public int AñosExperiencia { get; set; }

    public DirectorTecnico(string apellido, int dni, int edad, string nombre, int añosExperiencia):base(apellido, dni, edad, nombre)
    {
      AñosExperiencia = añosExperiencia;
    }

    public override string Mostrar()
    {
      string cadena; 
      cadena = base.Mostrar() + "__Experiencia: " + AñosExperiencia;

      return cadena;
    }

    public override bool ValidarActitud()
    {
      return (this.Edad < 65 && AñosExperiencia > 2) ? true : false;
    }
  }
}
