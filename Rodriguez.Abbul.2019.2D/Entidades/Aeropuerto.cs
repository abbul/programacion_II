using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Aeropuerto<T> where T : IAvion
    {
        private List<T> vuelos;

        public Aeropuerto()
        {
            vuelos = new List<T>();
        }

        public void FinalizarVuelo()
        {
            foreach (T item in vuelos)
            {
                item.Estrellar();
            }
        }

        public static explicit operator String(Aeropuerto<T> a)
        {
            int contador = 0;
            foreach (T avion in a.vuelos)
            {
                if ( (int)avion.Estado == 2 )
                {
                    contador++;
                }
            }
            
            return "El aeropuerto cuenta con " + contador +" vuelos en estado Volando";
        }

        public static int operator +(Aeropuerto<T> a, T vuelo)
        {
            a.vuelos.Add(vuelo);

            return (a.vuelos.Count * 50);
        }

    }
}
