namespace Ejercicio11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Fecha seleccionada: " +
                           dateTimePicker1.Value.ToShortDateString();
        }
    }
}
