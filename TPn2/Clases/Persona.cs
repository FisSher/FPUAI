using System;
using TPn2.Clases;

namespace OtroNamespace
{
    public class Persona
    {
        private string _codigoUnico;
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Curso curso { get; set; }

        public string CodigoUnico
        {
            get { return _codigoUnico; }
            set
            {
                if (string.IsNullOrEmpty(Nombre) || string.IsNullOrEmpty(Apellido))
                {
                    _codigoUnico = value;
                }
                else
                {
                    _codigoUnico = CrearCodUnico(Nombre, Apellido);
                }
            }
        }

        public virtual string CrearCodUnico(string nombre, string apellido)
        {
            Random rndm = new Random();
            return nombre.ToLower().Substring(0, 1) + apellido.ToLower().Substring(0, 1) + rndm.Next(0, 100).ToString();
        }
    }
}