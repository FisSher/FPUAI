using OtroNamespace;
using System;
using TPn2.Eventos;

namespace TPn2
{
    public class Alumno : Persona
    {

        //Delegado y ahora que hago con esto?
        //TODO
        public delegate void DelValidarNotaHandler(Alumno a, AluArgumentos e);

        public event DelValidarNotaHandler EventoValidar;
        
        private static readonly Random random = new Random();

        AluArgumentos e = new AluArgumentos();




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