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
    public partial class FrmPrestamo : Form
    {
        TipoPrestamoServicio _tipoPrestamoServicio;
        PrestamoServicio _prestamoServicio;
        public FrmPrestamo()
        {
            InitializeComponent();
            _tipoPrestamoServicio = new TipoPrestamoServicio();
            _prestamoServicio = new PrestamoServicio();
        }

        private void FrmPrestamo_Load(object sender, EventArgs e)
        {
            txtlinea.Enabled = false;
            txttna.Enabled = false;
            txtcuotaint.Enabled = false;
            txtcuotatot.Enabled = false;
            txtcomisiontot.Enabled = false;
            txtcuotacap.Enabled = false;
            lstTipoPrestamos.DataSource = null;
            lstTipoPrestamos.DataSource = _tipoPrestamoServicio.TraerTipos();
        }

        private void FrmPrestamo_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            /* _prestamoServicio.AgregarPrestamo(prestamo);
             MessageBox.Show("Prestamo ingresado correctamente.");*/

        }
        private Prestamo CargaPrestamo()
        {

            Prestamo prestamo = new Prestamo(_prestamoServicio.ProximoId(), double.Parse(txttna.Text), txtlinea.Text, int.Parse(txtplazo.Text), double.Parse(txtmonto.Text));
            return prestamo;
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            try
            {
                txtcuotacap.Text = (int.Parse(txtmonto.Text) / int.Parse(txtplazo.Text)).ToString();
                txtcuotaint.Text = (double.Parse(txtcuotacap.Text) * (double.Parse(txttna.Text) / 12 / 100)).ToString();
                txtcuotatot.Text = (double.Parse(txtcuotacap.Text) + double.Parse(txtcuotaint.Text)).ToString();
                //TipoPrestamo tipoPrestamo = (TipoPrestamo)lstTipoPrestamos.SelectedItem;
                
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstTipoPrestamos_Click(object sender, EventArgs e)
        {
            TipoPrestamo tipoPrestamo = (TipoPrestamo)lstTipoPrestamos.SelectedItem;
            txtlinea.Text = tipoPrestamo.Linea;
            txttna.Text = tipoPrestamo.Tna.ToString();
            BlanqueoCampos();
        }

        private void BlanqueoCampos()
        {
            txtcuotacap.Text = string.Empty;
            txtcuotaint.Text = string.Empty;
            txtcuotatot.Text = string.Empty;
            txtmonto.Text = string.Empty;
            txtplazo.Text = string.Empty;
        }
    }
}
