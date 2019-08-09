using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MisClases
{
  class PuestoAtencion
  {
    private static int numeroActual;
    private Puesto puesto;

    public static int NumeroActual
    {
      get {
        numeroActual++;
        return NumeroActual;
      }
    }

    public PuestoAtencion()
    {
      numeroActual = 0;
    }

    public PuestoAtencion(Puesto puesto)
    {
      this.puesto = puesto;
    }

    public bool Atender(Cliente cli)
    {
      Thread.Sleep(3000);

      return true;
    }

    public enum Puesto
    {
      Caja1,
      Caja2
    }

  }
}
