using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Teclado : Periferico
    {
        private EDistribucion distribucion;

        public Teclado(string marca, string modelo, EConector conector)
            : base(conector, marca, modelo)
        {
            this.distribucion = EDistribucion.Dvorak;
        }

        public Teclado(string marca, string modelo, EConector conector, EDistribucion region)
            : base(conector, marca, modelo)
        {
            this.distribucion = region;
        }

        public override string ExponerDatos()
        {
            StringBuilder cadena = new StringBuilder();

            cadena.AppendLine("TECLADO" + Marca + " " + Modelo + "<Puerto:" + Conector + ">" );
            cadena.AppendLine("Distribucion " + distribucion);

            return Convert.ToString(cadena);
        }

        public static bool operator !=(Teclado t, EDistribucion distribuicion)
        {
            return (t.distribucion == distribuicion) ? false : true;
        }

        public static bool operator ==(Teclado t, EDistribucion distribuicion)
        {
            return (t.distribucion == distribuicion) ? true : false;
        }

        public enum EDistribucion
        {
            Dvorak,
            QWERTY,
            QWERTZ,
            AZERTY
        }

    }
}
