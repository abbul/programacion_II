using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Serie : Cine
    {
        private string nombreCapitulo;
        private int temporada;
        private int capitulo;

        public Serie(string nombreCapitulo, int temporada, int capitulo, string titulo, int duracion, int estreno, string descripcion) 
            : base (titulo, duracion, estreno, descripcion)
        {
            this.nombreCapitulo = nombreCapitulo;
            this.temporada = temporada;
            this.capitulo = capitulo;
        }

        public string NombreCapitulo { get; set; }
        public int Temporada { get; set; }
        public int Capitulo { get; set; }

        public Serie BuscarSerie( string nombre, List<Serie> lista)
        {

            foreach (Serie row in lista)
            {
                if (row.Titulo == nombre)
                {
                    return row;
                }
            }

            return null;

        }

        public Serie BuscarCapitulo(string nombre, List<Serie> lista)
        {

            foreach (Serie row in lista)
            {
                if (row.nombreCapitulo == nombre)
                {
                    return row;
                }
            }

            return null;

        }
    }
}
