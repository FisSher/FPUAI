using OtroNamespace;
using System;
using TPn2.Eventos;

namespace TPn2
{
    public class Alumno : Persona, IComparable<Alumno>
    {
        public event EventHandler<AluArgumentos> ChequeaPromedio;

        private AluArgumentos argumento = new AluArgumentos();

        public double Promedio { get; set; }

        public override string ToString()
        {
            return CodigoUnico + " " + Nombre + " " + Apellido + " " + Promedio;
        }

        //No hace falta pasarle parámetros ya que el método está dentro de la misma clase
        public double ValidaPromedio()
        {
            if (this.ChequeaPromedio != null && Promedio <= 4)
            {
                argumento.AlumnosBajoPromedio += 1;
            }

            ChequeaPromedio(this, argumento);

            return argumento.AlumnosBajoPromedio;
        }

        public int CompareTo(Alumno other)
        {
            if (other == null)
            {
                return 1;
            }
            else
            {
                Alumno a = (Alumno)other;
                return a.Promedio.CompareTo(Promedio);
            }
        }

        private static readonly Random random = new Random();

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