using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.Threading;

namespace FormIndex
{
  public partial class Form1 : Form
  {
    public Index lista;

    public Form1()
    {
      InitializeComponent();
      lista = new Index();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      lista.Iniciar();
    }

    private void objetoTimer_Tick(object sender, EventArgs e)
    {
      int id=-1;
      int contador=0;

      foreach (Old item in lista.listaOld)
      {
        if (item.presionado == true) {  id =item.id; }
      }

      switch (id)
      {
        case 0:
          contador = Convert.ToInt32(txt1.Text);
          contador++;
          txt1.Text = Convert.ToString(contador);
          break;

        case 1:
          contador = Convert.ToInt32(txt2.Text);
          contador++;
          txt2.Text = Convert.ToString(contador);

          break;
        default:
          MessageBox.Show("ERROR;");
          Close();
          break;

      }
    }

    private void btn1_Click(object sender, EventArgs e)
    {
      bool flag = (lista[0].estado == true) ? false : true;
      lista[0].estado = flag;
      lista[0].presionado = true;

      lista[1].estado = false;
      lista[2].estado = false;
      lista[3].estado = false;
      lista[1].estado = false;
      lista[2].estado = false;
      lista[3].estado = false;
      objetoTimer.Start();

      //Thread t = new Thread();
    }

    private void btn2_Click(object sender, EventArgs e)
    {
      bool flag = (lista[1].estado == true) ? false : true;
      lista[1].estado = flag;
      lista[1].presionado = true;

      lista[0].estado = false;
      lista[2].estado = false;
      lista[3].estado = false;
      lista[0].estado = false;
      lista[2].estado = false;
      lista[3].estado = false;
      objetoTimer.Start();
    }
  }
}
