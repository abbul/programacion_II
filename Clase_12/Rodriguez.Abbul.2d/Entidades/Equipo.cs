using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Equipo
  {
    private const int cantidadMaximaJugadores = 6;
    private DirectorTecnico directorTecnico;
    private List<Jugador> jugadores;
    private string nombre;

    public DirectorTecnico DirectorTecnico {

      set {
        this.directorTecnico = value;
      }
    }
    public string Nombre { get; }

    private Equipo()
    {
      this.jugadores = new List<Jugador>(); 
    }

    public Equipo(string nombre)
    {
      Nombre = nombre;
    }

    public static explicit operator string (Equipo e)
    {
      string dt = (e.directorTecnico != null) ? e.directorTecnico.Mostrar() : "Sin DT asignado";

      return e.Nombre + dt;
    }

    public static bool operator ==(Equipo e, Jugador j)
    {
      foreach (Jugador jugador in e.jugadores)
      {
        if (jugador == j){ return true; };
      }

      return false;
    }

    public static bool operator !=(Equipo e, Jugador j)
    {
      foreach (Jugador jugador in e.jugadores)
      {
        if (jugador == j) { return false; };
      }

      return true;
    }

    public static bool operator +(Equipo e, Jugador j)
    {
      if( e.jugadores.Count < 6 && j.ValidarActitud() && e.jugadores.Exists(j) )
      {
        e.jugadores.Add(j);
        return true;
      }
      else
      {
        return false;
      }
    }

    public bool ValidarEquipo(Equipo e)
    {
      bool flag = false;

      if(directorTecnico == null && e.jugadores.Count != 6 )
      {
        return false;
      }

      for(int i=0;i<4;i++)
      {
        foreach(Jugador jugador in e.jugadores )
        {
          if( (int)(jugador.Posicion) == i)
          {
            flag = true;
          }
        }

        if(flag == false)
        {
          return false;
        }
      }

      return true;



    }


  }
}
