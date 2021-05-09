namespace TP1
{
    public class Docente : Sistema.Usuario
    {
        public string Materia { get; set; }
        public readonly int Curso;

        #region Constructores

        public Docente( string _Nombre, string _Apellido, string _Pass,
            string _Materia, int _Curso)
        {
       
            Nombre = _Nombre;
            Apellido = _Apellido;
            NombreUsuario = CrearUsuario(_Nombre, _Apellido);
            Password = _Pass;
            Materia = _Materia;
            Curso = _Curso;
        }

        public Docente( string _Nombre, string _Apellido, string _Pass)
        {
         
            Nombre = _Nombre;
            Apellido = _Apellido;
            NombreUsuario = CrearUsuario(_Nombre, _Apellido);
            Password = _Pass;
        }

        #endregion Constructores

        public override string CrearUsuario(string nombre, string apellido)
        {
            return (nombre + "_" + apellido);
        }
    }
}