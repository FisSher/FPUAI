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

        private List<Curso> LCursos = new List<Curso>();
        private List<Alumno> LAlumnos = new List<Alumno>();
        private List<Docente> LDocentes = new List<Docente>();

        public FormTP2()
        {
            InitializeComponent();
        }

        private void FormTP2_Load(object sender, EventArgs e)
        {
            comboBoxTipo.DataSource = Enum.GetValues(typeof(TipoUsuarios));
            comboBoxRend.DataSource = Enum.GetValues(typeof(TipoUsuarios));
        }

        #endregion Carga inicial


        /// <summary>
        /// Acá están todos los métodos para recargar listas
        /// </summary>
        #region Metodos refresh de listas

        private void RefrescarListaCursos()
        {
            listBoxCursos.DataSource = null;
            listBoxCursos.DataSource = LCursos;
        }

        private void RefrescarListaAlumnos()
        {
            dataGridViewAlumnos.DataSource = null;
            dataGridViewAlumnos.DataSource = LAlumnos;
        }
        private void RefrescarListaDocentes()
        {
            dataGridViewDocentes.DataSource = null;
            dataGridViewDocentes.DataSource = LDocentes;
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

        private void buttonCargaCurso_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCargaCurso.Text))
            {
                MessageBox.Show("Debe completar el curso");
            }
            else
            {
                try
                {
                    Curso curso = new Curso(textBoxCargaCurso.Text);
                    LCursos.Add(curso);
                    RefrescarListaCursos();
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
        /// Botón para asignar alumno o docente a curso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAsignaCurso_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewDocentes.CurrentCell = null;
        }

        private void dataGridViewDocentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewAlumnos.CurrentCell = null;
        }
    }
}