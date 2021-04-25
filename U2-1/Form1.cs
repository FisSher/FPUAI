using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void instSimple_Click(object sender, EventArgs e)
        {
            Cuenta cuenta = new Cuenta();
            MessageBox.Show("Se instanció la cuenta en "+ cuenta.ToString());
            
        }

        private void InstParam_Click(object sender, EventArgs e)
        {
            if (textBoxCuenta.Text == "")
                MessageBox.Show("Se requiere un nombre de titular.");
            else
            {
                Cuenta cuenta = new Cuenta(nombreTitular: textBoxCuenta.Text);
                MessageBox.Show("Se instanció la cuenta "+ textBoxCuenta.Text +" en " + cuenta.ToString());
                labelCuenta.Text = textBoxCuenta.Text;
            }
        }

        private void InstOver_Click(object sender, EventArgs e)
        {
            if (textBoxCuenta.Text == "")
                MessageBox.Show("Se requiere un nombre de titular.");
            else if (textBoxCant.Text == "")
                MessageBox.Show("Se requiere una cantidad.");
            else {
                Cuenta cuenta = new Cuenta(nombreTitular: textBoxCuenta.Text, cantidadCuenta: double.Parse(textBoxCant.Text));
                labelCuenta.Text = textBoxCuenta.Text;
                labelCantidad.Text = textBoxCant.Text;
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCant_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            string tit = labelCuenta.Text;
            string cant = labelCantidad.Text;
            if (String.IsNullOrEmpty(tit) || String.IsNullOrEmpty(cant))
            {
                MessageBox.Show("Primero instanciar");
            }
            else
            {

                Cuenta cuenta = new Cuenta(labelCuenta.Text,double.Parse(labelCantidad.Text));
                labelCantidad.Text = cuenta.Ingresar(double.Parse(textBoxCant.Text)).ToString();
            }
            
        }

        private void buttonRetirar_Click(object sender, EventArgs e)
        {
            string tit = labelCuenta.Text;
            string cant = labelCantidad.Text;
            if (String.IsNullOrEmpty(tit) || String.IsNullOrEmpty(cant))
            {
                MessageBox.Show("Primero instanciar");
            }
            else
            {
                Cuenta cuenta = new Cuenta(labelCuenta.Text, double.Parse(labelCantidad.Text));
                labelCantidad.Text = cuenta.Retirar(double.Parse(textBoxCant.Text)).ToString();

            }
        }
    }
}
