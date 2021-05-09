using System;
using System.Windows.Forms;

namespace TP1
{
    public partial class FormPadre : Form
    {
        public FormPadre()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormTP1 frm2 = new FormTP1
            {
                MdiParent = this
            };
            frm2.Show();
        }
    }
}