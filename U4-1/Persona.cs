namespace U4_1
{
    public abstract class Persona
    {
        private string _apellido;

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}