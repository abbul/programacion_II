using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Pelicula : Cine
    {
        private bool saga;

        public Pelicula(bool saga, string titulo, int duracion,  int estreno, string descripcion)
            : base(titulo, duracion, estreno, descripcion)
        {
            this.saga = saga;
        }

        public string Saga { get; set; }
    }
}
