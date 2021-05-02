using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int tipo = Convert.ToInt32(Interaction.InputBox("Ingrese 1 para agua mineral, 2 para bebida azucarada "));

            switch (tipo) {
                case 1:


                    break;
                case 2:




                    break;
                default:
                    break;
            
            }
        }
    }
}
