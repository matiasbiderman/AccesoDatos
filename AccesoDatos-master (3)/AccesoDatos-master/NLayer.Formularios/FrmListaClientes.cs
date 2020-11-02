using iTextSharp.text;
using iTextSharp.text.pdf;
using NLayer.Entidades;
using NLayer.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void FrmListaClientes_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            /*
             OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) { }
            //textBox1.Text = openFileDialog1.file();*/
             
    /*
            Document doc = new Document(PageSize.LETTER);
            // Indicamos donde vamos a guardar el documento
            PdfWriter writer = PdfWriter.GetInstance(doc,
                                        new FileStream(@"C:\Users\Mati\Documents\prueba.pdf", FileMode.Create));

            // Le colocamos el título y el autor
            // **Nota: Esto no será visible en el documento
            doc.AddTitle("Mi primer PDF");
            doc.AddCreator("Roberto Torres");

            // Abrimos el archivo
            doc.Open();

            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            // Escribimos el encabezamiento en el documento
            doc.Add(new Paragraph("Mi primer documento PDF"));
            doc.Add(Chunk.NEWLINE);

            // Creamos una tabla que contendrá el nombre, apellido y país
            // de nuestros visitante.
            PdfPTable tblPrueba = new PdfPTable(2);
            tblPrueba.WidthPercentage = 100;

            // Configuramos el título de las columnas de la tabla
            PdfPCell clNombre = new PdfPCell(new Phrase("Nombre", _standardFont));
            clNombre.BorderWidth = 0;
            clNombre.BorderWidthBottom = 0.75f;
            PdfPCell[] celdanombres = new PdfPCell[4];

            // List<PdfPCell> celdanombres = new List<PdfPCell>();
            PdfPCell clApellido = new PdfPCell(new Phrase("Apellido", _standardFont));
            clApellido.BorderWidth = 0;
            clApellido.BorderWidthBottom = 0.75f;
            PdfPCell[] celdapellidos = new PdfPCell[4];//= new List<PdfPCell>();



            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clNombre);
            tblPrueba.AddCell(clApellido);
            // tblPrueba.AddCell(clPais);


            // Llenamos la tabla con información
            //List <Cliente> lst = _clienteServicio.TraerClientes();
            string[] lst = { "hola", "chau", "asasasasasa", "dfdsfdsfsdfds" };


            for (int i = 0; i < lst.Length; i++)
            {
                clNombre = new PdfPCell(new Phrase(lst[i], _standardFont));
                clNombre.BorderWidth = 0;
                celdanombres[i] = clNombre;
                clApellido = new PdfPCell(new Phrase(lst[i], _standardFont));
                clApellido.BorderWidth = 0;
                celdapellidos[i] = clApellido;
                tblPrueba.AddCell(celdanombres[i]);
                tblPrueba.AddCell(celdapellidos[i]);

            }

            doc.Add(tblPrueba);
            // Añadimos las celdas a la tabla
            doc.Close();
            writer.Close();

            MessageBox.Show("El reporte fue exportado correctamente. Lo podra encontrar en Documentos como prueba.pdf");
            */
        }
    }
}
