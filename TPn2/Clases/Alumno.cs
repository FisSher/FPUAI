using OtroNamespace;
using System;

namespace TPn2
{
    public class Alumno : Persona
    {
        private static readonly Random random = new Random();

        public double Promedio { get; set; }

        public override string ToString()
        {
            return CodigoUnico + " " + Nombre + " " + Apellido + " " + Promedio;
        }

        #region constructores

        public Alumno()
        {
        }

        //Este constructor es para facilitar datos random
        public Alumno(string nombre, string apellido, bool automatico)
        {
            Nombre = nombre;
            Apellido = apellido;
            CodigoUnico = CrearCodUnico(nombre, apellido);
            Promedio = random.Next(1, 10);
        }

        public Alumno(string nombre, string apellido, double promedio)
        {
            Nombre = nombre;
            Apellido = apellido;
            CodigoUnico = CrearCodUnico(nombre, apellido);
            Promedio = promedio;
        }

        #endregion constructores
    }
}