using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MisClases;

namespace EjercicioGuia_33
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnBuscar_Click(object sender, EventArgs e)
    {
      Libro libro = new Libro();

      int buffer;

      int.TryParse(txtBuscar.Text, out buffer);

      lblPagina.Text = libro[buffer].ToString();

    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {

    }

    private void txtBuscar_Click(object sender, EventArgs e)
    {

    }

    private void txtAgregar_Click(object sender, EventArgs e)
    {

    }

  }
}
