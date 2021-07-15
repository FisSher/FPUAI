using Clases;
using SegundoParcial.ExcepcionPers;
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
    public partial class ABM : Form
    {
        public ABM()
        {
            InitializeComponent();
        }

        internal static List<Canal> LCanales = new List<Canal>();
        internal static List<Cliente> LClientes = new List<Cliente>();
        internal static List<PaqueteSilver> LSilver = new List<PaqueteSilver>();
        internal static List<PaquetePremium> LPremium = new List<PaquetePremium>();

        #region Carga de listas

        private void CargarListaClientes()
        {
            dataGridViewClientes.DataSource = null;
            dataGridViewClientes.DataSource = LClientes;
        }

        private void CargarListaCanales()
        {
            listBoxCanales.DataSource = null;
            listBoxCanales.DataSource = LCanales;
        }

        private void CargarListaSilver()
        {
            listBoxSilver.DataSource = null;
            listBoxSilver.DataSource = LSilver;
        }

        private void CargarListaPremium()
        {
            listBoxPremium.DataSource = null;
            listBoxPremium.DataSource = LPremium;
        }

        #endregion Carga de listas

        private enum Categoria
        {
            Documentales,
            Biografía,
            Películas,
            Series,
            Deportivos
        }

        //Acá hay datos dummy
        private void ABM_Load(object sender, EventArgs e)
        {
            comboBoxCanalCateg.DataSource = Enum.GetValues(typeof(Categoria));
            if (LClientes.Count == 0)
            {
                LClientes.Add(new Cliente(1, "Facundo", "Paolini", 3566543, "facundo@alumno.etc"));
                LClientes.Add(new Cliente(2, "Virginia", "carr", 3566665, "Virginia@cliente.etc"));
                LClientes.Add(new Cliente(3, "Gaston", "Dummy", 3568888, "Gaston@cliente.etc"));
            }
            if (LCanales.Count == 0)
            {
                LCanales.Add(new Canal(1, 4, "Disney", Categoria.Series.ToString()));
                LCanales.Add(new Canal(2, 29, "Fox", Categoria.Películas.ToString()));
                LCanales.Add(new Canal(3, 10, "Discovery", Categoria.Documentales.ToString()));
            }
            if (LSilver.Count == 0)
            {
                LSilver.Add(new PaqueteSilver(1, "SilverPaqueteMid", 3000));
                LSilver.Add(new PaqueteSilver(2, "SilverPaqueteUpper", 2000));
            }
            if (LPremium.Count == 0)
            {
                LPremium.Add(new PaquetePremium(1, "PremiumSuperPack", 6000));
                LPremium.Add(new PaquetePremium(2, "PremiumSuperUltraPack", 10000));
            }

            CargarListaCanales();
            CargarListaClientes();
            CargarListaPremium();
            CargarListaSilver();
        }

        #region Cargas

        //Cliente
        private void buttonCargaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();
                cliente.CodCliente = Convert.ToInt32(textBoxCliCod.Text);
                cliente.Nombre = textBoxCliNomb.Text;
                cliente.Apellido = textBoxCliApell.Text;
                cliente.DNI = Convert.ToInt32(textBoxCliDNI.Text);
                cliente.Mail = textBoxCliMail.Text;
                cliente.FechaNac = dateTimePickerCliFNac.Value;

                LClientes.Add(cliente);
                CargarListaClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Canal
        private void buttonCargaCanal_Click(object sender, EventArgs e)
        {
            try
            {
                bool found = false;
                Canal canal = new Canal(Convert.ToInt32(textBoxCanalCod.Text), Convert.ToInt32(textBoxCanalNum.Text),
                                textBoxCanalNomb.Text, comboBoxCanalCateg.SelectedValue.ToString());
                foreach (Canal c in LCanales)
                {
                    if (c.Codigo == canal.Codigo)
                    {
                        found = true;
                        throw new CanalExistenteException();
                    }
                }
                if (!found)
                {
                    LCanales.Add(canal);
                    CargarListaCanales();
                }
            }
            catch (CanalExistenteException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Paquete
        private void buttonCargaPaq_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxPaqTipo.SelectedIndex == 0)
                {
                    PaqueteSilver paqueteSilver = new PaqueteSilver(Convert.ToInt32(textBoxPaqCodigo.Text),
                        textBoxPaqNombre.Text, Convert.ToInt32(textBoxPaqAbono.Text));
                    LSilver.Add(paqueteSilver);
                    CargarListaSilver();
                }
                else if (comboBoxPaqTipo.SelectedIndex == 1)
                {
                    PaquetePremium paquetePremium = new PaquetePremium(Convert.ToInt32(textBoxPaqCodigo.Text),
                        textBoxPaqNombre.Text, Convert.ToInt32(textBoxPaqAbono.Text));
                    LPremium.Add(paquetePremium);
                    CargarListaPremium();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion Cargas

        //Clonar
        private void buttonClonarCanal_Click(object sender, EventArgs e)
        {
            try
            {
                Canal canal = (Canal)listBoxCanales.SelectedItem;
                Canal clon = (Canal)canal.Clone();
                LCanales.Add(clon);
                CargarListaCanales();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region Modificar

        //Cliente
        private void buttonModificaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = (Cliente)dataGridViewClientes.CurrentRow.DataBoundItem;
                cliente.CodCliente = Convert.ToInt32(textBoxCliCod.Text);
                cliente.Nombre = textBoxCliNomb.Text;
                cliente.Apellido = textBoxCliApell.Text;
                cliente.DNI = Convert.ToInt32(textBoxCliDNI.Text);
                cliente.Mail = textBoxCliMail.Text;
                cliente.FechaNac = dateTimePickerCliFNac.Value;
                CargarListaClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Canal
        private void buttonModifCanal_Click(object sender, EventArgs e)
        {
            try
            {
                Canal canal = (Canal)listBoxCanales.SelectedItem;
                canal.Codigo = Convert.ToInt32(textBoxCanalCod.Text);
                canal.Numero = Convert.ToInt32(textBoxCanalNum.Text);
                canal.Nombre = textBoxCanalNomb.Text;
                canal.Categoria = comboBoxCanalCateg.SelectedValue.ToString();
                CargarListaCanales();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Paquete
        private void buttonModifPaq_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxPaqTipo.SelectedIndex == 0)
                {
                    PaqueteSilver paqueteS = (PaqueteSilver)listBoxSilver.SelectedItem;
                    paqueteS.Codigo = Convert.ToInt32(textBoxPaqCodigo.Text);
                    paqueteS.Nombre = textBoxPaqNombre.Text;
                    paqueteS.Abono = Convert.ToInt32(textBoxPaqAbono.Text) + Convert.ToInt32(textBoxPaqAbono.Text) * 0.15;
                    CargarListaSilver();
                }
                else if (comboBoxPaqTipo.SelectedIndex == 1)
                {
                    PaquetePremium paqueteP = (PaquetePremium)listBoxPremium.SelectedItem;
                    paqueteP.Codigo = Convert.ToInt32(textBoxPaqCodigo.Text);
                    paqueteP.Nombre = textBoxPaqNombre.Text;
                    paqueteP.Abono = Convert.ToInt32(textBoxPaqAbono.Text) + Convert.ToInt32(textBoxPaqAbono.Text) * 0.25;
                    CargarListaPremium();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion Modificar

        #region eliminar

        //Hace la busqueda por código
        //Cliente
        private void buttonEliminarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = (Cliente)dataGridViewClientes.CurrentRow.DataBoundItem;
                foreach (Cliente c in LClientes)
                {
                    if (cliente.CodCliente == c.CodCliente)
                    {
                        LClientes.Remove(c);
                        CargarListaClientes();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Canal
        private void buttonEliminaCanal_Click(object sender, EventArgs e)
        {
            Canal canal = (Canal)listBoxCanales.SelectedItem;
            foreach (Canal c in LCanales)
            {
                if (c.Codigo == canal.Codigo)
                {
                    LCanales.Remove(c);
                    CargarListaCanales();
                    break;
                }
            }
        }

        //Paquete
        private void buttonEliminPaq_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxPaqTipo.SelectedIndex == 0)
                {
                    PaqueteSilver paqueteSilver = (PaqueteSilver)listBoxSilver.SelectedItem;
                    foreach (PaqueteSilver ps in LSilver)
                    {
                        if (ps.Codigo == paqueteSilver.Codigo)
                        {
                            LSilver.Remove(ps);
                            CargarListaSilver();
                            break;
                        }
                    }
                }
                else if (comboBoxPaqTipo.SelectedIndex == 1)
                {
                    PaquetePremium paquetePremium = (PaquetePremium)listBoxPremium.SelectedItem;
                    foreach (PaquetePremium pp in LPremium)
                    {
                        if (pp.Codigo == paquetePremium.Codigo)
                        {
                            LPremium.Remove(pp);
                            CargarListaPremium();
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion eliminar

        #region AsociarCanal

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Canal canal = (Canal)listBoxCanales.SelectedItem;
                PaqueteSilver ps = (PaqueteSilver)listBoxSilver.SelectedItem;
                bool found = false;
                foreach (Canal c in ps.LCanales)
                {
                    if (canal.Codigo == c.Codigo)
                    {
                        MessageBox.Show("El canal ya esta presente");
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    ps.LCanales.Add(canal);
                    CargarListaSilver();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Canal canal = (Canal)listBoxCanales.SelectedItem;
                PaquetePremium pp = (PaquetePremium)listBoxPremium.SelectedItem;
                bool found = false;
                foreach (Canal c in pp.LCanales)
                {
                    if (canal.Codigo == c.Codigo)
                    {
                        MessageBox.Show("El canal ya esta presente");
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    pp.LCanales.Add(canal);
                    CargarListaPremium();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion AsociarCanal

        #region asociar cliente

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = (Cliente)dataGridViewClientes.CurrentRow.DataBoundItem;
                PaqueteSilver ps = (PaqueteSilver)listBoxSilver.SelectedItem;
                cliente.PaqueteS = ps;
                ps.LClientes.Add(cliente);
                ps.ChequeaEstado += Ps_ChequeaEstado;
                ps.ValidarEstado("Suscrito");
                ps.ChequeaEstado -= Ps_ChequeaEstado;
                ps.Estado = "Suscrito";
                CargarListaClientes();
                CargarListaSilver();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Ps_ChequeaEstado(object sender, Evento.EstadoArgumentos e)
        {
            MessageBox.Show("Suscrito!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = (Cliente)dataGridViewClientes.CurrentRow.DataBoundItem;
                PaquetePremium pp = (PaquetePremium)listBoxPremium.SelectedItem;
                cliente.PaqueteP = pp;
                pp.LClientes.Add(cliente);
                pp.Estado = "Suscrito";
                pp.ChequeaEstado += Pp_ChequeaEstado;
                pp.ValidarEstado("Suscrito");
                pp.ChequeaEstado -= Pp_ChequeaEstado;

                CargarListaClientes();
                CargarListaPremium();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Pp_ChequeaEstado(object sender, Evento.EstadoArgumentos e)
        {
            MessageBox.Show("Suscrito!");
        }

        #endregion asociar cliente
    }
}