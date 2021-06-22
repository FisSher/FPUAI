using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtroNamespace;

namespace TPn2
{
    public class Alumno:Persona
    {

        public double Promedio { get; set; }


        public override string ToString()
        {
            return CodigoUnico + " " + Nombre + " " + Apellido + " " + Promedio;
        }

        #region constructores
        
        public Alumno() { }

        public Alumno(string nombre, string apellido, double promedio)
        {
            Nombre = nombre;
            Apellido = apellido;
            Promedio = promedio;
            CodigoUnico = CrearCodUnico(nombre, apellido);

        }
        #endregion



    }
}
