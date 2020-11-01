using NLayer.Entidades;
using NLayer.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NLayer.Formularios
{
    public partial class FrmAbrirCuenta : Form
    {
        CuentaServicio cuentaServ;
        ClienteServicio clienteServ;
        public FrmAbrirCuenta()
        {
            InitializeComponent();
            clienteServ = new ClienteServicio();
            cuentaServ = new CuentaServicio();
        }

        private void FrmAbrirCuenta_Load(object sender, EventArgs e)
        {
            textBox1.Enabled =  true;
            comboBox1.DataSource = null;
            comboBox1.DataSource = clienteServ.TraerClientes();
            //comboBox2.DataSource = null;
            comboBox2.Items.Add("Cuenta corriente");
            comboBox2.Items.Add( "caja de ahorro");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            Cliente cliente = (Cliente)comboBox1.SelectedItem;
            textBox1.Text = cliente.Id.ToString();
        }
        private void FrmAbrirCuenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //abrir cuenta hacer insert
            try
            {
                Cliente cliente = (Cliente)comboBox1.SelectedItem;
                textBox1.Text = cliente.Id.ToString();
                string desc = comboBox2.SelectedItem.ToString();
                Cuenta cuenta = new Cuenta(cuentaServ.ProximoIdCuenta(), desc, cliente.Id);
                cuentaServ.IngresarCuenta(cuenta);
                MessageBox.Show("Cuenta agregada");
                listBox1.DataSource = null;
                listBox1.DataSource = cuentaServ.TraerCuentas();
                textBox1.Text = string.Empty;
            }
            catch(Exception exce)
            {
                MessageBox.Show(exce.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            string desc = comboBox2.SelectedItem.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
