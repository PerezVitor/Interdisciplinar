namespace ShowdeBola
{
    partial class frmListUsuario
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
            this.v_UsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.v_UsuarioTableAdapter = new ShowdeBola.DB_Show_De_BolaDataSetTableAdapters.v_UsuarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.v_UsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_Show_De_BolaDataSet)).BeginInit();
            this.panelBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // v_UsuarioBindingSource
            // 
            this.v_UsuarioBindingSource.DataMember = "v_Usuario";
            this.v_UsuarioBindingSource.DataSource = this.DB_Show_De_BolaDataSet;
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
            reportDataSource1.Value = this.v_UsuarioBindingSource;
            this.rptVisualizador.LocalReport.DataSources.Add(reportDataSource1);
            this.rptVisualizador.LocalReport.ReportEmbeddedResource = "ShowdeBola.Relatorios.Listagem.rptLisUsuario.rdlc";
            this.rptVisualizador.Location = new System.Drawing.Point(209, 0);
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
            this.rptVisualizador.Size = new System.Drawing.Size(812, 519);
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
            this.panelBotoes.Size = new System.Drawing.Size(209, 519);
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
            // v_UsuarioTableAdapter
            // 
            this.v_UsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // frmListUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 519);
            this.Controls.Add(this.rptVisualizador);
            this.Controls.Add(this.panelBotoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListUsuario";
            this.Text = "Listagem de Usuários                             ";
            this.Load += new System.EventHandler(this.frmRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.v_UsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_Show_De_BolaDataSet)).EndInit();
            this.panelBotoes.ResumeLayout(false);
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
        private System.Windows.Forms.BindingSource v_UsuarioBindingSource;
        private DB_Show_De_BolaDataSet DB_Show_De_BolaDataSet;
        private DB_Show_De_BolaDataSetTableAdapters.v_UsuarioTableAdapter v_UsuarioTableAdapter;
    }
}