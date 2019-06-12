using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Vista
{
  public partial class Form1 : Form
  {
    public Thread hilo;

    public Form1()
    {
      InitializeComponent();
      hilo = new Thread(Practica3);
    }

    public bool Practica1()
    {
      DateTime hora = DateTime.Now;
      lbl1.Text = Convert.ToString(hora);
      return true;
    }

    public void Practica2()
    {
      tiempo.Start();
    }

    public void Practica3()
    {

      if (lbl1.InvokeRequired)
      {
        this.lbl1.BeginInvoke
        (
          (MethodInvoker)delegate(){
            DateTime hora = DateTime.Now;
            lbl3.Text = Convert.ToString(hora);
          }
        );
      }
      else{
        DateTime hora = DateTime.Now;
        lbl3.Text = Convert.ToString(hora);
      }
    }

    private void tiempo_Tick(object sender, EventArgs e)
    {
      DateTime hora = DateTime.Now;
      lbl2.Text = Convert.ToString(hora);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      bool variable = Practica1();

      do
      {
        Practica1();

      } while (variable);

    }

    private void button2_Click(object sender, EventArgs e)
    {
      Practica2();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      hilo.Start();

      if (true)
      {

      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      
    }
  }
}
