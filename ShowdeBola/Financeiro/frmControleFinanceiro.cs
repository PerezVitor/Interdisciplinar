using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowdeBola
{
    public partial class frmControleFinanceiro : Form
    {
        string funcao = string.Empty;
        public frmControleFinanceiro()
        {
            InitializeComponent();
            controleBotao(true);
            atualizaGridView();
        }
        private void controleBotao(Boolean valor)
        {
            btnReceber.Enabled = valor;
            btnEstorno.Enabled = valor;
            btnAtualizar.Enabled = valor;
            btnFiltro.Enabled = valor;
            dgvDados.Visible = valor;
            if (valor == true)
            {
                dgvDados.Focus();
            }
        }
        //Método para atualizar grid.
        private void atualizaGridView()
        {
            Conexao conexao = new Conexao();
            conexao.conectar();
            SqlCommand cmd = new SqlCommand("sp_Sel_Financeiro", conexao.conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ST_FINANCEIRO", "True");
            if (panelFiltro.Visible == false)
            {
                cmd.Parameters.AddWithValue("@NM_CLIENTE", "");
            }
            else
            {
                cmd.Parameters.AddWithValue("@NM_CLIENTE", txtFiltro.Text);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvDados.DataSource = ds.Tables[0];
            dgvDados.Columns[0].Width = 100;
            dgvDados.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDados.Columns[2].Width = 100;
            dgvDados.Columns[3].Width = 100;
            dgvDados.Columns[4].Visible = false;
            conexao.desconectar();
        }
        private void btnReceber_Click(object sender, EventArgs e)
        {
            //Formata Visual
            SidePanel.Height = btnReceber.Height;
            SidePanel.Top = btnReceber.Top;
            if (dgvDados.CurrentRow.Cells[3].Value.ToString() == "PAGO")
            {
                MessageBox.Show("Financeiro já finalizado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dgvDados.RowCount > 0)
            {
                LoginUsuario.reserva(Convert.ToInt32(dgvDados.CurrentRow.Cells[4].Value));
                funcao = "BAIXAR";
                frmRecebimento frmRecebimento = new frmRecebimento();
                frmRecebimento.ShowDialog();
            }
            atualizaGridView();
        }
        private void btnEstorno_Click(object sender, EventArgs e)
        {
            //Formata Visual
            SidePanel.Height = btnEstorno.Height;
            SidePanel.Top = btnEstorno.Top;
            LoginUsuario.reserva(Convert.ToInt32(dgvDados.CurrentRow.Cells[4].Value));
            if (dgvDados.CurrentRow.Cells[3].Value.ToString() == "EM ABERTO")
            {
                MessageBox.Show("Financeiro em Aberto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dgvDados.RowCount > 0)
            {
                //Mensagem para o usuário
                DialogResult iResposta;
                iResposta = MessageBox.Show("Deseja realmente estorno?", "Confirmar!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (iResposta.ToString() == "Yes")
                {
                    Conexao conexao = new Conexao();
                    conexao.conectar();
                    SqlCommand cmd = new SqlCommand("sp_Upd_Financeiro", conexao.conexao);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@STC_FINANCEIRO", "EM ABERTO");
                    cmd.Parameters.AddWithValue("@ID_HORARIORESERVA", LoginUsuario.getReserva());
                    cmd.Parameters.AddWithValue("@FP_FINANCEIRO", "");
                    cmd.Parameters.AddWithValue("@DT_PAGAMENTO", DateTime.Now.ToShortDateString());
                    cmd.ExecuteReader(CommandBehavior.SingleRow);
                    conexao.desconectar();
                    MessageBox.Show("Concluído com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    atualizaGridView();
                }
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //Formata Visual
            SidePanel.Height = btnAtualizar.Height;
            SidePanel.Top = btnAtualizar.Top;
            atualizaGridView();
        }
        private void btnFiltro_Click(object sender, EventArgs e)
        {
            //Formata Visual
            SidePanel.Height = btnFiltro.Height;
            SidePanel.Top = btnFiltro.Top;

            if (panelFiltro.Visible == true)
            {
                panelFiltro.Visible = false;
            }
            else
            {
                panelFiltro.Visible = true;
                txtFiltro.Focus();
            }
        }
        private void frmCadastroCampo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                btnReceber_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnEstorno_Click(sender, e);
            }
        }
        private void txtFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                atualizaGridView();
                if (dgvDados.RowCount > 0)
                {
                    dgvDados.Focus();
                }
                else
                {
                    txtFiltro.Focus();
                }
            }
                
        }
        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnReceber_Click(sender, e);
        }
        private void DgvDados_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnReceber_Click(sender, e);
            }
        }

        private void dgvDados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dgvDados.Rows.Count; i++)
            {
                string val = dgvDados.Rows[i].Cells[3].Value.ToString();
                if (val == "EM ABERTO")
                {
                    dgvDados.Rows[i].DefaultCellStyle.ForeColor = Color.OrangeRed;
                }
                else
                {
                    dgvDados.Rows[i].DefaultCellStyle.ForeColor = Color.Green;
                }
            }
        }
    }

}

