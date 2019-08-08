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
    public partial class frmNovaReserva : Form
    {
        string funcao = string.Empty;
        string filtro = string.Empty;
        string horario = string.Empty;
        int vezes = 0;
        int idReserva = 0;
        public frmNovaReserva()
        {
            InitializeComponent();
            txtFiltro.CharacterCasing = CharacterCasing.Upper;
            txtProcurarNome.CharacterCasing = CharacterCasing.Upper;
            dgvDados.Columns[0].Width = 100;
            dgvDados.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDados.Columns[2].Width = 170;
            dgvDados.Columns[3].Width = 90;
            dgvDados.Columns[4].Width = 250;
            controleBotao(true);
            dtFiltro.Text = DateTime.Now.ToShortDateString();
            limpaCampos();
            LimparCh();
            atualizaGridView();

        }
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
            cmbCampo.Text = string.Empty;
            cmbCampo.SelectedValue = DBNull.Value;
            txtValorCampo.Text = string.Empty;
            dgvClientes.DataSource = DBNull.Value;
            dtpReserva.Value = DateTime.Now.Date;
            txtProcurarNome.Text = "Digite um texto e tecle enter";
            //dgvClientes.Columns[0].Visible = false;
            //dgvClientes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dgvClientes.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            //dgvClientes.Columns[2].Width = 120;
        }

        private void LimparCh()
        {
            foreach (Control item in gbHorarios.Controls)
            {
                if (item is CheckBox)
                {
                    CheckBox ch = new CheckBox();
                    ch = item as CheckBox;
                    ch.Checked = false;
                    ch.Enabled = true;
                }
            }
        }

        private void criatextoHorario()
        {
            horario = " ";
            foreach (Control item in gbHorarios.Controls)
            {
                if (item is CheckBox)
                {
                    CheckBox ch = new CheckBox();
                    ch = item as CheckBox;
                    if (ch.Checked == true && ch.Enabled == true)
                    {
                        horario = horario + " | " + ch.Text;
                        vezes++;
                    }
                }
            }
        }

        private void preencheCbHorarioAdd(string horario)
        {
            foreach (Control item in gbHorarios.Controls)
            {
                if (item is CheckBox)
                {
                    CheckBox ch = new CheckBox();
                    ch = item as CheckBox;
                    if (horario.Contains(ch.Text))
                    {
                        ch.Checked = true;
                        ch.Enabled = false;
                    }
                }
            }
        }

        private void criarFinanceiro(int idReserva, int idUsuario)
        {
            Conexao conexao = new Conexao();
            conexao.conectar();
            SqlCommand cmd = new SqlCommand("sp_Ins_Financeiro", conexao.conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Dt_FINANCEIRO", Convert.ToDateTime(dtpReserva.Text));
            cmd.Parameters.AddWithValue("@ID_HORARIORESERVA", idReserva);
            cmd.Parameters.AddWithValue("@ID_USUARIO", idUsuario);
            cmd.Parameters.AddWithValue("@ST_FINANCEIRO", "True");
            cmd.Parameters.AddWithValue("@STC_FINANCEIRO", "EM ABERTO");
            cmd.Parameters.AddWithValue("@VL_FINANCEIRO", Double.Parse(txtValorCampo.Text.Replace("R$", "")) * vezes);
            cmd.ExecuteReader(CommandBehavior.SingleRow);
            conexao.desconectar();
        }
        //Método para atualizar grid.
        private void atualizaGridView()
        {
            {
                Conexao conexao = new Conexao();
                conexao.conectar();
                SqlCommand cmd = new SqlCommand("sp_Sel_HorariosReserva", conexao.conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ST_Horario", "True");
                cmd.Parameters.AddWithValue("@Dt_Horario", dtFiltro.Value);
                cmd.Parameters.AddWithValue("@NM_Cliente", txtFiltro.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgvDados.DataSource = ds.Tables[0];
                dgvDados.Columns[0].Width = 100;
                dgvDados.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvDados.Columns[2].Width = 170;
                dgvDados.Columns[3].Width = 90;
                dgvDados.Columns[4].Width = 250;
                conexao.desconectar();
            }
        }

        private void preencheCadastro()
        {
            LimparCh();
            Conexao conexao = new Conexao();
            conexao.conectar();
            SqlCommand cmd = new SqlCommand("sp_Sel_HorariosReservaEsp", conexao.conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_HrReserva", dgvDados.CurrentRow.Cells[0].Value);
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);
            horario = string.Empty;
            if (dr.Read())
            {
                horario = dr[("Hora Reservada")].ToString();
                preencheCbHorarioAdd(horario);

            }
            conexao.desconectar();
        }

        private void preencheCadastroAdd()
        {
            LimparCh();
            Conexao conexao = new Conexao();
            conexao.conectar();
            SqlCommand cmd = new SqlCommand("sp_Sel_HorariosReservaAdd", conexao.conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ST_Horario", "True");
            cmd.Parameters.AddWithValue("@Dt_reserva", DateTime.Parse(dtpReserva.Text).ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@Id_Campo", int.Parse(cmbCampo.SelectedValue.ToString()));
            SqlDataReader dr = cmd.ExecuteReader();
            horario = string.Empty;
            while (dr.Read())
            {
                horario = horario + " " + dr[("Hora Reservada")].ToString();
            }
            conexao.desconectar();
            preencheCbHorarioAdd(horario);

        }

        private void Imprimir()
        {
            printReserva.Print();
            printCliente.Print();
        }

        private void DtpReserva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)(Keys.Enter) == e.KeyChar)
            {
                //dgvHorarios.DataSource = null;
                //CarregaDgvHorarios(DateTime.Parse(dtpReserva.Text).ToString("yyyy-MM-dd"), int.Parse(cmbCampo.SelectedValue.ToString()));
                gbHorarios.Text += " " + dtpReserva.Text;
            }
        }

        //private void CarregaGBHorarios(string data_Dtp, int ID_Campo)
        //{
        //    Conexao conexao = new Conexao();
        //    conexao.conectar();
        //    SqlCommand cmdHorarios = new SqlCommand();
        //    cmdHorarios.Connection = conexao.conexao;
        //    cmdHorarios.CommandText = "sp_Sel_HorariosReserva";
        //    cmdHorarios.Parameters.AddWithValue("@DT_Reserva", data_Dtp);
        //    cmdHorarios.Parameters.AddWithValue("@ST_Horario", "True");
        //    cmdHorarios.Parameters.AddWithValue("@ID_Campo", ID_Campo);
        //    cmdHorarios.CommandType = CommandType.StoredProcedure;
        //    SqlDataReader dr = cmdHorarios.ExecuteReader();

        //    DateTime time = DateTime.Parse("08:00");

        //    try
        //    {
        //        if (dr.Read())
        //        {
        //            time.AddMinutes(30);
        //        }
        //        else
        //        {

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        conexao.desconectar();
        //    }
        //}
        //private void PbProcurar_Click(object sender, System.EventArgs e)
        //{

        //}

        private void CarregaCmbCampos()
        {
            Conexao conexao = new Conexao();
            conexao.conectar();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.conexao;
            cmd.CommandText = "sp_Sel_Campo";
            cmd.Parameters.AddWithValue("@DS_CAMPO", "");
            cmd.Parameters.AddWithValue("@ST_CAMPO", "True");
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ds.Fill(dt);

            try
            {
                cmbCampo.DisplayMember = "Nome";
                cmbCampo.ValueMember = "Código";
                cmbCampo.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.desconectar();
            }
        }

        private void CmbCampo_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Conexao conexao = new Conexao();
            conexao.conectar();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.conexao;
            cmd.CommandText = "sp_Sel_Campo";
            cmd.Parameters.AddWithValue("@Ds_Campo", cmbCampo.Text);
            cmd.Parameters.AddWithValue("@ST_CAMPO", "True");
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);

            if (dr.Read())
            {
                txtValorCampo.Text = "R$ " + dr[("Valor")].ToString();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Formata Visual
            SidePanel.Height = btnAdicionar.Height;
            SidePanel.Top = btnAdicionar.Top;

            funcao = "ADICIONAR";
            limpaCampos();
            LimparCh();
            vezes = 0;
            //txtCodigo.Text = "00000";
            controleBotao(false);
            cmbCampo.Focus();
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
                cmbCampo.Focus();
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
                    try
                    {
                        Conexao conexao = new Conexao();
                        conexao.conectar();

                        SqlCommand cmd = new SqlCommand("sp_Del_Horario", conexao.conexao);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID_ID_HrReserva", Convert.ToInt32(dgvDados.CurrentRow.Cells[0].Value));
                        cmd.Parameters.AddWithValue("@ST_CAIXA", "False");
                        cmd.ExecuteReader(CommandBehavior.SingleRow);

                        conexao.desconectar();
                        atualizaGridView();
                    }
                    catch (Exception ex)
                    {

                        if (ex.Message.Contains("foreign key"))
                        {
                            MessageBox.Show("Informe o Excluir! Verifique o financeiro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

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

            horario = string.Empty;
            criatextoHorario();
            //Formata Visual
            SidePanel.Height = btnSalvar.Height;
            SidePanel.Top = btnSalvar.Top;
            //Verifica se todos os campos estão preenchidos
            if (cmbCampo.Text == "" || dtpReserva.Text == "" || dgvClientes.Rows.Count == 0 || vezes == 0)
            {
                //Mensagem para o usuário
                MessageBox.Show("Informe todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Conexao conexao = new Conexao();
                conexao.conectar();

                if (funcao == "ADICIONAR")
                {
                    SqlCommand cmd = new SqlCommand("sp_Ins_HorariosReserva", conexao.conexao);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID_Cliente", dgvClientes.CurrentRow.Cells[0].Value);
                    cmd.Parameters.AddWithValue("@ID_Campo", cmbCampo.SelectedValue);
                    cmd.Parameters.AddWithValue("@HR_Reservada", horario.Trim());
                    cmd.Parameters.AddWithValue("@ST_Horario", "True");
                    cmd.Parameters.AddWithValue("@DT_Reserva", dtpReserva.Value);
                    cmd.Parameters.AddWithValue("@TP_Reservado", 1);
                    cmd.Parameters.AddWithValue("@Vl_Reserva", Double.Parse(txtValorCampo.Text.Replace("R$", "")) * vezes);
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);
                    if (dr.Read())
                    {
                        idReserva = int.Parse(dr[("Retorno")].ToString());
                        criarFinanceiro(idReserva, LoginUsuario.getUsuarioId());
                    }
                    else
                    {
                        idReserva = 0;
                    }
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("sp_Ins_HorariosReserva", conexao.conexao);
                    cmd.Parameters.AddWithValue("@ID_Cliente", dgvClientes.CurrentRow.Cells[0].Value);
                    cmd.Parameters.AddWithValue("@ID_Campo", cmbCampo.SelectedValue);
                    cmd.Parameters.AddWithValue("@HR_Reservada", " ");//Verificar CheckBox
                    cmd.Parameters.AddWithValue("@ST_Horario", "True");
                    cmd.Parameters.AddWithValue("@DT_Reserva", dtpReserva.Value);
                    cmd.Parameters.AddWithValue("@TP_Reservado", 1);
                    cmd.Parameters.AddWithValue("@Vl_Reserva", Double.Parse(txtValorCampo.Text.Replace("R$", "")));
                    cmd.ExecuteReader(CommandBehavior.SingleRow);
                }
                conexao.desconectar();
                DialogResult iResposta;
                iResposta = MessageBox.Show("Deseja receber a reserva?", "Confirmar!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (iResposta.ToString() == "Yes")
                {
                    LoginUsuario.reserva(Convert.ToInt32(idReserva));
                    frmRecebimento frmRecebimento = new frmRecebimento();
                    frmRecebimento.ShowDialog();
                }
                iResposta = MessageBox.Show("Deseja imprimir o comprovante?", "Confirmar!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (iResposta.ToString() == "Yes")
                {
                    Imprimir();
                }
                controleBotao(true);
                atualizaGridView();
                idReserva = 0;
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
                filtro = "NOME";
                atualizaGridView();
                if (dgvDados.RowCount != 0)
                {
                    dgvDados.Focus();
                }
                else
                {
                    txtFiltro.Focus();
                }
            }
        }
        private void dtFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                filtro = "DATA";
                atualizaGridView();
                if (dgvDados.RowCount != 0)
                {
                    dgvDados.Focus();
                }
                else
                {
                    dtFiltro.Focus();
                }
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

        private void cmbCampo_DropDown(object sender, EventArgs e)
        {
            CarregaCmbCampos();
        }

        private void txtProcurarNome_KeyDown(object sender, KeyEventArgs e)
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
                    cmd.Parameters.AddWithValue("@NM_CLIENTE", txtProcurarNome.Text);
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
                    conexao.desconectar();
                    dgvClientes.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                dtpReserva_KeyDown(sender, e);
            }
        }

        private void dtpReserva_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmbCampo.Text == "")
                {
                    MessageBox.Show("Informe o campos da reserva!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    preencheCadastroAdd();
                }
            }
        }
        private void DgvClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                cbOito.Focus();
            }
        }

        private void PrintReserva_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Conexao conexao = new Conexao();
            conexao.conectar();
            SqlCommand cmd = new SqlCommand("sp_Sel_HorariosReservaEsp", conexao.conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_HrReserva", dgvDados.CurrentRow.Cells[0].Value);
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);
            if (dr.Read())
            {
                try
                {

                    e.Graphics.DrawString("--------------------------------------------------------", new Font("arial", 11, FontStyle.Bold), Brushes.Black, 0, 0); //TEXTO SHOW DE BOLA
                    e.Graphics.DrawString("-------- SHOW DE BOLA------------------------", new Font("arial", 12, FontStyle.Bold), Brushes.Black, 0, 17); //TEXTO SHOW DE BOLA
                    e.Graphics.DrawString("--------------------------------------------------------", new Font("arial", 11, FontStyle.Bold), Brushes.Black, 0, 34); //TEXTO SHOW DE BOLA

                    e.Graphics.DrawString("DATA: " + DateTime.Parse(dr[("Data Reserva")].ToString()).ToString("dd/MM/yyyy") + "", new Font("arial", 12, FontStyle.Bold), Brushes.Black, 0, 57); //TEXTO DATA

                    e.Graphics.DrawString("CLIENTE: ", new Font("arial", 12, FontStyle.Italic), Brushes.Black, 0, 75); //TEXTO CLIENTE
                    e.Graphics.DrawString(dr[("Nome Cliente")].ToString() + "", new Font("arial", 12, FontStyle.Bold), Brushes.Black, 0, 90); //NOME CLIENTE

                    e.Graphics.DrawString("CAMPO RESERVADO: ", new Font("arial", 12, FontStyle.Italic), Brushes.Black, 0, 110); //TEXTO CAMPO RESERVADO
                    e.Graphics.DrawString(dr[("Nome Campo")].ToString() + "", new Font("arial", 12, FontStyle.Bold), Brushes.Black, 0, 130); //CAMPO RESERVADO

                    e.Graphics.DrawString("DIA RESERVADO:", new Font("arial", 12, FontStyle.Italic), Brushes.Black, 0, 150); //TEXTO DIA RESERVADO
                    e.Graphics.DrawString(DateTime.Parse(dr[("Data Reserva")].ToString()).ToString("dd/MM/yyyy") + "", new Font("arial", 12, FontStyle.Bold), Brushes.Black, 0, 170); //DIA RESERVADO

                    e.Graphics.DrawString("NOS HORARIOS:", new Font("arial", 12, FontStyle.Italic), Brushes.Black, 0, 190); //TEXTO HORARIO
                    e.Graphics.DrawString(dr[("Hora Reservada")].ToString() + "", new Font("arial", 12, FontStyle.Bold), Brushes.Black, 0, 210); //HORARIO

                    e.Graphics.DrawString("VALOR DA RESERVA", new Font("arial", 12, FontStyle.Italic), Brushes.Black, 0, 230); //TEXTO VALOR
                    e.Graphics.DrawString(double.Parse(dr[("Valor Reserva")].ToString()).ToString("C") + "", new Font("arial", 12, FontStyle.Bold), Brushes.Black, 0, 250); //VALOR RESERVA
                    e.Graphics.DrawString("______________________________________________", new Font("arial", 12, FontStyle.Bold), Brushes.Black, 0, 320); //LINHA ASSINATURA
                    e.Graphics.DrawString("" + dr[("Nome Cliente")].ToString() + "", new Font("arial", 12, FontStyle.Bold), Brushes.Black, 0, 340); //NOME CLIENTE
                    e.Graphics.DrawString("RESERVA " + int.Parse(dr[("Código Reserva")].ToString()) + "", new Font("arial", 12, FontStyle.Bold), Brushes.Black, 80, 355); //CODIGO RESERVA
                    e.Graphics.DrawString("______________________________________________", new Font("arial", 12, FontStyle.Bold), Brushes.Black, 0, 356); //FIM
                    e.Graphics.DrawString("VIA CAIXA", new Font("arial", 12, FontStyle.Bold), Brushes.Black, 0, 376); //FIM
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conexao.desconectar();
            }
        }


        private void txtProcurarNome_Enter(object sender, EventArgs e)
        {
            txtProcurarNome.Text = string.Empty;
        }

        private void txtProcurarNome_Leave(object sender, EventArgs e)
        {
            txtProcurarNome.Text = "Digite um texto e tecle enter";
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void printCliente_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Conexao conexao = new Conexao();
            conexao.conectar();
            SqlCommand cmd = new SqlCommand("sp_Sel_HorariosReservaEsp", conexao.conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_HrReserva", dgvDados.CurrentRow.Cells[0].Value);
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);
            if (dr.Read())
            {
                try
                {

                    e.Graphics.DrawString("--------------------------------------------------------", new Font("arial", 11, FontStyle.Bold), Brushes.Black, 0, 0); //TEXTO SHOW DE BOLA
                    e.Graphics.DrawString("-------- SHOW DE BOLA------------------------", new Font("arial", 12, FontStyle.Bold), Brushes.Black, 0, 17); //TEXTO SHOW DE BOLA
                    e.Graphics.DrawString("--------------------------------------------------------", new Font("arial", 11, FontStyle.Bold), Brushes.Black, 0, 34); //TEXTO SHOW DE BOLA

                    e.Graphics.DrawString("DATA: " + DateTime.Parse(dr[("Data Reserva")].ToString()).ToString("dd/MM/yyyy") + "", new Font("arial", 12, FontStyle.Bold), Brushes.Black, 0, 57); //TEXTO DATA

                    e.Graphics.DrawString("CLIENTE: ", new Font("arial", 12, FontStyle.Italic), Brushes.Black, 0, 75); //TEXTO CLIENTE
                    e.Graphics.DrawString(dr[("Nome Cliente")].ToString() + "", new Font("arial", 12, FontStyle.Bold), Brushes.Black, 0, 90); //NOME CLIENTE

                    e.Graphics.DrawString("CAMPO RESERVADO: ", new Font("arial", 12, FontStyle.Italic), Brushes.Black, 0, 110); //TEXTO CAMPO RESERVADO
                    e.Graphics.DrawString(dr[("Nome Campo")].ToString() + "", new Font("arial", 12, FontStyle.Bold), Brushes.Black, 0, 130); //CAMPO RESERVADO

                    e.Graphics.DrawString("DIA RESERVADO:", new Font("arial", 12, FontStyle.Italic), Brushes.Black, 0, 150); //TEXTO DIA RESERVADO
                    e.Graphics.DrawString(DateTime.Parse(dr[("Data Reserva")].ToString()).ToString("dd/MM/yyyy") + "", new Font("arial", 12, FontStyle.Bold), Brushes.Black, 0, 170); //DIA RESERVADO

                    e.Graphics.DrawString("NOS HORARIOS:", new Font("arial", 12, FontStyle.Italic), Brushes.Black, 0, 190); //TEXTO HORARIO
                    e.Graphics.DrawString(dr[("Hora Reservada")].ToString() + "", new Font("arial", 12, FontStyle.Bold), Brushes.Black, 0, 210); //HORARIO

                    e.Graphics.DrawString("VALOR DA RESERVA", new Font("arial", 12, FontStyle.Italic), Brushes.Black, 0, 230); //TEXTO VALOR
                    e.Graphics.DrawString(double.Parse(dr[("Valor Reserva")].ToString()).ToString("C") + "", new Font("arial", 12, FontStyle.Bold), Brushes.Black, 0, 250); //VALOR RESERVA
                    e.Graphics.DrawString("______________________________________________", new Font("arial", 12, FontStyle.Bold), Brushes.Black, 0, 250); //LINHA ASSINATURA
                    e.Graphics.DrawString("" + dr[("Nome Cliente")].ToString() + "", new Font("arial", 12, FontStyle.Bold), Brushes.Black, 0, 271); //NOME CLIENTE
                    e.Graphics.DrawString("RESERVA " + int.Parse(dr[("Código Reserva")].ToString()) + "", new Font("arial", 12, FontStyle.Bold), Brushes.Black, 80, 291); //CODIGO RESERVA
                    e.Graphics.DrawString("______________________________________________", new Font("arial", 12, FontStyle.Bold), Brushes.Black, 0, 292); //FIM
                    e.Graphics.DrawString("VIA CLIENTE", new Font("arial", 12, FontStyle.Bold), Brushes.Black, 0, 312); //FIM
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conexao.desconectar();
            }
        }
    }
}

