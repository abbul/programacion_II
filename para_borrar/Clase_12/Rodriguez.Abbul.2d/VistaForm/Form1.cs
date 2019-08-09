using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaForm
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void textBox4_TextChanged(object sender, EventArgs e)
    {

    }

    private void txtNombre_TextChanged(object sender, EventArgs e)
    {

    }

    private void btnCrear_Click(object sender, EventArgs e)
    {
      if ( txtNombre.Text.Count() > 2 && txtApellido.Text.Count() > 2 && Convert.ToInt32(txtEdad.Text) > 18 && txtDNI.Text.Count() > 5 && Convert.ToInt32(txtExperiencia.Text) >= 0  )
      {
        MessageBox.Show("CORRECTO");
      }
      else
      {
        MessageBox.Show("ERROR");
      }
    }
  }
}
