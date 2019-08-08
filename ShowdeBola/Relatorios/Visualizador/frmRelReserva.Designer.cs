namespace ShowdeBola
{
    partial class frmRelReserva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.v_HorarioReservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DB_Show_De_BolaDataSet = new ShowdeBola.DB_Show_De_BolaDataSet();
            this.rptVisualizador = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelBotoes = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnZoom = new System.Windows.Forms.Button();
            this.btnUltima = new System.Windows.Forms.Button();
            this.btnPrimeira = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProxima = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.v_HorarioReservaTableAdapter = new ShowdeBola.DB_Show_De_BolaDataSetTableAdapters.v_HorarioReservaTableAdapter();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtInicial = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCampos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCampo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtFinal = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.v_HorarioReservaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_Show_De_BolaDataSet)).BeginInit();
            this.panelBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampos)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // v_HorarioReservaBindingSource
            // 
            this.v_HorarioReservaBindingSource.DataMember = "v_HorarioReserva";
            this.v_HorarioReservaBindingSource.DataSource = this.DB_Show_De_BolaDataSet;
            // 
            // DB_Show_De_BolaDataSet
            // 
            this.DB_Show_De_BolaDataSet.DataSetName = "DB_Show_De_BolaDataSet";
            this.DB_Show_De_BolaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptVisualizador
            // 
            this.rptVisualizador.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.v_HorarioReservaBindingSource;
            this.rptVisualizador.LocalReport.DataSources.Add(reportDataSource1);
            this.rptVisualizador.LocalReport.ReportEmbeddedResource = "ShowdeBola.Relatorios.Relatorio.rptRelHorarioReserva.rdlc";
            this.rptVisualizador.Location = new System.Drawing.Point(209, 107);
            this.rptVisualizador.Name = "rptVisualizador";
            this.rptVisualizador.ShowBackButton = false;
            this.rptVisualizador.ShowContextMenu = false;
            this.rptVisualizador.ShowCredentialPrompts = false;
            this.rptVisualizador.ShowDocumentMapButton = false;
            this.rptVisualizador.ShowExportButton = false;
            this.rptVisualizador.ShowFindControls = false;
            this.rptVisualizador.ShowPageNavigationControls = false;
            this.rptVisualizador.ShowParameterPrompts = false;
            this.rptVisualizador.ShowPrintButton = false;
            this.rptVisualizador.ShowProgress = false;
            this.rptVisualizador.ShowPromptAreaButton = false;
            this.rptVisualizador.ShowRefreshButton = false;
            this.rptVisualizador.ShowStopButton = false;
            this.rptVisualizador.ShowToolBar = false;
            this.rptVisualizador.ShowZoomControl = false;
            this.rptVisualizador.Size = new System.Drawing.Size(703, 413);
            this.rptVisualizador.TabIndex = 4;
            // 
            // panelBotoes
            // 
            this.panelBotoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panelBotoes.Controls.Add(this.SidePanel);
            this.panelBotoes.Controls.Add(this.btnZoom);
            this.panelBotoes.Controls.Add(this.btnUltima);
            this.panelBotoes.Controls.Add(this.btnPrimeira);
            this.panelBotoes.Controls.Add(this.btnAnterior);
            this.panelBotoes.Controls.Add(this.btnProxima);
            this.panelBotoes.Controls.Add(this.btnExportar);
            this.panelBotoes.Controls.Add(this.btnImprimir);
            this.panelBotoes.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBotoes.Location = new System.Drawing.Point(0, 0);
            this.panelBotoes.Name = "panelBotoes";
            this.panelBotoes.Size = new System.Drawing.Size(209, 520);
            this.panelBotoes.TabIndex = 5;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.White;
            this.SidePanel.Location = new System.Drawing.Point(1, 61);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 54);
            this.SidePanel.TabIndex = 4;
            // 
            // btnZoom
            // 
            this.btnZoom.FlatAppearance.BorderSize = 0;
            this.btnZoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoom.ForeColor = System.Drawing.Color.White;
            this.btnZoom.Image = global::ShowdeBola.Properties.Resources.zoom;
            this.btnZoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZoom.Location = new System.Drawing.Point(12, 383);
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.Size = new System.Drawing.Size(197, 54);
            this.btnZoom.TabIndex = 6;
            this.btnZoom.Tag = "100";
            this.btnZoom.Text = "       Zoom";
            this.btnZoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnZoom.UseVisualStyleBackColor = true;
            this.btnZoom.Click += new System.EventHandler(this.btnZoom_Click);
            // 
            // btnUltima
            // 
            this.btnUltima.FlatAppearance.BorderSize = 0;
            this.btnUltima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUltima.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltima.ForeColor = System.Drawing.Color.White;
            this.btnUltima.Image = global::ShowdeBola.Properties.Resources.fim;
            this.btnUltima.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUltima.Location = new System.Drawing.Point(12, 329);
            this.btnUltima.Name = "btnUltima";
            this.btnUltima.Size = new System.Drawing.Size(197, 54);
            this.btnUltima.TabIndex = 5;
            this.btnUltima.Text = "       Última";
            this.btnUltima.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUltima.UseVisualStyleBackColor = true;
            this.btnUltima.Click += new System.EventHandler(this.btnUltima_Click);
            // 
            // btnPrimeira
            // 
            this.btnPrimeira.FlatAppearance.BorderSize = 0;
            this.btnPrimeira.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimeira.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeira.ForeColor = System.Drawing.Color.White;
            this.btnPrimeira.Image = global::ShowdeBola.Properties.Resources.inicio;
            this.btnPrimeira.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrimeira.Location = new System.Drawing.Point(12, 275);
            this.btnPrimeira.Name = "btnPrimeira";
            this.btnPrimeira.Size = new System.Drawing.Size(197, 54);
            this.btnPrimeira.TabIndex = 4;
            this.btnPrimeira.Text = "       Primeira";
            this.btnPrimeira.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrimeira.UseVisualStyleBackColor = true;
            this.btnPrimeira.Click += new System.EventHandler(this.btnPrimeira_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.FlatAppearance.BorderSize = 0;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.ForeColor = System.Drawing.Color.White;
            this.btnAnterior.Image = global::ShowdeBola.Properties.Resources.voltar;
            this.btnAnterior.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnterior.Location = new System.Drawing.Point(12, 221);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(197, 54);
            this.btnAnterior.TabIndex = 3;
            this.btnAnterior.Text = "       Anterior";
            this.btnAnterior.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnProxima
            // 
            this.btnProxima.FlatAppearance.BorderSize = 0;
            this.btnProxima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProxima.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProxima.ForeColor = System.Drawing.Color.White;
            this.btnProxima.Image = global::ShowdeBola.Properties.Resources.avancar;
            this.btnProxima.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProxima.Location = new System.Drawing.Point(12, 167);
            this.btnProxima.Name = "btnProxima";
            this.btnProxima.Size = new System.Drawing.Size(197, 54);
            this.btnProxima.TabIndex = 2;
            this.btnProxima.Text = "       Próxima";
            this.btnProxima.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProxima.UseVisualStyleBackColor = true;
            this.btnProxima.Click += new System.EventHandler(this.btnProxima_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.Image = global::ShowdeBola.Properties.Resources.Exportar;
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.Location = new System.Drawing.Point(12, 113);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(197, 54);
            this.btnExportar.TabIndex = 1;
            this.btnExportar.Text = "       Exportar";
            this.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Image = global::ShowdeBola.Properties.Resources.impressao1;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(12, 61);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(197, 54);
            this.btnImprimir.TabIndex = 0;
            this.btnImprimir.Text = "       Imprimir";
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // v_HorarioReservaTableAdapter
            // 
            this.v_HorarioReservaTableAdapter.ClearBeforeFill = true;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.Location = new System.Drawing.Point(6, 38);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgvClientes.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(200, 60);
            this.dgvClientes.TabIndex = 2;
            this.dgvClientes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvClientes_KeyDown);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Código";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome Cliente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Celular";
            this.dataGridViewTextBoxColumn3.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.ForeColor = System.Drawing.Color.White;
            this.txtCliente.Location = new System.Drawing.Point(6, 9);
            this.txtCliente.MaxLength = 100;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(197, 19);
            this.txtCliente.TabIndex = 0;
            this.txtCliente.Text = "Informe um Cliente";
            this.txtCliente.Enter += new System.EventHandler(this.txtCliente_Enter);
            this.txtCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCliente_KeyDown);
            this.txtCliente.Leave += new System.EventHandler(this.txtCliente_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(6, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 14;
            // 
            // txtInicial
            // 
            this.txtInicial.Location = new System.Drawing.Point(418, 32);
            this.txtInicial.Mask = "99/99/9999";
            this.txtInicial.Name = "txtInicial";
            this.txtInicial.Size = new System.Drawing.Size(200, 20);
            this.txtInicial.TabIndex = 4;
            this.txtInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(415, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Data Inicial:";
            // 
            // dgvCampos
            // 
            this.dgvCampos.AllowUserToAddRows = false;
            this.dgvCampos.AllowUserToDeleteRows = false;
            this.dgvCampos.AllowUserToResizeColumns = false;
            this.dgvCampos.AllowUserToResizeRows = false;
            this.dgvCampos.BackgroundColor = System.Drawing.Color.White;
            this.dgvCampos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCampos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCampos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCampos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCampos.Location = new System.Drawing.Point(212, 38);
            this.dgvCampos.MultiSelect = false;
            this.dgvCampos.Name = "dgvCampos";
            this.dgvCampos.ReadOnly = true;
            this.dgvCampos.RowHeadersVisible = false;
            this.dgvCampos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgvCampos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCampos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCampos.Size = new System.Drawing.Size(200, 60);
            this.dgvCampos.TabIndex = 3;
            this.dgvCampos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvCampos_KeyDown);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Código";
            this.dataGridViewTextBoxColumn4.HeaderText = "Código";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn5.HeaderText = "Nome Campo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Valor";
            this.dataGridViewTextBoxColumn6.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // txtCampo
            // 
            this.txtCampo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.txtCampo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCampo.ForeColor = System.Drawing.Color.White;
            this.txtCampo.Location = new System.Drawing.Point(212, 9);
            this.txtCampo.MaxLength = 100;
            this.txtCampo.Name = "txtCampo";
            this.txtCampo.Size = new System.Drawing.Size(197, 19);
            this.txtCampo.TabIndex = 1;
            this.txtCampo.Text = "Informe um Campo";
            this.txtCampo.Enter += new System.EventHandler(this.txtCampo_Enter);
            this.txtCampo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCampo_KeyDown);
            this.txtCampo.Leave += new System.EventHandler(this.txtCampo_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(212, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 25;
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(418, 78);
            this.txtFinal.Mask = "99/99/9999";
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(200, 20);
            this.txtFinal.TabIndex = 5;
            this.txtFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(418, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Data Final:";
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnVisualizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizar.ForeColor = System.Drawing.Color.White;
            this.btnVisualizar.Image = global::ShowdeBola.Properties.Resources.visualizar;
            this.btnVisualizar.Location = new System.Drawing.Point(624, 32);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(67, 66);
            this.btnVisualizar.TabIndex = 6;
            this.btnVisualizar.Text = "       ";
            this.btnVisualizar.UseVisualStyleBackColor = false;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtCliente);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.dgvCampos);
            this.panel3.Controls.Add(this.txtInicial);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.btnVisualizar);
            this.panel3.Controls.Add(this.txtCampo);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dgvClientes);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.txtFinal);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(209, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(703, 107);
            this.panel3.TabIndex = 26;
            // 
            // frmRelReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(912, 520);
            this.Controls.Add(this.rptVisualizador);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelBotoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRelReserva";
            this.Text = "Relatório de Reservas                             ";
            this.Load += new System.EventHandler(this.frmRelReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.v_HorarioReservaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_Show_De_BolaDataSet)).EndInit();
            this.panelBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer rptVisualizador;
        private System.Windows.Forms.Panel panelBotoes;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnZoom;
        private System.Windows.Forms.Button btnUltima;
        private System.Windows.Forms.Button btnPrimeira;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProxima;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.BindingSource v_HorarioReservaBindingSource;
        private DB_Show_De_BolaDataSet DB_Show_De_BolaDataSet;
        private DB_Show_De_BolaDataSetTableAdapters.v_HorarioReservaTableAdapter v_HorarioReservaTableAdapter;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox txtInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCampos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox txtCampo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox txtFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Panel panel3;
    }
}