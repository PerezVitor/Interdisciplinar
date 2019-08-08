using Microsoft.Reporting.WinForms;
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
    public partial class frmRelReserva : Form
    {
        int visualizado = 0;
        public frmRelReserva()
        {
            InitializeComponent();

            dgvClientes.Columns[0].Visible = false;
            dgvClientes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvClientes.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvClientes.Columns[2].Width = 120;
            dgvClientes.Columns[2].Visible = false;

            dgvCampos.Columns[0].Visible = false;
            dgvCampos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCampos.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvCampos.Columns[2].Width = 120;
            dgvCampos.Columns[2].Visible = false;
        }
        private void exportarRelatorio()
        {
            string sSuggestedName = String.Empty;

            byte[] byteViewerPDF = rptVisualizador.LocalReport.Render("PDF");
            byte[] byteViewerExcel = rptVisualizador.LocalReport.Render("Excel");
            byte[] byteViewerWord = rptVisualizador.LocalReport.Render("Word");

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "PDF files (*.pdf)|*.pdf| Doc files(*.doc) | *.doc | Excel files(*.xls) | *.xls";

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

            }
        }
        private void frmRelReserva_Load(object sender, EventArgs e)
        {
            txtInicial.Text = DateTime.Now.ToShortDateString();
            txtFinal.Text = DateTime.Now.ToShortDateString();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //Formata Visual
            SidePanel.Height = btnImprimir.Height;
            SidePanel.Top = btnImprimir.Top;
            if (rptVisualizador.GetTotalPages() != 0)
            {
                rptVisualizador.PrintDialog();
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            //Formata Visual
            SidePanel.Height = btnExportar.Height;
            SidePanel.Top = btnExportar.Top;
            if (rptVisualizador.GetTotalPages() != 0)
            {
                exportarRelatorio();
            }
        }

        private void btnProxima_Click(object sender, EventArgs e)
        {
            //Formata Visual
            SidePanel.Height = btnProxima.Height;
            SidePanel.Top = btnProxima.Top;
            if (rptVisualizador.GetTotalPages() != 0)
            {
                rptVisualizador.CurrentPage = rptVisualizador.CurrentPage + 1;
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            //Formata Visual
            SidePanel.Height = btnAnterior.Height;
            SidePanel.Top = btnAnterior.Top;            
            if (rptVisualizador.CurrentPage != 1)
            {
                rptVisualizador.CurrentPage = rptVisualizador.CurrentPage - 1;
            }
        }

        private void btnPrimeira_Click(object sender, EventArgs e)
        {
            //Formata Visual
            SidePanel.Height = btnPrimeira.Height;
            SidePanel.Top = btnPrimeira.Top;
            if (rptVisualizador.GetTotalPages() != 0)
            {
                rptVisualizador.CurrentPage = 1;
            }
        }
        private void btnUltima_Click(object sender, EventArgs e)
        {   //Formata Visual
            SidePanel.Height = btnUltima.Height;
            SidePanel.Top = btnUltima.Top;
            if (rptVisualizador.GetTotalPages() != 0)
            {
                rptVisualizador.CurrentPage = rptVisualizador.LocalReport.GetTotalPages();
            }

        }
        private void btnZoom_Click(object sender, EventArgs e)
        {
            //Formata Visual
            SidePanel.Height = btnZoom.Height;
            SidePanel.Top = btnZoom.Top;
            if (rptVisualizador.GetTotalPages() != 0)
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void txtCliente_Enter(object sender, EventArgs e)
        {
            txtCliente.Text = string.Empty;
        }

        private void txtCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    Conexao conexao = new Conexao();
                    conexao.conectar();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conexao.conexao;
                    cmd.CommandText = "sp_Sel_Cliente";
                    cmd.Parameters.AddWithValue("@NM_CLIENTE", txtCliente.Text);
                    cmd.Parameters.AddWithValue("@CELULAR_CLIENTE", "");
                    cmd.Parameters.AddWithValue("@ST_CLIENTE", "True");
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dgvClientes.DataSource = ds.Tables[0];
                    dgvClientes.Columns[0].Visible = false;
                    dgvClientes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvClientes.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
                    dgvClientes.Columns[2].Width = 120;
                    dgvClientes.Columns[2].Visible = false;
                    conexao.desconectar();
                    if (dgvClientes.RowCount != 0)
                    {
                        dgvClientes.Focus();
                    }
                    else
                    {
                        txtCliente.Focus();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtCampo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    Conexao conexao = new Conexao();
                    conexao.conectar();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conexao.conexao;
                    cmd.CommandText = "sp_Sel_Campo";
                    cmd.Parameters.AddWithValue("@DS_CAMPO", txtCampo.Text);
                    cmd.Parameters.AddWithValue("@ST_CAMPO", "True");
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dgvCampos.DataSource = ds.Tables[0];
                    dgvCampos.Columns[0].Visible = false;
                    dgvCampos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvCampos.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
                    dgvCampos.Columns[2].Width = 120;
                    dgvCampos.Columns[2].Visible = false;
                    conexao.desconectar();
                    if (dgvCampos.RowCount != 0)
                    {
                        dgvCampos.Focus();
                    }
                    else
                    {
                        txtCampo.Focus();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtCampo_Enter(object sender, EventArgs e)
        {
            txtCampo.Text = string.Empty;
        }

        private void dgvClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtCampo.Focus();
            }
        }

        private void dgvCampos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtInicial.Focus();
            }
        }

        private void txtCliente_Leave(object sender, EventArgs e)
        {
            txtCliente.Text = "Informe um Cliente";
        }

        private void txtCampo_Leave(object sender, EventArgs e)
        {
            txtCampo.Text = "Informe um Campo";
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            DateTime data1, data2;
            if (DateTime.TryParse(txtInicial.Text.ToString(), out data1).Equals(true) && DateTime.TryParse(txtFinal.Text.ToString(), out data2).Equals(true))
            {
                if (data1 > data2)
                {
                    MessageBox.Show("Informa uma data final maior ou igual a inicial!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Data(s) inválida(s)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if ((txtInicial.Text.Replace("  /  /", "") == "" || txtFinal.Text.Replace("  /  /", "") == "") || dgvCampos.RowCount == 0)
            {
                MessageBox.Show("Informe cliente, campo e um período para visualizar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string cliente;
                if (dgvClientes.RowCount == 0)
                {

                    cliente = "% %";
                }
                else
                {
                    cliente = '%' + dgvClientes.CurrentRow.Cells[1].Value.ToString() + '%';

                }
                try
                {
                    this.rptVisualizador.Clear();
                    this.v_HorarioReservaTableAdapter.FillByDataCliente(this.DB_Show_De_BolaDataSet.v_HorarioReserva, "True", cliente, int.Parse(dgvCampos.CurrentRow.Cells[0].Value.ToString()), Convert.ToDateTime(txtInicial.Text).ToString(), Convert.ToDateTime(txtFinal.Text).ToString());
                    this.rptVisualizador.RefreshReport();
                    visualizado = 1;

                }
                catch (Exception ex)
                {


                }

            }

        }
        //private void rptGetDataset()
        //{
        //    DataSet ds = new DataSet();
        //    Conexao conexao = new Conexao();
        //    ds.DataSetName = "DB_Show_De_BolaDataSet";
        //    string sql = "";
        //    sql = "SELECT ID, CLIENT_ID, AGENT_ID FROM TBLMAILDELETED";
        //    SqlDataAdapter da = new SqlDataAdapter(sql, conexao.conexao);
        //    ds.GetXmlSchema();
        //    da.Fill(ds);
        //    ds.WriteXmlSchema(_path + "/App_Code/Ds.xsd");
        //    ds.WriteXml(_path + "/App_Code/Ds.xml");
        //}

        //private DataTable getData()
        //{
        //    Conexao conexao = new Conexao();
        //    DataSet dss = new DataSet();
        //    string sql = "";
        //    sql = "SELECT ID, CLIENT_ID, AGENT_ID FROM TBLMAILDELETED";
        //    SqlDataAdapter da = new SqlDataAdapter(sql, conexao.conexao);
        //    da.Fill(dss);
        //    DataTable dt = dss.Tables[0];
        //    return dt;
        //}

        //private void runRptViewer()
        //{
        //    this.rptVisualizador.Reset();
        //    this.rptVisualizador.LocalReport.ReportPath = Microsoft.SqlServer.Server.MapPath("Report.rdlc");
        //    ReportDataSource rds = new ReportDataSource("dsNewDataSet_Table", getData());
        //    this.rptVisualizador.LocalReport.DataSources.Clear();
        //    this.rptVisualizador.LocalReport.DataSources.Add(rds);
        //    this.rptVisualizador.LocalReport.Refresh();
        //}

    }
}
