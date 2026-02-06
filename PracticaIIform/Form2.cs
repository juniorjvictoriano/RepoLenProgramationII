using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaIIform
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cambiar el texto de label1 al hacer clic en el botón
            label1.Text = "Texto cambiado";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
