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
using ShowdeBola.Properties;

namespace ShowdeBola
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtUsuario.CharacterCasing = CharacterCasing.Upper;
            txtSenha.CharacterCasing = CharacterCasing.Upper;
            txtUsuario.Focus();
        }
        //Evento efetur login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            conexao.conectar();
            SqlCommand cmd = new SqlCommand("sp_Sel_UsuarioLogin", conexao.conexao);
            cmd.Parameters.AddWithValue("@Nm_Usuario", txtUsuario.Text);
            cmd.Parameters.AddWithValue("@Sh_Usuario", txtSenha.Text);
            cmd.Parameters.AddWithValue("@St_Usuario", "True");
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                LoginUsuario.login(dr["NM_USUARIO"].ToString(), dr["SH_USUARIO"].ToString(), Convert.ToInt32(dr["ID_USUARIO"]));
                txtUsuario.Enabled = false;
                txtSenha.Enabled = false;
                btnLogin.Enabled = false;
                Settings.Default.UltimoLogin = txtUsuario.Text;
                Settings.Default.Save();
                frmMenu frmMenu = new frmMenu();
                this.Hide();
                frmMenu.Show();
            }
            else
            {
                MessageBox.Show("Usuário/Senha Inválidos! Tente Novamente ...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dr.Close();
            conexao.desconectar();
        }
        //Evento login na tecla enter.
        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
        //Evento carregar ultimo usuario logado.
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = Settings.Default.UltimoLogin;

            if (txtUsuario.Text == Settings.Default.UltimoLogin)
            {
                txtSenha.Focus();
            }
        }
        //Evento fechar a aplicação.
        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Controle de texto
        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            txtSenha.Text = string.Empty;
        }
        //Controle de texto
        private void TxtSenha_TextChanged(object sender, EventArgs e)
        {
            var txt = sender as TextBox;
            txt.UseSystemPasswordChar = true;
        }
        //Controle de texto
        private void TxtSenha_Leave(object sender, EventArgs e)
        {
            var txt = sender as TextBox;
            if (txt.Text == string.Empty)
            {
                txt.UseSystemPasswordChar = false;
                txt.Text = "Senha";
            }
        }
        //Controle focus
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Focus();
            }
            else
            {
                txtSenha.Focus();
            }
        }
        //Controle focus
        private void TxtSenha_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuário")
            {
                txtUsuario.Focus();
            }
        }
    }
}

