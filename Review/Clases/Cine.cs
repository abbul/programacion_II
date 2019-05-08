using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public abstract class Cine
    {
        protected string titulo;
        protected int duracion;
        protected int estreno;
        protected string descripcion;

        public Cine(string titulo,  int duracion,  int estreno, string descripcion)
        {
            this.titulo = titulo;
            this.duracion = duracion;
            this.estreno = estreno;
            this.descripcion = descripcion;
        }

        public string Titulo { get; set; }
        public int Duracion { get; set;  }
        public int Estreno { get; set; }
        public string Descripcion { get; set; }

    }
}
