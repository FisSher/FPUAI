using System;
using System.Windows.Forms;

namespace U5_0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Calculadora oCalculadora = new Calculadora();

        public void CalcularSuma(int num1, int num2)
        {
            label1.Text = (num1 + num2).ToString();
        }

        public void CalcularMult(int num1, int num2)
        {
            label1.Text = (num1 * num2).ToString();
        }

        public void CalcularResta(int num1, int num2)
        {
            label1.Text = (num1 - num2).ToString();
        }

        public void CalcularDiv(int num1, int num2)
        {
            label1.Text = (num1 / num2).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oCalculadora.calcular = CalcularSuma;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oCalculadora.calcular = CalcularMult;
        }

        // Botón calcular
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = Convert.ToInt32(textBox1.Text);
                int num2 = Convert.ToInt32(textBox2.Text);
                oCalculadora.calcular(num1, num2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            oCalculadora.calcular = CalcularResta;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            oCalculadora.calcular = CalcularDiv;
        }
    }
}