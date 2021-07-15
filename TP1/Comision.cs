using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class Comision
    {
        public int Numero { get; set; }
        //1 a muchos
        internal List<Alumno> ListaAlumnos = new List<Alumno>();

        //1 a 1
        public Docente Docente { get; set; }
    }
}
