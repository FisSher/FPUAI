using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TP1
{
    public partial class FormTP1 : Form
    {
        public FormTP1()
        {
            InitializeComponent();
        }

        private List<Docente> listaDocentes = new List<Docente>();
        private List<Alumno> listaAlumno = new List<Alumno>();

        #region alta

        private void ButtonCargaDoc_Click(object sender, System.EventArgs e)
        {
            string pass = (Interaction.InputBox("Ingrese una contraseña para este usuario")).ToString();
            if (string.IsNullOrEmpty(textBoxCurso.Text) && string.IsNullOrEmpty(textBoxMateria.Text))
            {
                Docente docente = new Docente(textBoxNombre.Text, textBoxApellido.Text, pass);
                comboBoxUsuarios.Items.Add(docente.NombreUsuario);
                listaDocentes.Add(docente);
            }
            else
            {
                Docente docente = new Docente(textBoxNombre.Text, textBoxApellido.Text, pass, textBoxMateria.Text, Convert.ToInt32(textBoxCurso.Text));
                comboBoxUsuarios.Items.Add(docente.NombreUsuario);
                listaDocentes.Add(docente);
            }
        }

        private void ButtonCargaAlumno_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxContacto.Text) || string.IsNullOrEmpty(textBoxTel.Text))
            {
                MessageBox.Show("Se requiere nombre y telefono de contacto");
            }
            else
            {
                string pass = (Interaction.InputBox("Ingrese una contraseña para este usuario")).ToString();
                Alumno alumno = new Alumno(textBoxNombre.Text, textBoxApellido.Text, pass, textBoxContacto.Text, Convert.ToInt32(textBoxTel.Text));
                listaAlumno.Add(alumno);
                comboBoxUsuarios.Items.Add(alumno.NombreUsuario);
            }
        }

        #endregion alta

        #region modificar

        //Viene de la propia doc de microsoft.
        private void ButtonModificar_Click(object sender, EventArgs e)
        {
            var registro = comboBoxUsuarios.SelectedItem.ToString();
            if (radioButton1.Checked)
            {
                Alumno alumno = listaAlumno.Find(x => x.NombreUsuario.Contains(comboBoxUsuarios.SelectedItem.ToString()));
                alumno.Nombre = Interaction.InputBox("Escriba el nuevo nombre");
                alumno.Apellido = Interaction.InputBox("Escriba el nuevo apellido");
                alumno.ContactoEmergencia = Interaction.InputBox("Escriba el nuevo contacto de emergencia");
                alumno.TelEmergencia = Convert.ToInt32(Interaction.InputBox("Escriba el nuevo teléfono"));
            }
            else if (radioButton2.Checked)
            {
                Docente docente = listaDocentes.Find(x => x.NombreUsuario.Contains(comboBoxUsuarios.SelectedItem.ToString()));
                docente.Nombre = Interaction.InputBox("Escriba el nuevo nombre");
                docente.Apellido = Interaction.InputBox("Escriba el nuevo apellido");
                docente.Materia = Interaction.InputBox("Escriba la nueva materia");
            }
            else
            {
                MessageBox.Show("Necesita seleccionar si es docente o alumno");
            }
        }

        #endregion modificar

        #region eliminar

        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            int indexA = listaAlumno.FindIndex(x => x.NombreUsuario.Contains(comboBoxUsuarios.SelectedItem.ToString()));
            int indexB = listaDocentes.FindIndex(x => x.NombreUsuario.Contains(comboBoxUsuarios.SelectedItem.ToString()));
            if (indexA > -1)
            {
                listaAlumno.RemoveAt(indexA);
                comboBoxUsuarios.Items.Remove(comboBoxUsuarios.SelectedItem);
                comboBoxUsuarios.Text = "";
                MessageBox.Show("Eliminado.");
            }
            else if (indexB > -1)
            {
                listaDocentes.RemoveAt(indexB);
                comboBoxUsuarios.Items.Remove(comboBoxUsuarios.SelectedItem);
                comboBoxUsuarios.Text = "";
                MessageBox.Show("Eliminado.");
            }
            else
            {
                MessageBox.Show("No existe registro");
            }
        }

        #endregion eliminar
    }
}