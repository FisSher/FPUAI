namespace U4_1
{
    public class Alumno : Persona
    {
        private int _legajo;

        public int Legajo
        {
            get { return _legajo; }
            set { _legajo = value; }
        }

        public Alumno()
        {
        }

        public Alumno(int legajo)
        {
            Legajo = legajo;
        }
    }
}