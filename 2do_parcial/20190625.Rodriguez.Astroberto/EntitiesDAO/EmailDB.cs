using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Entities;

namespace Persistencia
{
  public class EmailDB
  {
    private readonly string connectionString;

    /// <summary>
    /// Asigna un valor al connectionString
    /// </summary>
    public EmailDB()
    {
      connectionString = "conexion";
    }

    public void Guardar (Emisor emisior)
    {

    }


  }
}
