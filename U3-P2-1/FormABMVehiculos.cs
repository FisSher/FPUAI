using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace U3_P2_1
{
    public partial class FormABMVehiculos : Form
    {
        public FormABMVehiculos()
        {
            InitializeComponent();
            ListaEmpresas = new List<Empresa>();
            ListaVehiculos = new List<Vehiculo>();
        }

        #region inicializa objetos

        private List<Empresa> ListaEmpresas;
        private List<Vehiculo> ListaVehiculos;

        private Empresa empresa;
        private Vehiculo vehiculo;

        #endregion inicializa objetos

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(textBoxEmpresa.Text))
                {
                    throw new ArgumentException("Tiene que haber nombre de empresa.");
                }
                empresa = new Empresa(Name = textBoxEmpresa.Text);
                ListaEmpresas.Add(empresa);
                CargarEmpresas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        public void CargarEmpresas()
        {
            this.dataGridEmpresas.DataSource = null;
            this.dataGridEmpresas.DataSource = ListaEmpresas;
            this.dataGridEmpresas.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGreen;
        }
    }
}