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
    public partial class FrmAgregarCliente : Form
    {
        private ClienteServicio _clienteServicio;
        private CuentaServicio _cuentaServicio;
        public FrmAgregarCliente()
        {
            InitializeComponent();
            _clienteServicio = new ClienteServicio();
            _cuentaServicio = new CuentaServicio();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = textBox1.Text;
                string apellido = textBox2.Text;
                string direccion = textBox3.Text;
                _clienteServicio.InsertarCliente(nombre, apellido, direccion);
                MessageBox.Show("Cliente agregado con exito");
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;
            }
           
        }

        private void FrmAgregarCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void FrmAgregarCliente_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }
    }
}
