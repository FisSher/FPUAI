using Sistema;

namespace TP1
{
    public class Alumno : Usuario
    {
        /// <summary>
        /// Nombre de padre, madre o persona a cargo.
        /// </summary>
        public string ContactoEmergencia { get; set; }

        /// <summary>
        /// Teléfono de esa persona a cargo.
        /// </summary>
        public int TelEmergencia { get; set; }




        public Alumno(string _Nombre, string _Apellido, string _Pass,
                            string _ContactoEmergencia, int _TelEmergencia)
        {

            Nombre = _Nombre;
            Apellido = _Apellido;
            NombreUsuario = CrearUsuario(_Nombre, _Apellido);
            Password = _Pass;
            ContactoEmergencia = _ContactoEmergencia;
            TelEmergencia = _TelEmergencia;
        }

        public override string ToString()
        {
            return Nombre + Apellido + NombreUsuario + ContactoEmergencia + TelEmergencia;
        }


    }
}