using System;

namespace Entities
{
  public class EmisorDeWhatsapp : Emisor
  {
    private int numeroTelefono;

    public EmisorDeWhatsapp(string mensaje, EProducto producto)
        : base(mensaje, producto)
    {

    }

    public EmisorDeWhatsapp()
    {
    }

    public int NumeroTelefono
    {
      get { return this.numeroTelefono; }
      set
      {
        if (value > 1500000000 && value < 1600000000)
        {
            this.numeroTelefono = value;
        }
        else
        {
          throw new WhatsappExceptions(std.StudentName);
        }
      }
    }

    /// <summary>
    /// Duerme el hilo durante 1 segundo y luego invoca al evento EventMensaje \
    /// pasándose a sí mismo(this) como parámetro.
    /// En caso de que no esté cargado el numero lanza un WhatsappException 
    /// indicando que el número no fue cargado.
    /// </summary>
    public override void EnviarMensaje()
    {
          
    }
  }
}
