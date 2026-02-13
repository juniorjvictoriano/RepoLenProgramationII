namespace Ejercicio16
{
    public partial class Form1 : Form
    {
        double valor1 = 0;
        string operacion = "";
        bool nuevaEntrada = true;

        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
        }

        // ===== MÉTODOS AUXILIARES =====

        private void AgregarNumero(string numero)
        {
            if (nuevaEntrada)
            {
                textBox1.Text = "";
                nuevaEntrada = false;
            }

            textBox1.Text += numero;
        }

        private void SetOperacion(string op)
        {
            valor1 = double.Parse(textBox1.Text);
            operacion = op;
            nuevaEntrada = true;
        }

        // ===== BOTONES NUMÉRICOS =====

        private void button1_Click(object sender, EventArgs e) { AgregarNumero("1"); }
        private void button2_Click(object sender, EventArgs e) { AgregarNumero("2"); }
        private void button3_Click(object sender, EventArgs e) { AgregarNumero("3"); }
        private void button4_Click(object sender, EventArgs e) { AgregarNumero("4"); }
        private void button5_Click(object sender, EventArgs e) { AgregarNumero("5"); }
        private void button6_Click(object sender, EventArgs e) { AgregarNumero("6"); }
        private void button7_Click(object sender, EventArgs e) { AgregarNumero("7"); }
        private void button8_Click(object sender, EventArgs e) { AgregarNumero("8"); }
        private void button9_Click(object sender, EventArgs e) { AgregarNumero("9"); }
        private void button10_Click(object sender, EventArgs e) { AgregarNumero("0"); }

        // ===== PUNTO DECIMAL =====

        private void button12_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += ".";
                nuevaEntrada = false;
            }
        }

        // ===== OPERACIONES =====

        private void button16_Click(object sender, EventArgs e) { SetOperacion("+"); }
        private void button17_Click(object sender, EventArgs e) { SetOperacion("-"); }
        private void button18_Click(object sender, EventArgs e) { SetOperacion("*"); }
        private void button19_Click(object sender, EventArgs e) { SetOperacion("/"); }

        // ===== IGUAL =====

        private void button15_Click(object sender, EventArgs e)
        {
            double valor2 = double.Parse(textBox1.Text);
            double resultado = 0;

            switch (operacion)
            {
                case "+":
                    resultado = valor1 + valor2;
                    break;
                case "-":
                    resultado = valor1 - valor2;
                    break;
                case "*":
                    resultado = valor1 * valor2;
                    break;
                case "/":
                    if (valor2 == 0)
                    {
                        MessageBox.Show("No se puede dividir entre cero");
                        return;
                    }
                    resultado = valor1 / valor2;
                    break;
            }

            textBox1.Text = resultado.ToString();
            nuevaEntrada = true;
        }

        // ===== AC / LIMPIAR =====

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            valor1 = 0;
            operacion = "";
            nuevaEntrada = true;
        }
    }
}
