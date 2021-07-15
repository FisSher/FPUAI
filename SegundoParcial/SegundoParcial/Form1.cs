using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aBMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM abm = new ABM
            {
                MdiParent = this
            };
            abm.Show();
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Informes informes = new Informes
            {
                MdiParent = this

            };
            informes.Show();
        }
    }
}
