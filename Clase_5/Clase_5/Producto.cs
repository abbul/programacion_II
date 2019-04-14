using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_5
{
  public class Producto
  {
    string codigoDeBarra;
    string marca;
    float precio;

    public Producto(string codigoDeBarra, string marca, float precio)
    {
      this.codigoDeBarra = codigoDeBarra;
      this.marca = marca;
      this.precio = precio;
    }

    public string GetMarca()
    {
      return this.marca;
    }

    public float GetPrecio()
    {
      return this.precio;
    }

    public string MostrarProducto(Producto p)
    {

      return  "Marca:" + p.marca + "Precio:" + p.precio + "Codigo:" + p.codigoDeBarra;
    }

    public static explicit operator string(Producto p)
    {
      return p.codigoDeBarra;
    }

    public static bool operator ==(Producto a, Producto b)
    {
      if( !(a is null) && !(b is null))
      {
        return a.codigoDeBarra == b.codigoDeBarra ? true : false;
      }
      
    }

    public static bool operator ==(Producto a, string marca)
    {
      return a.GetMarca() == marca ? true : false;
    }

    public static bool operator !=(Producto a, Producto b)
    {
      return a.codigoDeBarra == b.codigoDeBarra ? true : false;
    }

    public static bool operator !=(Producto a, string marca)
    {
      return a.GetMarca() == marca ? true : false;
    }

  }
}
