using System;
using System.Windows.Forms;
using static TPn2.FormTP2;

namespace TPn2
{
    public partial class Informes : Form
    {
        public Informes()
        {
            InitializeComponent();
        }

        private void Informes_Load(object sender, EventArgs e)
        {
            comboBoxRend.DataSource = Enum.GetValues(typeof(TipoUsuarios));
            if (LCursos != null)
                listBoxCursos.DataSource = LCursos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}