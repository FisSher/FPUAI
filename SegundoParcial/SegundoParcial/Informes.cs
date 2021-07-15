using Clases;
using SegundoParcial.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SegundoParcial.ABM;

namespace SegundoParcial
{
    public partial class Informes : Form,ICalculable
    {
        public Informes()
        {
            InitializeComponent();
        }


        private void Informes_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = LClientes;
            CargarListaPremium();
            CargarListaSilver();
        }
        #region CargaListas
        private void CargarListaClientes()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = LClientes;
        }

        private void CargarListaSilver()
        {
            listBoxPaqueteSilver.DataSource = null;
            listBoxPaqueteSilver.DataSource = LSilver;
        }

        private void CargarListaPremium()
        {
            listBoxPaquetePremium.DataSource = null;
            listBoxPaquetePremium.DataSource = LPremium;
        }

        #endregion

        private void listBoxPaqueteSilver_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridViewCanalesS.DataSource = null;
                PaqueteSilver ps = (PaqueteSilver)listBoxPaqueteSilver.SelectedItem;
                if (ps.LCanales != null && ps.LCanales.Count > 0)
                {
                    dataGridViewCanalesS.DataSource = ps.LCanales;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBoxPaquetePremium_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridViewCanalesP.DataSource = null;
                PaquetePremium pp = (PaquetePremium)listBoxPaquetePremium.SelectedItem;
                if (pp.LCanales != null && pp.LCanales.Count > 0)
                {
                    dataGridViewCanalesP.DataSource = pp.LCanales;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                labelPaqueteContratadoS.Text = "";
                labelPcontratadoP.Text = "";
                Cliente cliente = (Cliente)listBox1.SelectedItem;
                if (cliente.PaqueteS != null)
                    labelPaqueteContratadoS.Text = cliente.PaqueteS.Nombre;
                if (cliente.PaqueteP != null)
                    this.labelPcontratadoP.Text = cliente.PaqueteP.Nombre;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        #region interfaz
        //Interfaz personalizada
        public double CalcularTotalMes()
        {
            double totalSilver = 0;
            double totalPremium = 0;
            double total = 0;
            foreach (PaqueteSilver paqueteSilver in LSilver)
            {
                if (paqueteSilver.Estado == "Suscrito")
                {
                    totalSilver += paqueteSilver.Abono;
                }
            }
            foreach (PaquetePremium pp in LPremium)
            {
                if (pp.Estado == "Suscrito")
                {
                    totalPremium += pp.Abono;
                }
            }

            total = totalPremium + totalSilver;
            return total;
        }

        //Aplicacion interfaz
        private void buttonRecaudacion_Click(object sender, EventArgs e)
        {
            labelRecaudacion.Text = CalcularTotalMes().ToString();
        }
        #endregion


        internal delegate void Comparar();
        internal Comparar compara;

        private void ComparaMasVendido()
        {
            listBoxCanales.DataSource = null;
            int cantidadMaxP = 0;
            PaquetePremium paquetePmax = new PaquetePremium();
            foreach (PaquetePremium pp in LPremium)
            {
                if (pp.LClientes.Count > cantidadMaxP)
                {
                    cantidadMaxP = pp.LClientes.Count;
                    paquetePmax = pp;
                }
                    
            }
            int cantidadMaxS = 0;
            PaqueteSilver paqueteSmax = new PaqueteSilver();
            foreach (PaqueteSilver ps in LSilver)
            {
                if (ps.LClientes.Count>cantidadMaxS)
                {
                    cantidadMaxS = ps.LClientes.Count;
                    paqueteSmax = ps;
                }
            }

            if (cantidadMaxP > cantidadMaxS)
            {
                labelPaqueteMasMenosV.Text = paquetePmax.Nombre;
                listBoxCanales.DataSource = paquetePmax.LCanales;
            }
            else if (cantidadMaxS > cantidadMaxP)
            {
                labelPaqueteMasMenosV.Text = paqueteSmax.Nombre;
                listBoxCanales.DataSource = paqueteSmax.LCanales;
            }
            else
            {
                MessageBox.Show("No hay maximo actualmente");
            }
                
            
        }

        private void ComparaMenosVendido()
        {
            listBoxCanales.DataSource = null;
            int cantidadMinP = 999999;
            PaquetePremium paquetePmin = new PaquetePremium();
            foreach (PaquetePremium pp in LPremium)
            {
                if (pp.LClientes.Count < cantidadMinP)
                {
                    cantidadMinP = pp.LClientes.Count;
                    paquetePmin = pp;
                }

            }
            int cantidadMinS = 9999999;
            PaqueteSilver paqueteSmin = new PaqueteSilver();
            foreach (PaqueteSilver ps in LSilver)
            {
                if (ps.LClientes.Count < cantidadMinS)
                {
                    cantidadMinS = ps.LClientes.Count;
                    paqueteSmin = ps;
                }
            }

            if (cantidadMinP < cantidadMinS)
            {
                labelPaqueteMasMenosV.Text = paquetePmin.Nombre;
                listBoxCanales.DataSource = paquetePmin.LCanales;
            }
            else if (cantidadMinS > cantidadMinP)
            {
                labelPaqueteMasMenosV.Text = paqueteSmin.Nombre;
                listBoxCanales.DataSource = paqueteSmin.LCanales;
            }
            else
            {
                MessageBox.Show("No hay minimo actualmente");
            }

        }

        private void buttonPaqMasVend_Click(object sender, EventArgs e)
        {
            compara = ComparaMasVendido;
            compara.Invoke();
        }

        private void buttonPaqMenosVend_Click(object sender, EventArgs e)
        {
            compara = ComparaMenosVendido;
            compara.Invoke();
        }
    }
}