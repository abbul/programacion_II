using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Avion : IAvion
    {
        private int horasVuelo;
        private Thread vuelo;

        public Avion(int horasVuelo)
        {
            this.horasVuelo = horasVuelo;
        }

        public EstadoDeVuelo Estado {

            get{

                if (vuelo.IsAlive)
                {
                    return EstadoDeVuelo.Volando;
                }

                else if (!vuelo.IsAlive)
                {
                    return EstadoDeVuelo.Aterrizado;
                }
                else
                {
                    return EstadoDeVuelo.Programado;
                }
            }

        }

        public int HorasDeVuelo { get { return horasVuelo;  } }

        public void Despegar()
        {
            vuelo = new Thread(Volar);
            vuelo.Start();
        }

        public void Estrellar()
        {
            Thread.ResetAbort();
        }

        public void Volar()
        {
            int horasRestantes = this.horasVuelo;
            int porcentajeCompletado = 100;
            //ReportarEstado = metodo

            while (porcentajeCompletado <= 100)
            {
                Thread.Sleep(1000);
                horasRestantes -= 1;

                porcentajeCompletado-= ReportarEstado(horasVuelo, horasRestantes);
            }

        }

        public event ReporteDeEstado ReportarEstado;

    }

    public enum EstadoDeVuelo
    {
        Programado=1,
        Volando=2,
        Aterrizado=3
    }
}
