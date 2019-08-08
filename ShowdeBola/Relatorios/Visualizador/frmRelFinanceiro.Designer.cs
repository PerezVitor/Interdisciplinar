namespace ShowdeBola
{
    partial class frmRelFinanceiro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.v_FinanceiroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DB_Show_De_BolaDataSet = new ShowdeBola.DB_Show_De_BolaDataSet();
            this.panelBotoes = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnZoom = new System.Windows.Forms.Button();
            this.btnUltima = new System.Windows.Forms.Button();
            this.btnPrimeira = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProxima = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInicial = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rptVisualizador = new Microsoft.Reporting.WinForms.ReportViewer();
            this.v_FinanceiroTableAdapter = new ShowdeBola.DB_Show_De_BolaDataSetTableAdapters.v_FinanceiroTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.v_FinanceiroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_Show_De_BolaDataSet)).BeginInit();
            this.panelBotoes.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // v_FinanceiroBindingSource
            // 
            this.v_FinanceiroBindingSource.DataMember = "v_Financeiro";
            this.v_FinanceiroBindingSource.DataSource = this.DB_Show_De_BolaDataSet;
            // 
            // DB_Show_De_BolaDataSet
            // 
            this.DB_Show_De_BolaDataSet.DataSetName = "DB_Show_De_BolaDataSet";
            this.DB_Show_De_BolaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.panelBotoes.Size = new System.Drawing.Size(209, 502);
            this.panelBotoes.TabIndex = 4;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.txtUsuario);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtInicial);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.btnVisualizar);
            this.panel3.Controls.Add(this.dgvUsuario);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(209, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(712, 115);
            this.panel3.TabIndex = 27;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.Location = new System.Drawing.Point(6, 9);
            this.txtUsuario.MaxLength = 100;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(197, 19);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Text = "Informe um Usuário";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyDown);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(209, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Data:";
            // 
            // txtInicial
            // 
            this.txtInicial.Location = new System.Drawing.Point(212, 38);
            this.txtInicial.Mask = "99/99/9999";
            this.txtInicial.Name = "txtInicial";
            this.txtInicial.Size = new System.Drawing.Size(200, 20);
            this.txtInicial.TabIndex = 4;
            this.txtInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInicial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInicial_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(6, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 14;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnVisualizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizar.ForeColor = System.Drawing.Color.White;
            this.btnVisualizar.Image = global::ShowdeBola.Properties.Resources.visualizar;
            this.btnVisualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisualizar.Location = new System.Drawing.Point(212, 72);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(200, 37);
            this.btnVisualizar.TabIndex = 6;
            this.btnVisualizar.Text = "       Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = false;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.AllowUserToAddRows = false;
            this.dgvUsuario.AllowUserToDeleteRows = false;
            this.dgvUsuario.AllowUserToResizeColumns = false;
            this.dgvUsuario.AllowUserToResizeRows = false;
            this.dgvUsuario.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuario.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsuario.Location = new System.Drawing.Point(6, 38);
            this.dgvUsuario.MultiSelect = false;
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.ReadOnly = true;
            this.dgvUsuario.RowHeadersVisible = false;
            this.dgvUsuario.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgvUsuario.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuario.Size = new System.Drawing.Size(200, 71);
            this.dgvUsuario.TabIndex = 2;
            this.dgvUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvUsuario_KeyDown);
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
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome Usuário";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // rptVisualizador
            // 
            this.rptVisualizador.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.v_FinanceiroBindingSource;
            this.rptVisualizador.LocalReport.DataSources.Add(reportDataSource3);
            this.rptVisualizador.LocalReport.ReportEmbeddedResource = "ShowdeBola.Relatorios.Relatorio.rptRelFinanceiro.rdlc";
            this.rptVisualizador.Location = new System.Drawing.Point(209, 115);
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
            this.rptVisualizador.Size = new System.Drawing.Size(712, 387);
            this.rptVisualizador.TabIndex = 28;
            // 
            // v_FinanceiroTableAdapter
            // 
            this.v_FinanceiroTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(921, 502);
            this.Controls.Add(this.rptVisualizador);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelBotoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmRelFinanceiro";
            this.Text = "Relatório de Financeiro                         ";
            this.Load += new System.EventHandler(this.frmRelFinanceiro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.v_FinanceiroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_Show_De_BolaDataSet)).EndInit();
            this.panelBotoes.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBotoes;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnZoom;
        private System.Windows.Forms.Button btnUltima;
        private System.Windows.Forms.Button btnPrimeira;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProxima;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtInicial;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.DataGridView dgvUsuario;
        public Microsoft.Reporting.WinForms.ReportViewer rptVisualizador;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource v_FinanceiroBindingSource;
        private DB_Show_De_BolaDataSet DB_Show_De_BolaDataSet;
        private DB_Show_De_BolaDataSetTableAdapters.v_FinanceiroTableAdapter v_FinanceiroTableAdapter;
    }
}