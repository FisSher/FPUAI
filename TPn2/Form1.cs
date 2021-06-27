using System;
using System.Windows.Forms;

namespace TPn2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tP2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTP2 frm2 = new FormTP2
            {
                MdiParent = this
            };
            frm2.Show();
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