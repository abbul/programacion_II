using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Ej_18_Rectangulo
    {
        private float area;
        private float perimetro;
        private Ej_18_Punto vertice1;
        private Ej_18_Punto vertice2;
        private Ej_18_Punto vertice3;
        private Ej_18_Punto vertice4;

        public Ej_18_Rectangulo(Ej_18_Punto vertice1, Ej_18_Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
        }

        public float GetArea()
        {
            return area;
        }

        public float GetPerimetro()
        {
            return perimetro;
        }

    }
}
