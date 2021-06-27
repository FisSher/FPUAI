using OtroNamespace;

namespace TPn2
{
    public class Docente : Persona
    {
        public double Desempenio { get; set; }

        public override string ToString()
        {
            return CodigoUnico + " " + Nombre + " " + Apellido + " " + Desempenio;
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