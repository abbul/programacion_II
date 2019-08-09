using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_3
{
  public class Alumno
  {
    int notaUno;
    int notaDos;
    public int notaFinal;
    public string nombre;
    public string apellido;
    public int legajo;
    static string colegio;

    static Alumno()
    {
      colegio = "UTN";
    }

    public Alumno(string nombre, string apellido, int legajo)
    {
      this.nombre = nombre;
      this.apellido = apellido;
      this.legajo = legajo;

    }

    public void CalcularFinal()
    {
      notaFinal = notaUno + notaFinal;
    }

    public void Estudiar(int notaUno, int notaDos)
    {
      this.notaUno = notaUno;
      this.notaDos = notaDos;
    }

    public void Mostrar()
    {

      Console.WriteLine(this.nombre + ' ' + this.apellido);
      Console.WriteLine("\n - " + colegio);

      System.Console.ReadKey();
    }
  }
}
