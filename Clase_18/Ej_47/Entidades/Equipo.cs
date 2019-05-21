using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Equipo
    {
        private string nombre;
        private DateTime fechaDeCreacion;

        protected Equipo(string nombre, DateTime fechaDeCreacion)
        {
            Nombre = nombre;
            FechaDeCreacion = fechaDeCreacion;
        }

        public string Nombre { get; set; }
        public DateTime FechaDeCreacion { get; set; }

        public string Ficha()
        {
            return "Nombre: " + Nombre + "Fecha de Creacion: " + FechaDeCreacion;
        }


    }
}
