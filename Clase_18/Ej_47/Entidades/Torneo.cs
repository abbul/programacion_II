using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Torneo
    {
        private List<Equipo> equipos;
        private string nombre;

        public static  bool operator ==(Equipo p, Torneo e)
        {
            foreach (Equipo item in e.equipos )
            {
                if ( item.Nombre == p.Nombre && item.FechaDeCreacion == p.FechaDeCreacion)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Equipo p, Torneo e)
        {
            return (p == e) ? false : true;
        }

        public static bool operator +(Equipo p, Torneo e)
        {
            if(p != e)
            {
                e.equipos.Add(p);
                return true;
            }

            return false;
            
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("TORNEO: " + nombre);

            foreach (Equipo item in equipos)
            {
                sb.AppendLine(item.Ficha());
            }

            return Convert.ToString(sb);
        }

        private string CalcularPartido(Equipo uno, Equipo dos)
        {
            Random r = new Random();

            return uno.Nombre + r.Next() + " - " + r.Next() + dos.Nombre;
        }

        public string CalcularPartido()
        {

        }
    }
}
