using OtroNamespace;
using System;

namespace TPn2
{
    public class Docente : Persona, IComparable<Docente>
    {
        public double Desempenio { get; set; }

        public override string ToString()
        {
            return CodigoUnico + " " + Nombre + " " + Apellido + " " + Desempenio;
        }

        public int CompareTo(Docente other)
        {
            if (other == null)
            {
                return 1;
            }
            else
            {
                Docente a = (Docente)other;
                return a.Desempenio.CompareTo(Desempenio);
            }
        }

        public Docente()
        {
        }

        public Docente(string nombre, string apellido, double desempenio)
        {
            Nombre = nombre;
            Apellido = apellido;
            Desempenio = desempenio;
            CodigoUnico = CrearCodUnico(nombre, apellido);
        }
    }
}