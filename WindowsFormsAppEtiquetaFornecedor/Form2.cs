using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEtiquetaFornecedor
{
    public partial class Form2 : Form
    {
        public string descricao, artigo, cliente, encomenda;
        public static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        private Bitmap memoryImage;
        public Form2()
        {
            InitializeComponent();
        }

        private void AutoLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            autoLabelDescricao.Text = descricao;
            autoLabelStk.Text = artigo;
            autoLabelEncomenda.Text = encomenda;
            autoLabelCliente.Text = cliente;
            
        }

        public void CaptureScreen()
        {
            Graphics mygraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height, dc1, 0, 0, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);
                        
        }
        public void Print()
        {
            Spire.Pdf.PdfDocument doc = new Spire.Pdf.PdfDocument();

            Spire.Pdf.Graphics.PdfImage image =
                Spire.Pdf.Graphics.PdfImage.FromImage(memoryImage);

            Spire.Pdf.Graphics.PdfUnitConvertor convertor = new Spire.Pdf.Graphics.PdfUnitConvertor();
            SizeF sizeF = convertor.ConvertFromPixels(memoryImage.Size, Spire.Pdf.Graphics.PdfGraphicsUnit.Point);
            Spire.Pdf.PdfPageBase pageBase = doc.Pages.Add(sizeF, new Spire.Pdf.Graphics.PdfMargins(0f));

            float width = image.Width * 0.818f;
            float heigth = image.Height;
            float X = (pageBase.Canvas.ClientSize.Width - width) / 2;

            pageBase.Canvas.DrawImage(image, X, 0, width, heigth);


            doc.Print();


            doc.Close();
        }
        private void SfBarcode1_Load(object sender, EventArgs e)
        {
            sfBarcode1.Text = artigo.ToString();
            this.Controls.Add(this.sfBarcode1);
        }
    }
}
