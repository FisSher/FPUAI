using System;
using System.Windows.Forms;
using TPn2.Clases;
using TPn2.Interfaces;
using static TPn2.FormTP2;

namespace TPn2
{
    public partial class Informes : Form
    {
        public Informes()
        {
            InitializeComponent();
        }

        //DELEGADO
        private delegate void Ordenar();

        private void Informes_Load(object sender, EventArgs e)
        {
            comboBoxRend.DataSource = Enum.GetValues(typeof(TipoUsuarios));
            if (LCursos != null)
                listBoxCursos.DataSource = LCursos;
        }

        internal void RefrescarListaAlumnosEnCurso()
        {
            dataGridViewPersonasEnCurso.ClearSelection();
            Curso curso = (Curso)listBoxCursos.SelectedItem;
            dataGridViewPersonasEnCurso.DataSource = null;
            dataGridViewPersonasEnCurso.DataSource = curso.ListaAlumnos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Curso curso = (Curso)listBoxCursos.SelectedItem;
                Alumno alumno = (Alumno)dataGridViewPersonasEnCurso.CurrentRow.DataBoundItem;
                LAlumnos.Add(alumno);
                foreach (Alumno a in curso.ListaAlumnos)
                {
                    if (a.CodigoUnico == alumno.CodigoUnico)
                    {
                        curso.ListaAlumnos.Remove(alumno);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            RefrescarListaAlumnosEnCurso();
        }

        private void listBoxCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Curso curso = (Curso)listBoxCursos.SelectedItem;
            dataGridViewPersonasEnCurso.DataSource = null;
            dataGridViewPersonasEnCurso.DataSource = curso.ListaAlumnos;
            if (curso.Docente!=null)
            {
                labelDocenteCurso.Text = curso.Docente.Nombre + " " + curso.Docente.Apellido;
            }
            if (curso.ListaAlumnos.Count>0)
            {
                IPromediable ipromediable = curso;
                double promedio = ipromediable.CalcularPromedio(curso.ListaAlumnos);
                labelPromCurso.Text = promedio.ToString();
            }
            if (curso.ListaAlumnos.Count>0)
            {
                labelTotPersonas.Text = curso.ListaAlumnos.Count.ToString();
            }
            


        }

        private void buttonMejorRendimiento_Click(object sender, EventArgs e)
        {
            try
            {
                Curso curso = (Curso)listBoxCursos.SelectedItem;

                if (comboBoxRend.SelectedIndex == 0 && curso.ListaAlumnos != null)
                {
                    Ordenar ordenar = new Ordenar(curso.ListaAlumnos.Sort);
                    ordenar.Invoke();
                    dataGridViewRendimientos.DataSource = null;
                    dataGridViewRendimientos.DataSource = curso.ListaAlumnos;
                }
                else if (LDocentes.Count > 0)
                {
                    Ordenar ordenar = new Ordenar(LDocentes.Sort);
                    ordenar.Invoke();
                    dataGridViewRendimientos.DataSource = null;
                    dataGridViewRendimientos.DataSource = LDocentes;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}