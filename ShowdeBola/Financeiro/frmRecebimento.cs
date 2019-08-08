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
    public partial class frmRecebimento : Form
    {
        public frmRecebimento()
        {
            InitializeComponent();
            preencheCadastro();
        }
        //Metodo preencher tela com dados.
        public void preencheCadastro()
        {
            Conexao conexao = new Conexao();
            conexao.conectar();
            SqlCommand cmd = new SqlCommand("sp_Sel_FinanceiroEsp", conexao.conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_HORARIORESERVA", LoginUsuario.getReserva());
            cmd.Parameters.AddWithValue("@ST_FINANCEIRO", "True");
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);
            if (dr.Read())
            {
                lblCliente.Text = dr[("Nome Cliente")].ToString();
                lblValor.Text = "R$ " + dr[("Valor").ToString()];
            }
            conexao.desconectar();
        }
        //Evento salvar o recebimento.
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtValor.Text == "")
            {
                return;
            }
            if (Double.Parse(txtValor.Text) < Double.Parse(lblValor.Text.Replace("R$", "")))
            {
                MessageBox.Show("Valor recebido menor que o valor da reserva!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Conexao conexao = new Conexao();
                conexao.conectar();
                SqlCommand cmd = new SqlCommand("sp_Upd_Financeiro", conexao.conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@STC_FINANCEIRO", "PAGO");
                cmd.Parameters.AddWithValue("@ID_HORARIORESERVA", LoginUsuario.getReserva());
                cmd.Parameters.AddWithValue("@FP_FINANCEIRO", cmbFormaPgto.Text);
                cmd.Parameters.AddWithValue("@DT_PAGAMENTO", DateTime.Now.ToShortDateString());
                cmd.ExecuteReader(CommandBehavior.SingleRow);
                conexao.desconectar();
                MessageBox.Show("Troco: " + (Double.Parse(txtValor.Text) - Double.Parse(lblValor.Text.Replace("R$", ""))).ToString("C"), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Concluído com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        //Teclas de acessibilidade.
        private void frmRecebimento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                btnSalvar_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        //Tratar somente numeros e Troca ponto por virgula.
        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.KeyChar = ',';
                if (txtValor.Text.Contains(","))
                {
                    e.Handled = true;
                }
            }
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        //Evento salvar na tecla enter.
        private void txtValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSalvar_Click(sender, e);
            }
        }
    }
}
