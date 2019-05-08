using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PlacaVideo : Periferico
    {
        private int ramMB;

        public PlacaVideo( string marca, string modelo, int ramMB) 
            : base(EConector.PCIExpress,marca,modelo)
        {
            this.ramMB = ramMB;
        }

        public override string ExponerDatos()
        {
            StringBuilder cadena = new StringBuilder();

            cadena.AppendLine("PLACA DE VIDEO" + Marca + " " + Modelo + "<Puerto:" + Conector + ">");
            cadena.AppendLine("Memoria " + ramMB + "MB");

            return Convert.ToString(cadena);
        }
    }
}
