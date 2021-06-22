using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtroNamespace;
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
            set { _codigoUnico = CrearCodUnico(Nombre,Apellido); }
        }


       

        

        public virtual string CrearCodUnico(string nombre, string apellido)
        {
            Random rndm = new Random();
            return nombre.Substring(0, 1) + apellido.Substring(0, 1) + rndm.Next(0,1000000).ToString();
        }
    }
}
