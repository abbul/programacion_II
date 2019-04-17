using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisClases
{
    public class Libro
    {
      private List<string>[] paginas = new Libro[10];

    public string this[int i]
    {
      get {
          return ( i > this.paginas.Count && i < this.paginas.Count ) ? paginas[i] : "  ";
      }

      set {

        if (i > this.paginas.Count)
        {
          paginas[i] = value;
        }

        else if (i > this.paginas.Count)
        {
          this.paginas.Add(Convert.ToString(i));
        }  
        
      }
    }

  }
}
