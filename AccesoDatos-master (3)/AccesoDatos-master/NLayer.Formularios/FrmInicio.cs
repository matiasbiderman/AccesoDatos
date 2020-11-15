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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmListaClientes forumulario = new FrmListaClientes();
            forumulario.Owner = this;
            forumulario.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmAgregarCliente forumulario = new FrmAgregarCliente();
            forumulario.Owner = this;
            forumulario.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAbrirCuenta forumulario = new FrmAbrirCuenta();
            forumulario.Owner = this;
            forumulario.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmPrestamo forumulario = new FrmPrestamo();
            forumulario.Owner = this;
            forumulario.Show();
            this.Hide();
        }
    }
}
