using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TPn2.Clases;
using TPn2.Eventos;
using TPn2.Excepcion;

namespace TPn2
{
    public partial class FormTP2 : Form
    {
        public enum TipoUsuarios
        {
            Alumno = 1,
            Docente = 2
        }

        #region Carga inicial

        internal static List<Curso> LCursos = new List<Curso>();
        internal static List<Alumno> LAlumnos = new List<Alumno>();
        internal static List<Docente> LDocentes = new List<Docente>();

        public FormTP2()
        {
            InitializeComponent();
        }

        private void FormTP2_Load(object sender, EventArgs e)
        {

            comboBoxTipo.DataSource = Enum.GetValues(typeof(TipoUsuarios));
            if (LDocentes.Count == 0)
            {
                LDocentes.Add(new Docente("Virginia", "Carr", 10));
                LDocentes.Add(new Docente("Esteban", "Pol", 10));
            }
            if (LCursos.Count == 0)
                LCursos.Add(new Curso("K1503"));

            if (LAlumnos.Count == 0)
            {
                LAlumnos.Add(new Alumno("Facundo", "Paolini", true));
                LAlumnos.Add(new Alumno("Gaston", "Minion", true));
            }

            RefrescarListaAlumnos();
            RefrescarListaCursos();
            RefrescarListaDocentes();
        }

        #endregion Carga inicial

        /// <summary>
        /// Acá están todos los métodos para recargar listas
        /// </summary>

        #region Metodos refresh de listas

        internal void RefrescarListaCursos()
        {
            listBoxCursos.DataSource = null;
            if (LCursos != null)
            {
                listBoxCursos.DataSource = LCursos;
            }
        }

        internal void RefrescarListaAlumnos()
        {
            dataGridViewAlumnos.ClearSelection();
            dataGridViewAlumnos.DataSource = null;
            dataGridViewAlumnos.Refresh();
            if (LAlumnos != null)
            {
                dataGridViewAlumnos.DataSource = LAlumnos;
                dataGridViewAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
        }

        internal void RefrescarListaDocentes()
        {
            dataGridViewAlumnos.ClearSelection();
            dataGridViewDocentes.DataSource = null;
            dataGridViewAlumnos.Refresh();
            if (LDocentes != null)
            {
                dataGridViewDocentes.DataSource = LDocentes;
                dataGridViewDocentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
        }

        #endregion Metodos refresh de listas

        //Mostrar/Ocultar desempeño o promedio
        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTipo.Text == "Alumno")
            {
                label6.Visible = true;
                textBoxPromedio.Visible = true;
                label7.Visible = false;
                textBoxDesemp.Visible = false;
            }
            else if (comboBoxTipo.Text == "Docente")
            {
                label7.Visible = true;
                textBoxDesemp.Visible = true;
                label6.Visible = false;
                textBoxPromedio.Visible = false;
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        /// <summary>
        /// Acá están todos los botones donde se cargan objetos a listas
        /// </summary>

        #region Carga de

        private void buttonCargaPersona_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNombre.Text))
            {
                MessageBox.Show("Debe completar nombre y apellido");
            }
            else
            {
                if (comboBoxTipo.SelectedIndex == 0)
                {
                    try
                    {
                        Alumno alumno = new Alumno(
                            textBoxNombre.Text,
                            textBoxApellido.Text,
                            Convert.ToDouble(textBoxPromedio.Text)
                        );

                        LAlumnos.Add(alumno);
                        RefrescarListaAlumnos();
                        dataGridViewAlumnos.CurrentCell = null;
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("El formato del promedio debe ser numérico");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        Docente docente = new Docente(
                            textBoxNombre.Text,
                            textBoxApellido.Text,
                            Convert.ToDouble(textBoxDesemp.Text)
                            );
                        LDocentes.Add(docente);
                        RefrescarListaDocentes();
                        dataGridViewDocentes.CurrentCell = null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        //Botón que carga los cursos, tiene la excepción custom adentro.
        private void buttonCargaCurso_Click(object sender, EventArgs e)
        {
            bool found = false;
            if (string.IsNullOrEmpty(textBoxCargaCurso.Text))
            {
                MessageBox.Show("Debe completar el curso");
            }
            else
            {
                try
                {
                    Curso curso = new Curso(textBoxCargaCurso.Text);
                    foreach (Curso c in LCursos)
                    {
                        if (c.CodigoCurso == curso.CodigoCurso)
                        {
                            found = true;
                            throw new CursoExistenteException();
                        }
                    }
                    if (!found)
                    {
                        LCursos.Add(curso);
                        RefrescarListaCursos();
                    }
                }
                catch (CursoExistenteException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        #endregion Carga de

   

       
        // Botón para asignar alumno a curso      
        private void buttonAsignaCurso_Click(object sender, EventArgs e)
        {
            

            try
            {

                Curso curso = (Curso)listBoxCursos.SelectedItem;
                Alumno alumno = (Alumno)dataGridViewAlumnos.CurrentRow.DataBoundItem;
                alumno.EventoValidar += Alumno_EventoValidar;
                curso.ListaAlumnos.Add(alumno);
                foreach (Alumno a in LAlumnos)
                {
                    if (a.CodigoUnico == alumno.CodigoUnico)
                    {
                        LAlumnos.Remove(alumno);
                        break;
                    }
                }
                alumno.EventoValidar -= Alumno_EventoValidar;

                RefrescarListaAlumnos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            RefrescarListaAlumnos();
        }

        private void Alumno_EventoValidar(Alumno a, AluArgumentos e)
        {
            if (a.Promedio<=4)
            {
                MessageBox.Show("Promedio menor a 4");
            }
        }





        //Boton Asigna docente a curso
        private void buttonAsignaDoc_Click(object sender, EventArgs e)
        {
            //Si el curso no tiene docente, lo asigna. Si ya tiene, lo intercambia.
            try
            {
                Curso curso = (Curso)listBoxCursos.SelectedItem;
                if (curso.Docente == null)
                {
                    Docente docente = (Docente)dataGridViewDocentes.CurrentRow.DataBoundItem;
                    curso.Docente = docente;
                    foreach (Docente d in LDocentes)
                    {
                        if (d.CodigoUnico == docente.CodigoUnico)
                        {
                            LDocentes.Remove(docente);
                            break;
                        }
                    }
                }
                else
                {
                    //traigo el viejo y lo asigno a la lista general
                    Curso cursoViejo = (Curso)listBoxCursos.SelectedItem;
                    Docente docenteViejo = cursoViejo.Docente;
                    LDocentes.Add(docenteViejo);

                    //Saco de la lista general y lo llevo al curso
                    Docente docente = (Docente)dataGridViewDocentes.CurrentRow.DataBoundItem;
                    curso.Docente = docente;
                    foreach (Docente d in LDocentes)
                    {
                        if (d.CodigoUnico == docente.CodigoUnico)
                        {
                            LDocentes.Remove(docente);
                            break;
                        }
                    }
                }

                RefrescarListaDocentes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewDocentes.ClearSelection();
            dataGridViewDocentes.CurrentCell.Selected = false;
        }

        private void dataGridViewDocentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewAlumnos.ClearSelection();
            dataGridViewAlumnos.CurrentCell.Selected = false;
        }

        //El botón modifica promedio, desempeño
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            bool found = false;
            if (string.IsNullOrEmpty(textBoxCodModificar.Text))
            {
                MessageBox.Show("Completar el código a modificar");
            }
            else
            {
                if (comboBoxTipo.SelectedIndex == 0)
                {
                    if (string.IsNullOrEmpty(textBoxPromedio.Text))
                    {
                        MessageBox.Show("Debe completar promedio");
                    }
                    else
                    {
                        try
                        {
                            Alumno alumno = new Alumno();
                            alumno.CodigoUnico = textBoxCodModificar.Text;
                            alumno.Promedio = Convert.ToDouble(textBoxPromedio.Text);

                            foreach (Alumno a in LAlumnos)
                            {
                                if (a.CodigoUnico == alumno.CodigoUnico)
                                {
                                    found = true;
                                    a.Promedio = alumno.Promedio;
                                    break;
                                }
                            }
                            if (found)
                            {
                                RefrescarListaAlumnos();
                                MessageBox.Show("Modificado");
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el alumno buscado");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else
                {
                    try
                    {
                        Docente docente = new Docente();
                        docente.CodigoUnico = textBoxCodModificar.Text;
                        docente.Desempenio = Convert.ToDouble(textBoxDesemp.Text);

                        foreach (Docente a in LDocentes)
                        {
                            if (a.CodigoUnico == docente.CodigoUnico)
                            {
                                found = true;
                                a.Desempenio = docente.Desempenio;
                                break;
                            }
                        }
                        if (found)
                        {
                            RefrescarListaDocentes();
                            MessageBox.Show("Modificado.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el docente buscado");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        #region radiobuttons

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            buttonCargaPersona.Visible = true;
            buttonModificar.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            buttonCargaPersona.Visible = false;
            buttonModificar.Visible = true;
        }

        #endregion radiobuttons

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            bool found = false;
            string codigoBuscado = textBoxCodModificar.Text;
            if (string.IsNullOrEmpty(textBoxCodModificar.Text))
            {
                MessageBox.Show("Completar el código en el campo");
            }
            else
            {
                try
                {
                    foreach (Alumno alumno in LAlumnos)
                    {
                        if (alumno.CodigoUnico == codigoBuscado)
                        {
                            LAlumnos.Remove(alumno);
                            found = true;
                            RefrescarListaAlumnos();
                            break;
                        }
                    }
                    foreach (Docente item in LDocentes)
                    {
                        if (item.CodigoUnico == codigoBuscado)
                        {
                            LDocentes.Remove(item);
                            found = true;
                            RefrescarListaDocentes();
                            break;
                        }
                    }
                    if (found)
                        MessageBox.Show("Eliminado correctamente");
                    else
                        MessageBox.Show("No se ha encontrado el código solicitado.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonEliminarCurso_Click(object sender, EventArgs e)
        {
            try
            {
                Curso curso = (Curso)listBoxCursos.SelectedItem;
                foreach (Curso c in LCursos)
                {
                    if (c.CodigoCurso == curso.CodigoCurso)
                    {
                        LCursos.Remove(curso);
                        MessageBox.Show("Eliminado.");
                        RefrescarListaCursos();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}