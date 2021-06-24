using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPn2.Clases;
using TPn2.Excepcion;
using TPn2.Interfaces;
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

        public List<Curso> LCursos = new List<Curso>();
        public List<Alumno> LAlumnos = new List<Alumno>();
        public List<Docente> LDocentes = new List<Docente>();

        public FormTP2()
        {
            InitializeComponent();
        }

        private void FormTP2_Load(object sender, EventArgs e)
        {
            comboBoxTipo.DataSource = Enum.GetValues(typeof(TipoUsuarios));
            LDocentes.Add(new Docente("Virginia", "Carr", 10));
            LDocentes.Add(new Docente("Esteban", "Pol", 10));
            LCursos.Add(new Curso("K1503"));
            LAlumnos.Add(new Alumno("Facundo", "Paolini", 5));
            LAlumnos.Add(new Alumno("Gaston", "Minion", 7));
            RefrescarListaAlumnos();
            RefrescarListaCursos();
            RefrescarListaDocentes();
        }

        #endregion Carga inicial

        /// <summary>
        /// Acá están todos los métodos para recargar listas
        /// </summary>

        #region Metodos refresh de listas

        private void RefrescarListaCursos()
        {
            listBoxCursos.DataSource = null;
            if (LCursos != null)
            {
                listBoxCursos.DataSource = LCursos;
            }
        }

        private void RefrescarListaAlumnos()
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

        private void RefrescarListaDocentes()
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
            if (string.IsNullOrEmpty(textBoxNombre.Text) && string.IsNullOrEmpty(textBoxApellido.Text))
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

        //TODO asignar
        /// <summary>
        /// Botón para asignar alumno a curso
        /// </summary>
        ///
        private void buttonAsignaCurso_Click(object sender, EventArgs e)
        {
        }

        //Boton Asigna docente a curso
        //Lo clono? estaría copado
        private void buttonAsignaDoc_Click(object sender, EventArgs e)
        {
            Curso curso = (Curso)listBoxCursos.SelectedItem;
            Docente docente = (Docente)dataGridViewDocentes.CurrentRow.DataBoundItem;
            curso.Docente = docente;


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