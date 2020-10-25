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
    public partial class FrmListaClientes : Form
    {
        private ClienteServicio _clienteServicio;
        public FrmListaClientes()
        {
            InitializeComponent();

            _clienteServicio = new ClienteServicio();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Cliente> lst = _clienteServicio.TraerClientes();

            listBox1.DataSource = null;

            listBox1.DataSource = lst;
        }
    }
}
