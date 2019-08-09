using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_5
{
  public class Estante
  {
    private Producto[] productos;
    private int ubicacionEstante;

    private Estante(int capacidad)
    {
       this.productos = new Producto[capacidad];
    }

    public Estante(int capacidad, int ubicacion):this(capacidad)
    {
      this.ubicacionEstante = ubicacion;
    }

    public Producto[] GetProductos()
    {
      return this.productos;
    }

    public static string MostrarEstante(Estante e)
    {
      if(e!=null)
      {
        foreach (Producto row in e.productos)
        {
          return "Estante:" + e.ubicacionEstante + row.MostrarProducto(row);
        }
      }
     
      return "ERROR";
    }

    public static bool operator ==(Estante e, Producto p)
    {
      foreach(Producto uno in e.productos)
      {
        return  uno == p ? true : false;
      }

      return false; 
    }

    public static bool operator !=(Estante e, Producto p)
    {
      return !(e == p);
    }

    public static bool operator +(Estante e, Producto p)
    {
      int contador=0;

       if( e.ubicacionEstante > e.productos.Length )
      {
        foreach(Producto uno in e.productos )
        {
          contador++;
        }

        e.productos[contador] = p;
        e.ubicacionEstante++;
        return true;
      }

      return false;
      
    }
  }
}
