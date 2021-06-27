using System;
using System.Collections.Generic;
using System.Linq;
using TPn2.Interfaces;

namespace TPn2.Clases
{
    public class Curso : IPromediable
    {
        //1 a muchos
        public List<Alumno> ListaAlumnos { get; set; }

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
            ListaAlumnos = new List<Alumno>();
        }

        public override string ToString()
        {
            return CodigoCurso;
        }

        //Aplico interfaz custom
        double IPromediable.CalcularPromedio(List<Alumno> lista)
        {
            if (lista != null)
            {
                double suma = 0;
                foreach (Alumno alumno in lista)
                {
                    suma += alumno.Promedio;
                }
                int totalElementos = lista.Count();
                return suma / totalElementos;
            }
            else
                return 0;
        }

        //Aplico interfaz integrada (creo que no tengo idea de que estoy haciendo acá a las 4:32 am que hice esto)
        public class OrdenarPorPromedio : IComparer<Alumno>
        {
            public int Compare(Alumno x, Alumno y)
            {
                if (x == null || y == null)
                    throw new ArgumentNullException();
                else
                    return x.Promedio.CompareTo(y.Promedio);
            }
        }

        public class OrdenarPorNombre : IComparer<Alumno>
        {
            public int Compare(Alumno x, Alumno y)
            {
                if (x == null && y == null)
                    throw new ArgumentNullException();
                else
                    return string.Compare(x.Nombre, y.Nombre);
            }
        }
    }
}