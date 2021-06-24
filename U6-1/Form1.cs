using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U6_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        Cliente cliente = new Cliente();

        private void Asignar_LibroDiario(string mensaje)
        {
            label1.Text += mensaje + "Libro diario";
        }
        private void Asignar_Balance(string mensaje)
        {
            label1.Text +=   mensaje + "Balance";
        }
        private void Asignar_Liquidacion(string mensaje)
        {
            label1.Text += mensaje + "Liquidacion";
        }
        private void Asignar_SueldosYJornales(string mensaje)
        {
            label1.Text +=  mensaje + "Sueldos y jornales";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            cliente.Anotar();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cliente.AnotarActividad += Asignar_LibroDiario;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cliente.AnotarActividad += Asignar_Balance;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cliente.AnotarActividad += Asignar_Liquidacion;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cliente.AnotarActividad += Asignar_SueldosYJornales;
        }
    }
}
