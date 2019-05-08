using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Maquina
    {
        private int cantidadMaxPerifericos;
        private string nombre;
        private List<Periferico> perifericos;

        public int CantidadMaximaPerifericos
        {

            get { return cantidadMaxPerifericos; }

            set {
                if (value < 1) { cantidadMaxPerifericos = 1; }
                else if (value > 4) { cantidadMaxPerifericos = 4; }
                else { cantidadMaxPerifericos = value; }
            }
         }

        public string Nombre { get; set; }

        public string SystemInfo {
            get {
                StringBuilder cadena = new StringBuilder();

                cadena.AppendLine("Cantidad de perifericos:" + CantidadMaximaPerifericos);
                cadena.AppendLine(Nombre);

                foreach (Periferico row in perifericos)
                {
                    cadena.AppendLine( row.ExponerDatos() );
                }

                return Convert.ToString(cadena);
            }
        }

        private Maquina()
        {
            perifericos = new List<Periferico>();
            cantidadMaxPerifericos = 3;
        }

        public Maquina(string nombre): this()
        {
            Nombre = nombre;
        }

        public static bool operator !=(Maquina m, Periferico p)
        {
            foreach (Periferico row in m.perifericos)
            {
                if (row == p) { return false; }
            }

            return true;
        }

        public static bool operator ==(Maquina m, Periferico p)
        {

            foreach (Periferico row in m.perifericos)
            {
                if( row == p) { return true; }
            }

            return false;
        }

        public static string operator +(Maquina m, Periferico p)
        {
            bool flag=true;

            if(m.CantidadMaximaPerifericos < 4)
            {
                foreach (Periferico row in m.perifericos)
                {
                    if (row == p) { flag = false; }
                }

                if(flag)
                {
                    m.perifericos.Add(p);
                    return "Periferico Conectado";
                }
            }

            return "No se puede conectar el dispositivo";
        }

        public static string operator -(Maquina m, Periferico p)
        {
            if( m == p )
            {
                foreach (Periferico item in m.perifericos.ToList())
                {
                    if(item == p)
                    {   
                        m.perifericos.Remove(item);
                        m.cantidadMaxPerifericos--;
                        return "Periferico Desconectado";
                    }
                }             
            }
            
            return "No se puede Desconectar el dispositivo";
        }

    }
}
