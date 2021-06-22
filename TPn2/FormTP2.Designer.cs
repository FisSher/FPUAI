
namespace TPn2
{
    partial class FormTP2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.buttonCargaPersona = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPromedio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDesemp = new System.Windows.Forms.TextBox();
            this.listBoxCursos = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelDocenteCurso = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxRend = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.labelTotPersonas = new System.Windows.Forms.Label();
            this.labelTotCursos = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonAsignaAlumn = new System.Windows.Forms.Button();
            this.buttonMejorRendimiento = new System.Windows.Forms.Button();
            this.textBoxCargaCurso = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonCargaCurso = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridViewAlumnos = new System.Windows.Forms.DataGridView();
            this.dataGridViewDocentes = new System.Windows.Forms.DataGridView();
            this.buttonAsignaDoc = new System.Windows.Forms.Button();
            this.dataGridViewRendimientos = new System.Windows.Forms.DataGridView();
            this.dataGridViewPersonasEnCurso = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRendimientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonasEnCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(596, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista cursos";
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Location = new System.Drawing.Point(12, 22);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipo.TabIndex = 1;
            this.comboBoxTipo.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipo_SelectedIndexChanged);
            // 
            // buttonCargaPersona
            // 
            this.buttonCargaPersona.Location = new System.Drawing.Point(240, 14);
            this.buttonCargaPersona.Name = "buttonCargaPersona";
            this.buttonCargaPersona.Size = new System.Drawing.Size(120, 37);
            this.buttonCargaPersona.TabIndex = 2;
            this.buttonCargaPersona.Text = "Cargar Persona";
            this.buttonCargaPersona.UseVisualStyleBackColor = true;
            this.buttonCargaPersona.Click += new System.EventHandler(this.buttonCargaPersona_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(10, 65);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 3;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(116, 65);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(100, 20);
            this.textBoxApellido.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellido";
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(240, 57);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(120, 37);
            this.buttonModificar.TabIndex = 7;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(240, 100);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(120, 37);
            this.buttonEliminar.TabIndex = 8;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseMnemonic = false;
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Listado de Alumnos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Promedio";
            // 
            // textBoxPromedio
            // 
            this.textBoxPromedio.Location = new System.Drawing.Point(10, 112);
            this.textBoxPromedio.Name = "textBoxPromedio";
            this.textBoxPromedio.Size = new System.Drawing.Size(100, 20);
            this.textBoxPromedio.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Desempeño";
            this.label7.Visible = false;
            // 
            // textBoxDesemp
            // 
            this.textBoxDesemp.Location = new System.Drawing.Point(116, 112);
            this.textBoxDesemp.Name = "textBoxDesemp";
            this.textBoxDesemp.Size = new System.Drawing.Size(100, 20);
            this.textBoxDesemp.TabIndex = 15;
            this.textBoxDesemp.Visible = false;
            // 
            // listBoxCursos
            // 
            this.listBoxCursos.FormattingEnabled = true;
            this.listBoxCursos.Location = new System.Drawing.Point(596, 151);
            this.listBoxCursos.Name = "listBoxCursos";
            this.listBoxCursos.Size = new System.Drawing.Size(111, 173);
            this.listBoxCursos.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(731, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Integrantes";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(797, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Docente";
            // 
            // labelDocenteCurso
            // 
            this.labelDocenteCurso.AutoSize = true;
            this.labelDocenteCurso.Location = new System.Drawing.Point(851, 231);
            this.labelDocenteCurso.Name = "labelDocenteCurso";
            this.labelDocenteCurso.Size = new System.Drawing.Size(10, 13);
            this.labelDocenteCurso.TabIndex = 21;
            this.labelDocenteCurso.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(731, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(192, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Listado ordenado por mejor rendimiento";
            // 
            // comboBoxRend
            // 
            this.comboBoxRend.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRend.FormattingEnabled = true;
            this.comboBoxRend.Location = new System.Drawing.Point(734, 41);
            this.comboBoxRend.Name = "comboBoxRend";
            this.comboBoxRend.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRend.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(732, 378);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Total personas";
            // 
            // labelTotPersonas
            // 
            this.labelTotPersonas.AutoSize = true;
            this.labelTotPersonas.Location = new System.Drawing.Point(816, 378);
            this.labelTotPersonas.Name = "labelTotPersonas";
            this.labelTotPersonas.Size = new System.Drawing.Size(10, 13);
            this.labelTotPersonas.TabIndex = 29;
            this.labelTotPersonas.Text = "-";
            // 
            // labelTotCursos
            // 
            this.labelTotCursos.AutoSize = true;
            this.labelTotCursos.Location = new System.Drawing.Point(816, 405);
            this.labelTotCursos.Name = "labelTotCursos";
            this.labelTotCursos.Size = new System.Drawing.Size(10, 13);
            this.labelTotCursos.TabIndex = 31;
            this.labelTotCursos.Text = "-";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(732, 405);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Total cursos";
            // 
            // buttonAsignaAlumn
            // 
            this.buttonAsignaAlumn.Location = new System.Drawing.Point(463, 250);
            this.buttonAsignaAlumn.Name = "buttonAsignaAlumn";
            this.buttonAsignaAlumn.Size = new System.Drawing.Size(115, 34);
            this.buttonAsignaAlumn.TabIndex = 32;
            this.buttonAsignaAlumn.Text = "Asignar a curso";
            this.buttonAsignaAlumn.UseVisualStyleBackColor = true;
            this.buttonAsignaAlumn.Click += new System.EventHandler(this.buttonAsignaCurso_Click);
            // 
            // buttonMejorRendimiento
            // 
            this.buttonMejorRendimiento.Location = new System.Drawing.Point(734, 68);
            this.buttonMejorRendimiento.Name = "buttonMejorRendimiento";
            this.buttonMejorRendimiento.Size = new System.Drawing.Size(108, 25);
            this.buttonMejorRendimiento.TabIndex = 33;
            this.buttonMejorRendimiento.Text = "Mostrar";
            this.buttonMejorRendimiento.UseVisualStyleBackColor = true;
            // 
            // textBoxCargaCurso
            // 
            this.textBoxCargaCurso.Location = new System.Drawing.Point(403, 33);
            this.textBoxCargaCurso.Name = "textBoxCargaCurso";
            this.textBoxCargaCurso.Size = new System.Drawing.Size(100, 20);
            this.textBoxCargaCurso.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(400, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Curso";
            // 
            // buttonCargaCurso
            // 
            this.buttonCargaCurso.Location = new System.Drawing.Point(403, 59);
            this.buttonCargaCurso.Name = "buttonCargaCurso";
            this.buttonCargaCurso.Size = new System.Drawing.Size(120, 37);
            this.buttonCargaCurso.TabIndex = 37;
            this.buttonCargaCurso.Text = "Cargar curso";
            this.buttonCargaCurso.UseVisualStyleBackColor = true;
            this.buttonCargaCurso.Click += new System.EventHandler(this.buttonCargaCurso_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 309);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 13);
            this.label13.TabIndex = 39;
            this.label13.Text = "Listado de Docentes";
            // 
            // dataGridViewAlumnos
            // 
            this.dataGridViewAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlumnos.Location = new System.Drawing.Point(10, 151);
            this.dataGridViewAlumnos.Name = "dataGridViewAlumnos";
            this.dataGridViewAlumnos.Size = new System.Drawing.Size(568, 93);
            this.dataGridViewAlumnos.TabIndex = 40;
            this.dataGridViewAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAlumnos_CellContentClick);
            // 
            // dataGridViewDocentes
            // 
            this.dataGridViewDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDocentes.Location = new System.Drawing.Point(10, 325);
            this.dataGridViewDocentes.Name = "dataGridViewDocentes";
            this.dataGridViewDocentes.Size = new System.Drawing.Size(568, 93);
            this.dataGridViewDocentes.TabIndex = 41;
            this.dataGridViewDocentes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDocentes_CellContentClick);
            // 
            // buttonAsignaDoc
            // 
            this.buttonAsignaDoc.Location = new System.Drawing.Point(463, 424);
            this.buttonAsignaDoc.Name = "buttonAsignaDoc";
            this.buttonAsignaDoc.Size = new System.Drawing.Size(115, 34);
            this.buttonAsignaDoc.TabIndex = 42;
            this.buttonAsignaDoc.Text = "Asignar a curso";
            this.buttonAsignaDoc.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRendimientos
            // 
            this.dataGridViewRendimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRendimientos.Location = new System.Drawing.Point(734, 100);
            this.dataGridViewRendimientos.Name = "dataGridViewRendimientos";
            this.dataGridViewRendimientos.Size = new System.Drawing.Size(343, 93);
            this.dataGridViewRendimientos.TabIndex = 43;
            // 
            // dataGridViewPersonasEnCurso
            // 
            this.dataGridViewPersonasEnCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonasEnCurso.Location = new System.Drawing.Point(734, 250);
            this.dataGridViewPersonasEnCurso.Name = "dataGridViewPersonasEnCurso";
            this.dataGridViewPersonasEnCurso.Size = new System.Drawing.Size(343, 93);
            this.dataGridViewPersonasEnCurso.TabIndex = 44;
            // 
            // FormTP2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 548);
            this.Controls.Add(this.dataGridViewPersonasEnCurso);
            this.Controls.Add(this.dataGridViewRendimientos);
            this.Controls.Add(this.buttonAsignaDoc);
            this.Controls.Add(this.dataGridViewDocentes);
            this.Controls.Add(this.dataGridViewAlumnos);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.buttonCargaCurso);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxCargaCurso);
            this.Controls.Add(this.buttonMejorRendimiento);
            this.Controls.Add(this.buttonAsignaAlumn);
            this.Controls.Add(this.labelTotCursos);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.labelTotPersonas);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBoxRend);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelDocenteCurso);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listBoxCursos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxDesemp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPromedio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.buttonCargaPersona);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.label1);
            this.Name = "FormTP2";
            this.Text = "FormTP2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormTP2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRendimientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonasEnCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Button buttonCargaPersona;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPromedio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDesemp;
        private System.Windows.Forms.ListBox listBoxCursos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelDocenteCurso;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxRend;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelTotPersonas;
        private System.Windows.Forms.Label labelTotCursos;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonAsignaAlumn;
        private System.Windows.Forms.Button buttonMejorRendimiento;
        private System.Windows.Forms.TextBox textBoxCargaCurso;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonCargaCurso;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridViewAlumnos;
        private System.Windows.Forms.DataGridView dataGridViewDocentes;
        private System.Windows.Forms.Button buttonAsignaDoc;
        private System.Windows.Forms.DataGridView dataGridViewRendimientos;
        private System.Windows.Forms.DataGridView dataGridViewPersonasEnCurso;
    }
}