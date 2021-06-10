namespace U4_1
{
    public class Ayudante : Alumno, Iprofesor
    {
        public string Materia { get; set; }

        private string _materia;

        public Ayudante()
        {
        }

        public Ayudante(string materia)
        {
            Materia = materia;
        }
    }
}