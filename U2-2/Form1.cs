using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace U2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_instanciar_Click(object sender, EventArgs e)
        {
            Persona persona1 = new Persona(textBoxNombre.Text, int.Parse(textBoxEdad.Text), char.Parse(textBoxSexo.Text), double.Parse(textBoxPeso.Text), double.Parse(textBoxAltura.Text));
            Persona persona2 = new Persona(textBoxNombre.Text, int.Parse(textBoxEdad.Text), char.Parse(textBoxSexo.Text));
            Persona persona3 = new Persona();
            persona3.Nombre = "Virginia";
            persona3.Sexo = 'M';
            persona3.Peso = 50;
            persona3.Altura = 150;
            persona3.Edad = 25;

            List<Persona> personas = new List<Persona>();
            personas.Add(persona1);
            personas.Add(persona2);
            personas.Add(persona3);
            foreach (Persona persona in personas)
            {
                int peso = persona.CalcularIMC(persona.Peso, persona.Altura);

                switch (peso)
                {
                    case -1:
                        textBoxRes.AppendText(persona.Nombre + " tiene un IMC menor a 0 \r\n");
                        break;

                    case 0:
                        textBoxRes.AppendText(persona.Nombre + " está debajo de su peso ideal\r\n ");
                        break;

                    case 1:
                        textBoxRes.AppendText(persona.Nombre + " tiene sobrepeso\r\n");
                        break;

                    default:
                        textBoxRes.AppendText(persona.Nombre + " Hubo error de cálculo\r\n");
                        break;
                }

                if (persona.EsMayorDeEdad(persona.Edad))
                    textBoxRes.AppendText(persona.Nombre + " es mayor de edad\r\n ");
                else
                    textBoxRes.AppendText(persona.Nombre + " no es mayor de edad\r\n ");

                Persona objeto = persona.ValorObjeto();
                textBoxRes.AppendText(objeto.Nombre + "\r\n");
                textBoxRes.AppendText(objeto.Edad + "\r\n");
                textBoxRes.AppendText(objeto.Sexo + "\r\n");
                textBoxRes.AppendText(objeto.Altura + "\r\n");
                textBoxRes.AppendText(objeto.Peso + "\r\n");
            }
        }

        private void textBoxRes_TextChanged(object sender, EventArgs e)
        {
        }
    }
}