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

namespace Pdf_a_Word
{
    public partial class Form1 : Form
    {

        FolderBrowserDialog CarpetaSalida;
        bool Convertir = false;
        string RutaArchivoOrigen;
        string NombreArchivoOrigen;
        string RutaArchivoDestino;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnArchivoOrigen_Click(object sender, EventArgs e)
        {
            OpenFileDialog CajaDialogo = new OpenFileDialog();
            CajaDialogo.Filter = "Archivo PDF(.pdf)|*.pdf";

            DialogResult Resultado = CajaDialogo.ShowDialog();

            if(Resultado == DialogResult.OK)
            {
                RutaArchivoOrigen = CajaDialogo.FileName;
                NombreArchivoOrigen = Path.GetFileNameWithoutExtension(RutaArchivoOrigen);
                RutaArchivoDestino = Path.GetDirectoryName(RutaArchivoOrigen);

                txtCarpetaDestino.Text = RutaArchivoDestino;
                txtArchivoOrigen.Text = RutaArchivoOrigen.ToString();
                Convertir = true;

            }
        }

        private void btnCarpetaDestino_Click(object sender, EventArgs e)
        {
            CarpetaSalida = new FolderBrowserDialog();

            if(CarpetaSalida.ShowDialog() == DialogResult.OK)
            {
                txtCarpetaDestino.Text = CarpetaSalida.SelectedPath;
                RutaArchivoDestino = txtCarpetaDestino.Text;
                Convertir = true;
            }
        }

        private void btnConvertirWord_Click(object sender, EventArgs e)
        {

            if (Convertir)
            {
                SautinSoft.PdfFocus ArchivoPdf = new SautinSoft.PdfFocus();
                ArchivoPdf.OpenPdf(@RutaArchivoOrigen);
                ArchivoPdf.ToWord(RutaArchivoDestino + "\\" + NombreArchivoOrigen + ".docx");
                //System.Diagnostics.Process.Start(RutaArchivoDestino); Esto es para abrir la ruta
                MessageBox.Show("Archivo Convertido A Word");
            }
        }
    }
}
