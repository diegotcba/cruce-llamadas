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
    }
}
