using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisClases
{
  class Jugador
  {
    private int dni;
    private string nombre;
    private int partidosJugados;
    private float promedioGoles;
    private int totalGoles;

    public Jugador()
    {

    }

    public Jugador(int dni, string nombre)
    {
      this.dni = dni;
      this.nombre = nombre;
    }

    public Jugador(int dni, string nombre, int partidosJugados, int totalGoles)
    {
      this.dni = dni;
      this.nombre = nombre;
      this.partidosJugados = partidosJugados;
      this.totalGoles = totalGoles;
    }

    public float GetPromedioGoles()
    {
      return (this.totalGoles / this.partidosJugados);
    }
  }
}
