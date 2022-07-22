using Syncfusion.Windows.Forms.Barcode;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'etiquetasDataSet.Artigos' table. You can move, or remove it, as needed.
            this.artigosTableAdapter.Fill(this.etiquetasDataSet.Artigos);
            txtBCodArtigo.Hide();
            txtBDescricao.Hide();

            
        }

        private void sfBarcode1_Load(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                txtBCodArtigo.Text = row.Cells[0].Value.ToString();
                txtBDescricao.Text = row.Cells[1].Value.ToString();
               

                _ = new SfBarcode();
                if (txtBCodArtigo.Text != null)
                {
                    sfBarcode1.Text = txtBCodArtigo.Text;
                    this.Controls.Add(this.sfBarcode1);
                }
            }
         
            
        }

            
        private void sfButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2
            {
                descricao = txtBDescricao.Text,
                artigo = txtBCodArtigo.Text,
                cliente = txtBCliente.Text,
                encomenda = txtBEncomenda.Text,


            };

            form2.ShowDialog();
            form2.CaptureScreen();
            form2.Print();
        }
    }
}
