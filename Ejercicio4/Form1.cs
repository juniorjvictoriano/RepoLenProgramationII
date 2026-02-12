namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int num1) &&
                int.TryParse(textBox2.Text, out int num2))
            {
                int suma = num1 + num2;
                label1.Text = $"Resultado: {suma}";
            }
            else
            {
                label1.Text = "Ingrese números válidos";
            }
        }
    }
}
