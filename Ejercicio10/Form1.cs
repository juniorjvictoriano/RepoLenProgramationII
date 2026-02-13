namespace Ejercicio10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Hola, soy Junior y SD-2023-06077",
                "Mensaje",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
