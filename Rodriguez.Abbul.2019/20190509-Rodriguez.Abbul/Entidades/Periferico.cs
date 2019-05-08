using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Periferico
    {
        private EConector conector;
        private string marca;
        private string modelo;

        public string Marca { get { return marca; } }
        public string Modelo { get { return modelo; } }
        public EConector Conector { get { return conector; } }

        protected Periferico(EConector conector, string marca, string modelo)
        {
            this.conector = conector;
            this.marca = marca;
            this.modelo = modelo;
        }

        public static explicit operator string(Periferico p)
        {
            return p.modelo;
        }

        public abstract string ExponerDatos();

        public static bool operator !=(Periferico p1, Periferico p2)
        {
          return (p1.marca == p2.marca && p1.modelo == p2.modelo) ? false : true;  
        }

        public static bool operator ==(Periferico p1, Periferico p2)
        {
          return (p1.marca == p2.marca && p1.modelo == p2.modelo) ? true : false;  
        }



    }
}
