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
    public partial class frmCadastroCampo : Form
    {
        string funcao = string.Empty;
        public frmCadastroCampo()
        {
            InitializeComponent();
            atualizaGridView();
            controleBotao(true);
            limpaCampos();
            txtFiltro.CharacterCasing = CharacterCasing.Upper;
            txtDescricao.CharacterCasing = CharacterCasing.Upper;
        }
        //Método de controle dos botões.
        private void controleBotao(Boolean valor)
        {
            btnAdicionar.Enabled = valor;
            btnEditar.Enabled = valor;
            btnExcluir.Enabled = valor;
            btnAtualizar.Enabled = valor;
            btnSalvar.Enabled = !valor;
            btnCancelar.Enabled = !valor;
            btnFiltro.Enabled = valor;
            pnlDados.Visible = !valor;
            dgvDados.Visible = valor;
            if (valor == true)
            {
                dgvDados.Focus();
            }
        }
        private void limpaCampos()
        {
            txtCodigo.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtValor.Text = "0.00";
            txtCodigo.Enabled = false;
        }
        //Método para atualizar grid.
        private void atualizaGridView()
        {
            Conexao conexao = new Conexao();
            conexao.conectar();
            SqlCommand cmd = new SqlCommand("sp_Sel_Campo", conexao.conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ST_CAMPO", "True");
            if (panelFiltro.Visible == false)
            {
                cmd.Parameters.AddWithValue("@DS_CAMPO", "");
            }
            else
            {
                cmd.Parameters.AddWithValue("@DS_CAMPO", txtFiltro.Text);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvDados.DataSource = ds.Tables[0];
            dgvDados.Columns[0].Width = 100;
            dgvDados.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDados.Columns[2].Width = 100;
            conexao.desconectar();

        }
        private void preencheCadastro()
        {
            Conexao conexao = new Conexao();
            conexao.conectar();
            SqlCommand cmd = new SqlCommand("sp_Sel_CampoEsp", conexao.conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_CAMPO", dgvDados.CurrentRow.Cells[0].Value);
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);
            if (dr.Read())
            {
                txtCodigo.Text = dr[("ID_CAMPO")].ToString();
                txtCodigo.Text = txtCodigo.Text.PadLeft(5, '0');
                txtDescricao.Text = dr[("DS_CAMPO")].ToString();
                txtValor.Text = dr[("VL_CAMPO")].ToString();
            }
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Formata Visual
            SidePanel.Height = btnAdicionar.Height;
            SidePanel.Top = btnAdicionar.Top;

            funcao = "ADICIONAR";
            limpaCampos();
            txtCodigo.Text = "00000";
            controleBotao(false);
            txtDescricao.Focus();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Formata Visual
            SidePanel.Height = btnEditar.Height;
            SidePanel.Top = btnEditar.Top;

            if (dgvDados.RowCount > 0)
            {
                funcao = "EDITAR";
                preencheCadastro();
                controleBotao(false);
                txtDescricao.Focus();
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Formata Visual
            SidePanel.Height = btnExcluir.Height;
            SidePanel.Top = btnExcluir.Top;
            if (dgvDados.RowCount > 0)
            {
                //Mensagem para o usuário
                DialogResult iResposta;
                iResposta = MessageBox.Show("Deseja realmente excluir?", "Confirmar!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (iResposta.ToString() == "Yes")
                {
                    Conexao conexao = new Conexao();
                    conexao.conectar();

                    SqlCommand cmd = new SqlCommand("sp_Del_Campo", conexao.conexao);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID_CAMPO", Convert.ToInt32(dgvDados.CurrentRow.Cells[0].Value));
                    cmd.ExecuteReader(CommandBehavior.SingleRow);

                    conexao.desconectar();
                    atualizaGridView();
                }
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Formata Visual
            SidePanel.Height = btnCancelar.Height;
            SidePanel.Top = btnCancelar.Top;
            //Mensagem para o usuário
            DialogResult iResposta;
            iResposta = MessageBox.Show("Deseja realmente cancelar?", "Confirmar!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (iResposta.ToString() == "Yes")
            {
                controleBotao(true);
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Formata Visual
            SidePanel.Height = btnSalvar.Height;
            SidePanel.Top = btnSalvar.Top;
            //Verifica se todos os campos estão preenchidos
            if (txtDescricao.Text == "" || txtValor.Text == "")
            {
                //Mensagem para o usuário
                MessageBox.Show("Informe todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Conexao conexao = new Conexao();
                conexao.conectar();

                if (funcao == "ADICIONAR")
                {
                    SqlCommand cmd = new SqlCommand("sp_Ins_Campo", conexao.conexao);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DS_CAMPO", txtDescricao.Text);
                    cmd.Parameters.AddWithValue("@VL_CAMPO", double.Parse(txtValor.Text));
                    cmd.Parameters.AddWithValue("@ST_CAMPO", "True");
                    cmd.ExecuteReader(CommandBehavior.SingleRow);

                }
                else
                {
                    SqlCommand cmd = new SqlCommand("sp_Upd_Campo", conexao.conexao);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DS_CAMPO", txtDescricao.Text);
                    cmd.Parameters.AddWithValue("@VL_CAMPO", double.Parse(txtValor.Text));
                    cmd.Parameters.AddWithValue("@ID_CAMPO", Convert.ToInt32(txtCodigo.Text));
                    cmd.Parameters.AddWithValue("@ST_CAMPO", "True");
                    cmd.ExecuteReader(CommandBehavior.SingleRow);
                }
                conexao.desconectar();

                controleBotao(true);
                atualizaGridView();
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
            if (e.KeyCode == Keys.F2)
            {
                btnAdicionar_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F4)
            {
                btnEditar_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnExcluir_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F12)
            {
                btnSalvar_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                if (btnCancelar.Enabled == true)
                {
                    btnCancelar_Click(sender, e);
                }
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
        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (txtValor.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }
            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar_Click(sender, e);
        }
        private void DgvDados_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (pnlDados.Visible == false)
                {
                    btnEditar_Click(sender, e);
                }
            }
        }
    }
}
