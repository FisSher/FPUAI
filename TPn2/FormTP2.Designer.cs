
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
            this.buttonAsignaAlumn = new System.Windows.Forms.Button();
            this.textBoxCargaCurso = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonCargaCurso = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridViewAlumnos = new System.Windows.Forms.DataGridView();
            this.dataGridViewDocentes = new System.Windows.Forms.DataGridView();
            this.buttonAsignaDoc = new System.Windows.Forms.Button();
            this.textBoxCodModificar = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.buttonEliminarCurso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocentes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(501, 125);
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
            this.buttonCargaPersona.Location = new System.Drawing.Point(356, 12);
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
            this.buttonModificar.Location = new System.Drawing.Point(356, 55);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(120, 37);
            this.buttonModificar.TabIndex = 7;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Visible = false;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(356, 98);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(120, 37);
            this.buttonEliminar.TabIndex = 8;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseMnemonic = false;
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
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
            this.label5.Location = new System.Drawing.Point(7, 182);
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
            this.listBoxCursos.Location = new System.Drawing.Point(504, 160);
            this.listBoxCursos.Name = "listBoxCursos";
            this.listBoxCursos.Size = new System.Drawing.Size(111, 173);
            this.listBoxCursos.TabIndex = 17;
            // 
            // buttonAsignaAlumn
            // 
            this.buttonAsignaAlumn.Location = new System.Drawing.Point(361, 297);
            this.buttonAsignaAlumn.Name = "buttonAsignaAlumn";
            this.buttonAsignaAlumn.Size = new System.Drawing.Size(115, 34);
            this.buttonAsignaAlumn.TabIndex = 32;
            this.buttonAsignaAlumn.Text = "Asignar a curso";
            this.buttonAsignaAlumn.UseVisualStyleBackColor = true;
            this.buttonAsignaAlumn.Click += new System.EventHandler(this.buttonAsignaCurso_Click);
            // 
            // textBoxCargaCurso
            // 
            this.textBoxCargaCurso.Location = new System.Drawing.Point(504, 29);
            this.textBoxCargaCurso.Name = "textBoxCargaCurso";
            this.textBoxCargaCurso.Size = new System.Drawing.Size(100, 20);
            this.textBoxCargaCurso.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(501, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Curso";
            // 
            // buttonCargaCurso
            // 
            this.buttonCargaCurso.Location = new System.Drawing.Point(504, 55);
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
            this.label13.Location = new System.Drawing.Point(12, 325);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 13);
            this.label13.TabIndex = 39;
            this.label13.Text = "Listado de Docentes";
            // 
            // dataGridViewAlumnos
            // 
            this.dataGridViewAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlumnos.Location = new System.Drawing.Point(10, 198);
            this.dataGridViewAlumnos.Name = "dataGridViewAlumnos";
            this.dataGridViewAlumnos.Size = new System.Drawing.Size(466, 93);
            this.dataGridViewAlumnos.TabIndex = 40;
            this.dataGridViewAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAlumnos_CellContentClick);
            // 
            // dataGridViewDocentes
            // 
            this.dataGridViewDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDocentes.Location = new System.Drawing.Point(10, 341);
            this.dataGridViewDocentes.Name = "dataGridViewDocentes";
            this.dataGridViewDocentes.Size = new System.Drawing.Size(466, 93);
            this.dataGridViewDocentes.TabIndex = 41;
            this.dataGridViewDocentes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDocentes_CellContentClick);
            // 
            // buttonAsignaDoc
            // 
            this.buttonAsignaDoc.Location = new System.Drawing.Point(361, 440);
            this.buttonAsignaDoc.Name = "buttonAsignaDoc";
            this.buttonAsignaDoc.Size = new System.Drawing.Size(115, 34);
            this.buttonAsignaDoc.TabIndex = 42;
            this.buttonAsignaDoc.Text = "Asignar a curso";
            this.buttonAsignaDoc.UseVisualStyleBackColor = true;
            this.buttonAsignaDoc.Click += new System.EventHandler(this.buttonAsignaDoc_Click);
            // 
            // textBoxCodModificar
            // 
            this.textBoxCodModificar.Location = new System.Drawing.Point(179, 25);
            this.textBoxCodModificar.Name = "textBoxCodModificar";
            this.textBoxCodModificar.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodModificar.TabIndex = 45;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(176, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(174, 13);
            this.label15.TabIndex = 46;
            this.label15.Text = "Codigo persona a modificar o borrar";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(223, 63);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(56, 17);
            this.radioButton1.TabIndex = 47;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Cargar";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(223, 82);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(68, 17);
            this.radioButton2.TabIndex = 48;
            this.radioButton2.Text = "Modificar";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // buttonEliminarCurso
            // 
            this.buttonEliminarCurso.Location = new System.Drawing.Point(504, 339);
            this.buttonEliminarCurso.Name = "buttonEliminarCurso";
            this.buttonEliminarCurso.Size = new System.Drawing.Size(111, 42);
            this.buttonEliminarCurso.TabIndex = 49;
            this.buttonEliminarCurso.Text = "Eliminar curso";
            this.buttonEliminarCurso.UseVisualStyleBackColor = true;
            this.buttonEliminarCurso.Click += new System.EventHandler(this.buttonEliminarCurso_Click);
            // 
            // FormTP2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 482);
            this.Controls.Add(this.buttonEliminarCurso);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBoxCodModificar);
            this.Controls.Add(this.buttonAsignaDoc);
            this.Controls.Add(this.dataGridViewDocentes);
            this.Controls.Add(this.dataGridViewAlumnos);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.buttonCargaCurso);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxCargaCurso);
            this.Controls.Add(this.buttonAsignaAlumn);
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
        private System.Windows.Forms.Button buttonAsignaAlumn;
        private System.Windows.Forms.TextBox textBoxCargaCurso;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonCargaCurso;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridViewAlumnos;
        private System.Windows.Forms.DataGridView dataGridViewDocentes;
        private System.Windows.Forms.Button buttonAsignaDoc;
        private System.Windows.Forms.TextBox textBoxCodModificar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button buttonEliminarCurso;
    }
}