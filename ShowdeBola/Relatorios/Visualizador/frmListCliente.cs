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

namespace ShowdeBola
{
    public partial class frmListCliente : Form
    {
        public frmListCliente()
        {
            InitializeComponent();
        }

        private void exportarRelatorio()
        {
            string sSuggestedName = String.Empty;

            byte[] byteViewerPDF = rptVisualizador.LocalReport.Render("PDF");
            byte[] byteViewerExcel = rptVisualizador.LocalReport.Render("Excel");
            byte[] byteViewerWord = rptVisualizador.LocalReport.Render("Word");

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "PDF files (*.pdf)|*.pdf|Doc files(*.doc) | *.doc |Excel files(*.xls) | *.xls";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                FileStream newFile = new FileStream(saveFileDialog1.FileName, FileMode.Create);

                if (saveFileDialog1.FilterIndex == 1)
                {
                    newFile.Write(byteViewerPDF, 0, byteViewerPDF.Length);
                    newFile.Close();
                }
                else
                  if (saveFileDialog1.FilterIndex == 2)
                {
                    newFile.Write(byteViewerWord, 0, byteViewerWord.Length);
                    newFile.Close();
                }
                else
                  if (saveFileDialog1.FilterIndex == 3)
                {
                    newFile.Write(byteViewerExcel, 0, byteViewerExcel.Length);
                    newFile.Close();
                }
                MessageBox.Show("Arquivo exportado com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void frmRelatorio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DB_Show_De_BolaDataSet.v_Cliente' table. You can move, or remove it, as needed.
            this.v_ClienteTableAdapter.Fill(this.DB_Show_De_BolaDataSet.v_Cliente);
            this.rptVisualizador.RefreshReport();

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            rptVisualizador.PrintDialog();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            exportarRelatorio();
        }

        private void btnProxima_Click(object sender, EventArgs e)
        {
            rptVisualizador.CurrentPage = rptVisualizador.CurrentPage + 1;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (rptVisualizador.CurrentPage != 1)
            {
                rptVisualizador.CurrentPage = rptVisualizador.CurrentPage - 1;
            }
        }

        private void btnPrimeira_Click(object sender, EventArgs e)
        {
            rptVisualizador.CurrentPage = 1;
        }
        private void btnUltima_Click(object sender, EventArgs e)
        {
            rptVisualizador.CurrentPage = rptVisualizador.LocalReport.GetTotalPages();
        }
        private void btnZoom_Click(object sender, EventArgs e)
        {
            if (btnZoom.Tag.ToString() == "50")
            {
                rptVisualizador.ZoomPercent = 100;
                btnZoom.Tag = "100";
            }
            else if (btnZoom.Tag.ToString() == "100")
            {
                rptVisualizador.ZoomPercent = 150;
                btnZoom.Tag = 150;
            }
            else if (btnZoom.Tag.ToString() == "150")
            {
                rptVisualizador.ZoomPercent = 200;
                btnZoom.Tag = 200;
            }
            else if (btnZoom.Tag.ToString() == "200")
            {
                rptVisualizador.ZoomPercent = 250;
                btnZoom.Tag = 250;
            }
            else if (btnZoom.Tag.ToString() == "250")
            {
                rptVisualizador.ZoomPercent = 300;
                btnZoom.Tag = 50;
            }

        }
    }
}
