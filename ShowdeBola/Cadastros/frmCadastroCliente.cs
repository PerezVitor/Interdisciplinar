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
using ShowdeBola.Classes;

namespace ShowdeBola
{
    public partial class frmCadastroCliente : Form
    {
        string funcao = string.Empty;
        public frmCadastroCliente()
        {
            InitializeComponent();
            txtNome.CharacterCasing = CharacterCasing.Upper;
            txtEnd.CharacterCasing = CharacterCasing.Upper;
            txtComplemento.CharacterCasing = CharacterCasing.Upper;
            txtBairro.CharacterCasing = CharacterCasing.Upper;
            txtCidade.CharacterCasing = CharacterCasing.Upper;
            txtUf.CharacterCasing = CharacterCasing.Upper;
            txtObs.CharacterCasing = CharacterCasing.Upper;
            txtFiltro.CharacterCasing = CharacterCasing.Upper;
            controleBotao(true);
            limpaCampos();
            atualizaGridView();
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
            txtNome.Text = string.Empty;

            txtRg.Text = string.Empty;
            txtCpf.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtCelular.Text = string.Empty;
            txtEnd.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtComplemento.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtCep.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtUf.Text = string.Empty;
            txtObs.Text = string.Empty;

            txtCodigo.Enabled = false;
        }
        //Método para atualizar grid.
        private void atualizaGridView()
        {
            Conexao conexao = new Conexao();
            conexao.conectar();
            SqlCommand cmd = new SqlCommand("sp_Sel_Cliente", conexao.conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ST_CLIENTE", "True");
            cmd.Parameters.AddWithValue("@CELULAR_CLIENTE", "");
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
            dgvDados.Columns[2].Width = 150;
            conexao.desconectar();
        }
        private void preencheCadastro()
        {
            Conexao conexao = new Conexao();
            conexao.conectar();
            SqlCommand cmd = new SqlCommand("sp_Sel_ClienteEsp", conexao.conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_CLIENTE", dgvDados.CurrentRow.Cells[0].Value);
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);
            if (dr.Read())
            {
                txtCodigo.Text = dr[("ID_CLIENTE")].ToString();
                txtCodigo.Text = txtCodigo.Text.PadLeft(5, '0');
                txtNome.Text = dr[("NM_Cliente")].ToString();
                txtRg.Text = dr[("RG_CLIENTE")].ToString();
                txtCpf.Text = dr[("CPF_CLIENTE")].ToString();
                txtTelefone.Text = dr[("TELEFONE_CLIENTE")].ToString();
                txtCelular.Text = dr[("CELULAR_CLIENTE")].ToString();
                txtEnd.Text = dr[("ENDERECO_CLIENTE")].ToString();
                txtComplemento.Text = dr[("COMPLEMENTO_CLIENTE")].ToString();
                txtNumero.Text = dr[("NUMERO_CLIENTE")].ToString();
                txtBairro.Text = dr[("BAIRRO_CLIENTE")].ToString();
                txtCep.Text = dr[("CEP_CLIENTE")].ToString();
                txtCidade.Text = dr[("CIDADE_CLIENTE")].ToString();
                txtUf.Text = dr[("ESTADO_CLIENTE")].ToString();
                txtObs.Text = dr[("OBS_CLIENTE")].ToString();

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
            txtNome.Focus();
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
                txtNome.Focus();
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

                    SqlCommand cmd = new SqlCommand("sp_Del_Cliente", conexao.conexao);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID_CLIENTE", Convert.ToInt32(dgvDados.CurrentRow.Cells[0].Value));
                    cmd.Parameters.AddWithValue("@ST_CLIENTE", "False");
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
            if (ValidaCPF.IsCpf(txtCpf.Text))
            {
                if (txtNome.Text == "" || txtRg.Text == "" || txtCpf.Text == "" || txtTelefone.Text == "" || txtCelular.Text == "" || txtEnd.Text == "" || txtNumero.Text == "" || txtComplemento.Text == "" || txtBairro.Text == "" || txtCep.Text == "" || txtCidade.Text == "" || txtUf.Text == "")
                {
                    //Mensagem para o usuário
                    MessageBox.Show("Informe todos os campos!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Conexao conexao = new Conexao();
                    conexao.conectar();

                    if (funcao == "ADICIONAR")
                    {
                        SqlCommand cmd = new SqlCommand("sp_Ins_Cliente", conexao.conexao);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@NM_CLIENTE", txtNome.Text);
                        cmd.Parameters.AddWithValue("@RG_CLIENTE", txtRg.Text);
                        cmd.Parameters.AddWithValue("@CPF_CLIENTE", txtCpf.Text);
                        cmd.Parameters.AddWithValue("@TELEFONE_CLIENTE", txtTelefone.Text);
                        cmd.Parameters.AddWithValue("@CELULAR_CLIENTE", txtCelular.Text);
                        cmd.Parameters.AddWithValue("@ENDERECO_CLIENTE", txtEnd.Text);
                        cmd.Parameters.AddWithValue("@NUMERO_CLIENTE", txtNumero.Text);
                        cmd.Parameters.AddWithValue("@COMPLEMENTO_CLIENTE", txtComplemento.Text);
                        cmd.Parameters.AddWithValue("@BAIRRO_CLIENTE", txtBairro.Text);
                        cmd.Parameters.AddWithValue("@CEP_CLIENTE", txtCep.Text);
                        cmd.Parameters.AddWithValue("@CIDADE_CLIENTE", txtCidade.Text);
                        cmd.Parameters.AddWithValue("@ESTADO_CLIENTE", txtUf.Text);
                        cmd.Parameters.AddWithValue("@OBS_CLIENTE", txtObs.Text);
                        cmd.Parameters.AddWithValue("@ST_CLIENTE", "True");
                        cmd.ExecuteReader(CommandBehavior.SingleRow);

                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("sp_Upd_Cliente", conexao.conexao);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID_CLIENTE", Convert.ToInt32(txtCodigo.Text));
                        cmd.Parameters.AddWithValue("@NM_CLIENTE", txtNome.Text);
                        cmd.Parameters.AddWithValue("@RG_CLIENTE", txtRg.Text);
                        cmd.Parameters.AddWithValue("@CPF_CLIENTE", txtCpf.Text);
                        cmd.Parameters.AddWithValue("@TELEFONE_CLIENTE", txtTelefone.Text);
                        cmd.Parameters.AddWithValue("@CELULAR_CLIENTE", txtCelular.Text);
                        cmd.Parameters.AddWithValue("@ENDERECO_CLIENTE", txtEnd.Text);
                        cmd.Parameters.AddWithValue("@NUMERO_CLIENTE", txtNumero.Text);
                        cmd.Parameters.AddWithValue("@COMPLEMENTO_CLIENTE", txtComplemento.Text);
                        cmd.Parameters.AddWithValue("@BAIRRO_CLIENTE", txtBairro.Text);
                        cmd.Parameters.AddWithValue("@CEP_CLIENTE", txtCep.Text);
                        cmd.Parameters.AddWithValue("@CIDADE_CLIENTE", txtCidade.Text);
                        cmd.Parameters.AddWithValue("@ESTADO_CLIENTE", txtUf.Text);
                        cmd.Parameters.AddWithValue("@OBS_CLIENTE", txtObs.Text);
                        cmd.Parameters.AddWithValue("@ST_CLIENTE", "True");
                        cmd.ExecuteReader(CommandBehavior.SingleRow);
                    }
                    conexao.desconectar();

                    controleBotao(true);
                    atualizaGridView();
                }
            }
            else
            {
                MessageBox.Show("CPF Inválido!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void frmCadastroCliente_KeyDown(object sender, KeyEventArgs e)
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

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (txtNome.Text.Contains(","))
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
