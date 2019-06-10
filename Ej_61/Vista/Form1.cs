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

namespace Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLeer_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();

            List<Persona> collection= PersonaDAO.Leer();
            int contador = 0;

            if (collection != null && collection.Count > 0)
            {
                foreach (var item in collection)
                {
                    dataGridView.Rows.Insert(contador, item.Id, item.Nombre, item.Apellido);
                    contador++;
                }
            }
            else
            {
                MessageBox.Show("Sin Resultados Encontrados");
            }
        }
    }
}
