using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Controles
{
    public partial class Vuelo : UserControl,IAvion
    {
        private Avion avion;

        public Vuelo(int horasVuelo)
        {
            InitializeComponent();
            avion = new Avion(horasVuelo);
            avion.ReportarEstado += MoverAvion;
        }

        public EstadoDeVuelo Estado { get; }

        public void Despegar()
        {
            this.picAvion.Show();
            avion.Despegar();
        }

        public void Estrellar()
        {
            avion.Estrellar();
        }

        public int MoverAvion(int horasTotales, int horasRestantes)
        {
            if (this.picAvion.InvokeRequired)
            {
                int porcentajeCompletado = 100 - (horasRestantes * 100) / horasTotales;

                return ( 100 - porcentajeCompletado);
            }
            else
            {
                int porcentajeCompletado = 100 - (horasRestantes * 100) / horasTotales;
                // 664 es 100% entonces X es el porcentajeCompletado
                int ejeX = (664 * porcentajeCompletado) / 100;
                if (ejeX > 664)
                    ejeX = 664;

                this.picAvion.Location = new Point(ejeX + 58, this.picAvion.Location.Y);

                return porcentajeCompletado;
            }
        }

        private void picDeparture_Click(object sender, EventArgs e)
        {

        }

        private void picAvion_Click(object sender, EventArgs e)
        {

        }
    }
}
