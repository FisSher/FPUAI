using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U3_P2_1
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            
        }

        private void aBMVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormABMVehiculos formABMVehiculos = new FormABMVehiculos();
            formABMVehiculos.MdiParent = this;
            formABMVehiculos.Show();

        }

        private void informeToolStripMenuItem_Click(object sender, EventArgs e)
        {
             FormInforme formInforme = new FormInforme();
            formInforme.MdiParent = this;
            formInforme.Show();
        }
    }
}
