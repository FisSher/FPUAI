namespace U4_1
{
    public class Profesor : Iprofesor
    {
        string Iprofesor.Materia { get; set; }

        private string _materia;

        public string Materia
        {
            get { return _materia; }
            set { _materia = value; }
        }

        public Profesor()
        {
        }
    }
}