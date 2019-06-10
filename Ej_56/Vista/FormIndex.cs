using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Vista
{

  public partial class FormIndex : Form
  {
    public ContextMenuStrip asd;

    public FormIndex()
    {
      InitializeComponent();
       asd = new ContextMenuStrip();
    }

    private void btnAbrir_Click(object sender, EventArgs e)
    {
      openFile = new OpenFileDialog();
      openFile.Filter = "Text files (*.txt)|*.txt";
      openFile.Title = "Abrir";
      string contenido;

      if (openFile.ShowDialog() == DialogResult.OK)
      {
        try
        {
          StreamReader file = new StreamReader(openFile.FileName);

          while(collection)
          {
            contenido = file.ReadLine();
            MessageBox.Show(contenido);
          }

          

          file.Close();

        }
        catch (Exception ex)
        {
          MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
        }
      }


    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      saveFile = new SaveFileDialog();

      openFile.FileName = "Select a text file";
      openFile.Filter = "Text files (*.txt)|*.txt";
      openFile.Title = "Abrir";

      saveFile.ShowDialog();

      if (saveFile.ShowDialog() == DialogResult.OK)
      {
        try
        {
          string filePath = saveFile.FileName;
          MessageBox.Show("RUTA: {0}",filePath);
        }
        catch (Exception ex)
        {
          MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n"+$"Details:\n\n{ex.StackTrace}");
        }
      }


    }

    private void btnGuardarComo_Click(object sender, EventArgs e)
    {
      saveFile = new SaveFileDialog();

      openFile.FileName = "Select a text file";
      openFile.Filter = "Text files (*.txt)|*.txt";
      openFile.Title = "Abrir"; 

      saveFile.ShowDialog();
    }

    private void openFile_FileOk(object sender, CancelEventArgs e)
    {
      MessageBox.Show("sdfdsfsd");
    }
  }
}
