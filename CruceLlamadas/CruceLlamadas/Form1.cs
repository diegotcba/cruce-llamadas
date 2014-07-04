using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CruceLlamadas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerOrigen_Click(object sender, EventArgs e)
        {
            tabCruceLlamadas.SelectTab(1);
        }

        private void btnVerDestino_Click(object sender, EventArgs e)
        {
            tabCruceLlamadas.SelectTab(2);
        }

        private void btnAnalizar_Click_1(object sender, EventArgs e)
        {
            tabCruceLlamadas.SelectTab(3);
        }

        private void btnArchivoOrigen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
                txtArchivoOrigen.Text = FileName;
           }
        }

        private void btnArchivoDestino_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
                txtArchivoDestino.Text = FileName;
            }
        }
    }
}
