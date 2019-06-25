using System;

namespace Entities
{
  public class EmisorEntidades
  {
    public string Mostrar(this EmisorDeEmails emisor)
    {
      return emisor.ToString() + "Email:" + emisor.Email;
    }

    public string Mostrar(this EmisorDeWhatsapp emisor)
    {
      return emisor.ToString() + "Nro Tlf:" +emisor.NumeroTelefono;
    }
  }
}
