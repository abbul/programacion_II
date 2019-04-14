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

    public Alumno(string cuatro, string cinco, int seis )
    {
      this.nombre = cuatro;
      this.apellido = cinco;
      this.legajo = seis;

    }

    public void CalcularFinal()
    {
      this.notaFinal = this.notaUno + this.notaFinal;
    }

    public void Estudiar(int uno, int dos)
    {
      this.notaUno = uno;
      this.notaDos = dos;
    }

    public void Mostrar()
    {

      Console.WriteLine(this.nombre + ' ' + this.apellido);
      Console.WriteLine("\n - " + colegio);

      System.Console.ReadKey();
    }
  }
}
