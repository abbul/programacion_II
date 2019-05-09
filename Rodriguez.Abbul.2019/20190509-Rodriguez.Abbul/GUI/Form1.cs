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

namespace GUI
{
    public partial class Form1 : Form
    {

        public Maquina maquina;

        public Form1()
        {
            InitializeComponent();
            maquina = new Maquina("Abbul Rodriguez");
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

    private void richTextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {
      string marca = Convert.ToString(txtMarca.Text);
      string modelo = Convert.ToString(txtModelo.Text);
      int memoria = Convert.ToInt32(nudMemoria.Value);

      MessageBox.Show((maquina + new PlacaVideo(marca, modelo, memoria)));
      
    }

    private void btnSacar_Click(object sender, EventArgs e)
    {
      string marca = Convert.ToString(txtMarca.Text);
      string modelo = Convert.ToString(txtModelo.Text);
      int memoria = Convert.ToInt32(nudMemoria.Value);

      MessageBox.Show((maquina - new PlacaVideo(marca, modelo, memoria)));
     
    }

    private void btnSystemInfo_Click(object sender, EventArgs e)
    {
      rtxtSystemInfo.Text = " ";
      rtxtSystemInfo.Text = maquina.SystemInfo;
    }
  }
}
