using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ShowdeBola
{
    public partial class frmTrocaSenha : Form
    {
        string usuario;
        public frmTrocaSenha()
        {

            InitializeComponent();
            txtUsuario.CharacterCasing = CharacterCasing.Upper;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Verifica se as senhas novas são iguais.
            if (txtSenha1.Text != txtSenha2.Text)
            {
                MessageBox.Show("Senhas NOVAS estão Diferentes! Tente Novamente ...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Verifica se a senha atual é igual a informada, se 'SIM', Altera a senha. 
                Conexao conexao = new Conexao();
                conexao.conectar();
                SqlCommand cmd = new SqlCommand("sp_Sel_UsuarioSenha", conexao.conexao);
                cmd.Parameters.AddWithValue("@Nm_Usuario", txtUsuario.Text);
                cmd.Parameters.AddWithValue("@Sh_Usuario", txtSenha.Text);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    //Altera a senha.
                    Conexao conexaoUpdate = new Conexao();
                    conexaoUpdate.conectar();
                    SqlCommand cmdUpdate = new SqlCommand("sp_Upd_UsuarioSenha", conexaoUpdate.conexao);
                    cmdUpdate.Parameters.AddWithValue("@Id_Usuario", LoginUsuario.getUsuarioId());
                    cmdUpdate.Parameters.AddWithValue("@Sh_Usuario", txtSenha1.Text.ToUpper());
                    cmdUpdate.CommandType = CommandType.StoredProcedure;
                    cmdUpdate.ExecuteReader(CommandBehavior.SingleRow);
                    conexaoUpdate.desconectar();
                    MessageBox.Show("Senha Alterada com SUCESSO!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    conexao.desconectar();
                    MessageBox.Show("Senhas ANTIGA é Diferente! Tente Novamente ...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSenha.Focus();
                }
            }
        }

        private void frmTrocaSenha_Load(object sender, EventArgs e)
        {
            //Busca o usuario logado e preenche o textbox.
            txtUsuario.Text = LoginUsuario.getUsuarioLogado().Replace("Usuário: ", "");
            usuario = txtUsuario.Text;
            txtSenha.Focus();
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            //Formata o campo visualmente e altera a propriedade mascara de senha.
            if (txtSenha.Text == "Senha atual")
            {
                txtSenha.UseSystemPasswordChar = true;
                txtSenha.Text = string.Empty;
            }
        }
        private void txtSenha1_Enter(object sender, EventArgs e)
        {
            //Formata o campo visualmente e altera a propriedade mascara de senha.
            if (txtSenha.Text == "")
            {
                txtSenha.UseSystemPasswordChar = false;
                txtSenha.Text = "Senha atual";
                txtSenha1.Focus();
            }
            if (txtSenha1.Text == "Nova senha")
            {
                txtSenha1.UseSystemPasswordChar = true;
                txtSenha1.Text = string.Empty;
            }
        }
        //Evento texto
        private void txtSenha2_Enter(object sender, EventArgs e)
        {
            //Formata o campo visualmente e altera a propriedade mascara de senha.
            if (txtSenha1.Text == "")
            {
                txtSenha1.UseSystemPasswordChar = false;
                txtSenha1.Text = "Nova senha";
                txtSenha2.Focus();
            }
            if (txtSenha2.Text == "Nova senha")
            {
                txtSenha2.UseSystemPasswordChar = true;
                txtSenha2.Text = string.Empty;
            }
        }
        //Evento texto
        private void btnSalvar_Enter(object sender, EventArgs e)
        {
            //Formata o campo visualmente e altera a propriedade mascara de senha.
            if (txtSenha2.Text == "")
            {
                txtSenha2.UseSystemPasswordChar = false;
                txtSenha2.Text = "Nova senha";
                btnSalvar.Focus();
            }
        }
    }

}
