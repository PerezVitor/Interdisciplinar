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
using ShowdeBola;

namespace ShowdeBola
{
    public partial class frmMenu : Form
    {
        Image CloseImage;
        Image closeImageAct;
        public frmMenu()
        {
            InitializeComponent();
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            permitirAcesso(LoginUsuario.getUsuarioId());
            lblUsuarioLogado.Text = LoginUsuario.getUsuarioLogado();
        }

        // Abrir formulário em uma aba ou por a aba em evidência
        private void IniciaFormNaAba(Form frm)
        {
            int index = -1;

            for (int i = 0; i < tabMenu.TabCount; i++)
            {
                if (tabMenu.TabPages[i].Text.Trim() == frm.Text.Trim())
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                tabMenu.SelectedIndex = index;
            }
            else
            {
                TabPage tabForm = new TabPage { Text = frm.Text };

                tabMenu.TabPages.Add(tabForm);

                frm.TopLevel = false;
                frm.Parent = tabForm;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                frm.Show();

                // Seleciona a Tab
                tabMenu.SelectedIndex = tabMenu.TabPages.Count - 1;
            }
        }

        private void permitirAcesso(int usuario)
        {
            Conexao conexao = new Conexao();
            conexao.conectar();
            SqlCommand cmd = new SqlCommand("sp_Sel_UsuarioAcesso", conexao.conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Usuario", usuario);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (dr["Na_Usuario"].ToString() == "FUNCIONÁRIO")
                {
                    //Painel Cadastro
                    btnCadastros.Enabled = true;
                    btnCadCampo.Enabled = true;
                    btnCadCliente.Enabled = true;
                    btnCadUsuario.Enabled = false;
                    //Painel Procedimentos
                    btnProcedimentos.Enabled = true;
                    btnReserva.Enabled = true;
                    //Painel Financeiro
                    btnFinanceiro.Enabled = true;
                    btnCaixa.Enabled = true;
                    //Painel Listagem
                    btnListagem.Enabled = false;
                    btnLisCampo.Enabled = false;
                    btnLisCliente.Enabled = false;
                    btnLisUsuario.Enabled = false;
                    //Painel Relatorios
                    btnRelatorios.Enabled = false;
                    btnRelReserva.Enabled = false;
                    btnRelFinanceiro.Enabled = false;
                }
                conexao.desconectar();
            }

        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            telaInicialBotao(true);
            telaInicialPanel(false);
        }

        private void telaInicialBotao(Boolean valor)
        {
            btnCadastros.Visible = valor;
            btnProcedimentos.Visible = valor;
            btnFinanceiro.Visible = valor;
            btnRelatorios.Visible = valor;
            btnListagem.Visible = valor;
        }

        private void telaInicialPanel(Boolean valor)
        {
            panelCadastro.Visible = valor;
            panelProcedimentos.Visible = valor;
            panelFinanceiro.Visible = valor;
            panelListagem.Visible = valor;
            panelRelatorio.Visible = valor;
        }

        private void btnCadastros_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnCadastros.Height;
            SidePanel.Top = btnCadastros.Top;
            if (panelCadastro.Visible == false)
            {
                telaInicialPanel(false);
                telaInicialBotao(true);
                panelCadastro.Visible = true;
                //btnCadastros.Visible = true;
            }
            else
            {
                telaInicialBotao(true);
                telaInicialPanel(false);
            }
        }

        private void btnProcedimentos_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnProcedimentos.Height;
            SidePanel.Top = btnProcedimentos.Top;
            if (panelProcedimentos.Visible == false)
            {
                telaInicialPanel(false);
                telaInicialBotao(true);
                panelProcedimentos.Visible = true;
                //btnProcedimentos.Visible = true;
                /* panelProcedimentos.Visible = true;
                 btnFinanceiro.Visible = false;
                 btnRelatorios.Visible = false;
                 btnListagem.Visible = false;*/
            }
            else
            {
                telaInicialBotao(true);
                telaInicialPanel(false);
                /*panelProcedimentos.Visible = false;
                btnFinanceiro.Visible = true;
                btnRelatorios.Visible = true;
                btnListagem.Visible = true;*/
            }
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnFinanceiro.Height;
            SidePanel.Top = btnFinanceiro.Top;
            if (panelFinanceiro.Visible == false)
            {
                telaInicialPanel(false);
                telaInicialBotao(true);
                panelFinanceiro.Visible = true;
                //btnFinanceiro.Visible = true;
            }
            else
            {
                telaInicialBotao(true);
                telaInicialPanel(false);
                /*panelFinanceiro.Visible = false;
                btnRelatorios.Visible = true;
                btnListagem.Visible = true;*/
            }
        }

        private void btnListagem_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnListagem.Height;
            SidePanel.Top = btnListagem.Top;
            if (panelListagem.Visible == false)
            {
                telaInicialPanel(false);
                telaInicialBotao(true);
                panelListagem.Visible = true;
                //btnListagem.Visible = true;
            }
            else
            {
                telaInicialBotao(true);
                telaInicialPanel(false);/*
                panelListagem.Visible = false;
                btnRelatorios.Visible = true;*/
            }
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            // telaInicial(false);
            SidePanel.Height = btnRelatorios.Height;
            SidePanel.Top = btnRelatorios.Top;
            if (panelRelatorio.Visible == false)
            {
                telaInicialPanel(false);
                telaInicialBotao(true);
                panelRelatorio.Visible = true;
                //btnRelatorios.Visible = true;
            }
            else
            {
                telaInicialBotao(true);
                telaInicialPanel(false);/*
                panelRelatorio.Visible = false;*/
            }
            /*panelProcedimentos.Visible = false;
            panelFinanceiro.Visible = false;
            panelCadastro.Visible = false;
            panelListagem.Visible = false;*/
        }

        private void btnCadCampo_Click(object sender, EventArgs e)
        {
            IniciaFormNaAba(new frmCadastroCampo());
            panelCadastro.Visible = false;
            tabMenu.Visible = true;
            telaInicialBotao(true);

        }

        private void btnCadCliente_Click(object sender, EventArgs e)
        {
            IniciaFormNaAba(new frmCadastroCliente());
            panelCadastro.Visible = false;
            tabMenu.Visible = true;
            tabMenu.Visible = true;
        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadUsuario_Click(object sender, EventArgs e)
        {
            IniciaFormNaAba(new frmCadastroUsuario());
            panelCadastro.Visible = false;
            tabMenu.Visible = true;
            tabMenu.Visible = true;
        }

        private void btnTrocaSenha_Click(object sender, EventArgs e)
        {
            frmTrocaSenha frmTrocaSenha = new frmTrocaSenha();
            frmTrocaSenha.ShowDialog();
        }

        private void frmMenu_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void tabMenu_DrawItem(object sender, DrawItemEventArgs e)
        {
            Rectangle rect = tabMenu.GetTabRect(e.Index);
            Rectangle imageRec = new Rectangle(rect.Right - CloseImage.Width, rect.Top + (rect.Height - CloseImage.Height) / 2, CloseImage.Width, CloseImage.Height);
            rect.Size = new Size(rect.Width + 50, 50);

            Font f;
            Brush br = Brushes.Black;
            StringFormat strf = new StringFormat(StringFormat.GenericDefault);

            if (tabMenu.SelectedTab == tabMenu.TabPages[e.Index])
            {
                e.Graphics.DrawImage(closeImageAct, imageRec);
                f = new Font("Century Gothic", 11, FontStyle.Regular);

                e.Graphics.DrawString(tabMenu.TabPages[e.Index].Text, f, br, rect, strf);
            }
            else
            {
                e.Graphics.DrawImage(CloseImage, imageRec);
                f = new Font("Century Gothic", 11, FontStyle.Regular);
                e.Graphics.DrawString(tabMenu.TabPages[e.Index].Text, f, br, rect, strf);
            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            tabMenu.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabMenu.DrawItem += tabMenu_DrawItem;
            CloseImage = Properties.Resources.Fechar16;
            closeImageAct = Properties.Resources.Fechar16;
            tabMenu.Padding = new Point(10, 3);
        }

        private void tabMenu_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < tabMenu.TabCount; i++)
            {
                Rectangle rect = tabMenu.GetTabRect(i);
                Rectangle imageRec = new Rectangle(rect.Right - CloseImage.Width, rect.Top + (rect.Height - CloseImage.Height) / 2, CloseImage.Width, CloseImage.Height);

                if (imageRec.Contains(e.Location))
                {
                    tabMenu.TabPages.Remove(tabMenu.SelectedTab);
                }

                if (tabMenu.TabPages.Count == 0)
                {
                    tabMenu.Visible = false;
                }
            }
        }
        
        private void BtnCaixa_Click(object sender, EventArgs e)
        {
            IniciaFormNaAba(new frmControleFinanceiro());
            panelFinanceiro.Visible = false;
            tabMenu.Visible = true;
            tabMenu.Visible = true;
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            IniciaFormNaAba(new frmNovaReserva());
            panelProcedimentos.Visible = false;
            tabMenu.Visible = true;
            tabMenu.Visible = true;
        }


        private void btnLisCampo_Click(object sender, EventArgs e)
        {
            IniciaFormNaAba(new frmListCampo());
            panelListagem.Visible = false;
            tabMenu.Visible = true;
            tabMenu.Visible = true;
        }

        private void btnLisCliente_Click(object sender, EventArgs e)
        {
            IniciaFormNaAba(new frmListCliente());
            panelListagem.Visible = false;
            tabMenu.Visible = true;
            tabMenu.Visible = true;
        }

        private void btnLisUsuario_Click(object sender, EventArgs e)
        {
            IniciaFormNaAba(new frmListUsuario());
            panelListagem.Visible = false;
            tabMenu.Visible = true;
            tabMenu.Visible = true;
        }

        private void btnRelReserva_Click(object sender, EventArgs e)
        {
            IniciaFormNaAba(new frmRelReserva());
            panelRelatorio.Visible = false;
            tabMenu.Visible = true;
            tabMenu.Visible = true;
        }

        private void btnRelFinanceiro_Click(object sender, EventArgs e)
        {
            IniciaFormNaAba(new frmRelFinanceiro());
            panelRelatorio.Visible = false;
            tabMenu.Visible = true;
            tabMenu.Visible = true;
        }
    }
}
