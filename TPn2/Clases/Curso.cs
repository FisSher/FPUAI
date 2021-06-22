using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPn2.Excepcion;

namespace TPn2.Clases
{
    public class Curso
    {
        //1 a muchos
        private List<Alumno> ListaAlumnos = new List<Alumno>();

        //1 a 1
        public Docente Docente { get; set; }

        private string _codigoCurso;

        public string CodigoCurso
        {
            get { return _codigoCurso; }
            set { _codigoCurso = value; }
        }

        public Curso(string codigo)
        {
            CodigoCurso = codigo;
        }

        public override string ToString()
        {
            return CodigoCurso;
        }
    }
}