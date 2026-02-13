namespace Ejercicio7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(texto))
            {
                listBox1.Items.Add(texto);
                textBox1.Clear();
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show(
                    "Ingrese un valor válido",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }
    }
}
