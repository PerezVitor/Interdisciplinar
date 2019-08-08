using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowdeBola
{
    public partial class frmRelFinanceiro : Form
    {
        public frmRelFinanceiro()
        {
            InitializeComponent();
            dgvUsuario.Columns[0].Visible = false;
            dgvUsuario.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvUsuario.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
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

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    Conexao conexao = new Conexao();
                    conexao.conectar();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conexao.conexao;
                    cmd.CommandText = "sp_Sel_Usuario";
                    cmd.Parameters.AddWithValue("@NM_USUARIO", txtUsuario.Text);
                    cmd.Parameters.AddWithValue("@ST_USUARIO", "True");
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dgvUsuario.DataSource = ds.Tables[0];
                    dgvUsuario.Columns[0].Visible = false;
                    dgvUsuario.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvUsuario.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
                    conexao.desconectar();
                    if (dgvUsuario.RowCount != 0)
                    {
                        dgvUsuario.Focus();
                    }
                    else
                    {
                        txtUsuario.Focus();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            txtUsuario.Text = "Informe um Usuário";
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            txtUsuario.Text = string.Empty;
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if ((txtInicial.Text.Replace("  /  /", "") == "" || dgvUsuario.RowCount == 0))
            {
                MessageBox.Show("Informe uma data e um usuário para visualizar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // TODO: This line of code loads data into the 'DB_Show_De_BolaDataSet.v_Financeiro' table. You can move, or remove it, as needed.
                this.v_FinanceiroTableAdapter.FillByDataUsuario(this.DB_Show_De_BolaDataSet.v_Financeiro, Convert.ToDateTime(txtInicial.Text).ToString(), int.Parse(dgvUsuario.CurrentRow.Cells[0].Value.ToString()));
                rptVisualizador.RefreshReport();
            }

        }

        private void frmRelFinanceiro_Load(object sender, EventArgs e)
        {
           txtInicial.Text = DateTime.Now.ToShortDateString();
            txtUsuario.Focus();
        }

        private void dgvUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtInicial.Focus();
            }
        }

        private void txtInicial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnVisualizar_Click(sender, e);
            }
        }
    }
}
