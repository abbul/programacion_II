namespace Entidades
{
    class Ej_20_Dolar
    {
        private double cantidad;
        private float cotizRespectoDolar;

        private Ej_20_Dolar()
        {

        }

        public Ej_20_Dolar(double cantidad)
        {
            this.cantidad = cantidad;

        }

        public Ej_20_Dolar(double cantidad, float cotizRespectoDolar)
        {
            this.cantidad = cantidad;
            this.cotizRespectoDolar = cotizRespectoDolar;
        }

        public static explicit operator Ej_20_Euro(Ej_20_Dolar D)
        {

        }

        public static explicit operator Ej_20_Pesos(Ej_20_Dolar D)
        {

        }

        public double GetCantidad()
        {
            return cantidad;
        }

        public float GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public implicit operator Ej_20_Dolar(double d)
        {

        }
    }
}
