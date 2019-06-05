using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
  public partial class FormModal : Form
  {
    private string type;

    public FormModal(string type)
    {
      InitializeComponent();
      this.type = type;
      Text = type;
    }

    private void FormModal_Load(object sender, EventArgs e)
    {
      openFile = new OpenFileDialog();

      openFile.ShowDialog();

      /*switch (type)
      {
        case "Abrir":
          break;
        case "Guardar":
          break;
        case "Guardar Como":
          break;

      }*/



    }
  }
}
