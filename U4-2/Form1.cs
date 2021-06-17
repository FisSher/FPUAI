using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<Producto> LStock = new List<Producto>();
        public List<Producto> LDeposito = new List<Producto>();

        private void Form1_Load(object sender, EventArgs e)
        {
            HardcodeProductosDeposito();
            HardcodeProductosStock();
            CargarLDeposito(LDeposito);
            CargarLStock(LStock);
        }

        private void HardcodeProductosStock()
        {
            LStock.Add(new Producto { Nombre = "Sprite", Marca = "CocaCola", CodigoUnico = 1, Cantidad = 10, Descripcion = "Bebida" });
            LStock.Add(new Producto { Nombre = "Chocolate", Marca = "Coffler", CodigoUnico = 2, Cantidad = 5, Descripcion = "Comida a base de cacao" });
            LStock.Add(new Producto { Nombre = "Flan", Marca = "Ravanna", CodigoUnico = 3, Cantidad = 2, Descripcion = "Polvo de postre" });
        }

        private void HardcodeProductosDeposito()
        {
            LDeposito.Add(new Producto { Nombre = "Sprite", Marca = "CocaCola", CodigoUnico = 1, Cantidad = 10, Descripcion = "Bebida" });
        }

        private void CargarLDeposito(List<Producto> LDeposito)
        {
            this.listBoxDeposito.DataSource = null;
            listBoxDeposito.DataSource = LDeposito;
        }

        private void CargarLStock(List<Producto> LStock)
        {
            this.listBoxStock.DataSource = null;
            listBoxStock.DataSource = LStock;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            LStock.Sort();
            CargarLStock(LStock);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            LStock.Sort();
            CargarLStock(LStock);
        }
    }
}