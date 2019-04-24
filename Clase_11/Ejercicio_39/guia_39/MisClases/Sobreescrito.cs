using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisClases
{
    public abstract class Sobreescrito
    {

      protected string miAtributo;

      protected Sobreescrito(string miAtributo)
      {
        this.miAtributo = "Probar abstractos";
      }

      public abstract string MiPropiedad { get; }

      public abstract string MiMetodo();

    }
}
