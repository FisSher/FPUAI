namespace Sistema
{
    public abstract class Usuario
    {
        #region Propiedades

        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string NombreUsuario;

        private string _password;

        public string Password
        {
            set
            {
                _password = value;
            }
        }

        #endregion Propiedades

        public virtual string CrearUsuario(string nombre, string apellido)
        {
            return nombre + "." + apellido;
        }
    }
}