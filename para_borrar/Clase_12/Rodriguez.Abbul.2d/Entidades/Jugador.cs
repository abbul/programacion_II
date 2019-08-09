using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Jugador : Persona
  {
    private float altura;
    private float peso;
    private Posicion posicion;

    public float Altura { get; }
    public float Peso { get; }
    public Posicion Posicion { get; }

    public Jugador(string apellido, int dni, int edad, string nombre, float altura, float peso, Posicion posicion) : base(apellido, dni, edad, nombre)
    {
      Altura = altura;
      Peso = peso;
      Posicion = posicion;
    }

    public override string Mostrar()
    {
      string cadena;
      cadena = base.Mostrar() + "__Altura: " + Altura + "__Peso: " + Peso + "__Posicion: " + Posicion;

      return cadena;
    }

    public override bool ValidarActitud()
    {
      return (Edad < 40 && ValidarEstadoFisico() ) ? true : false;
    }

    public bool ValidarEstadoFisico()
    {
      double IMC = Peso / Math.Pow(Altura , 2);

      return (IMC > 18.5 && IMC < 25.01) ? true : false; 
    }

  }
}
