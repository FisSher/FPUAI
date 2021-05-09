using System;

namespace U2_2
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        private int DNI { get; set; }
        public char Sexo { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }

        public Persona()
        {
            Nombre = "";
            Edad = 0;
            Sexo = 'H';
            DNI = GeneraDNI();
            Peso = 0;
            Altura = 0;
        }

        public Persona(string nombre, int edad, char sexo)
        {
            Nombre = nombre;
            Edad = edad;
            Sexo = sexo;
            DNI = GeneraDNI();
            Peso = 0;
            Altura = 0;
        }

        public Persona(string nombre, int edad, char sexo, double peso, double altura)
        {
            Nombre = nombre;
            Edad = edad;
            Sexo = sexo;
            DNI = GeneraDNI();
            Peso = peso;
            Altura = altura;
        }

        public int CalcularIMC(double peso, double altura)
        {
            int respuesta = -2;
            double calculo = peso / (altura * altura);
            if (calculo < 20)
                respuesta = -1;
            else if ((calculo <= 20) && (calculo <= 25))
                respuesta = 0;
            else if (calculo > 25)
                respuesta = 1;

            return respuesta;
        }

        public bool EsMayorDeEdad(int edad)
        {
            bool respuesta = false;
            if (edad >= 18)
                respuesta = true;
            return respuesta;
        }

        public bool ComprobarSexo(char sexo)
        {
            bool respuesta = false;
            if ((sexo == 'M') || (sexo == 'H'))
                respuesta = true;
            return respuesta;
        }

        public Persona ValorObjeto()
        {
            Persona persona = new Persona();
            persona.DNI = persona.DNI;
            persona.Altura = Altura;
            persona.Edad = Edad;
            persona.Sexo = Sexo;
            persona.Nombre = Nombre;
            persona.Peso = Peso;
            return persona;
        }

        private int GeneraDNI()
        {
            var rand = new Random();
            return rand.Next(10000000, 99999999);
        }
    }
}