using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
  public abstract class Persona
  {
    private string apellido;
    private int dni;
    private int edad;
    private string nombre;

    public string Apellido { get; }
    public int Dni { get; }
    public int Edad { get; }
    public string Nombre { get; }

    public Persona(string apellido, int dni, int edad, string nombre)
    {
      Apellido = apellido;
      Dni = dni;
      Edad = edad;
      Nombre = nombre;
    }

    public virtual string Mostrar()
    {
      string cadena;

      cadena = Apellido + " " + Nombre + "__ DNI: " + Dni + "__Edad: " + Edad;

      return cadena;
    }

    public abstract bool ValidarActitud();
  }
}
