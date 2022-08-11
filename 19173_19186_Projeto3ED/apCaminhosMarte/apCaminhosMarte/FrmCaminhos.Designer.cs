namespace apCaminhosMarte
{
    partial class FrmCaminhosMarte
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCaminhosMarte));
            this.tbAbas = new System.Windows.Forms.TabControl();
            this.tpRotas = new System.Windows.Forms.TabPage();
            this.lbTotal = new System.Windows.Forms.Label();
            this.gbMetodo = new System.Windows.Forms.GroupBox();
            this.rbRecursao = new System.Windows.Forms.RadioButton();
            this.rbDijkstra = new System.Windows.Forms.RadioButton();
            this.rbBack = new System.Windows.Forms.RadioButton();
            this.gbCriterio = new System.Windows.Forms.GroupBox();
            this.rbTempo = new System.Windows.Forms.RadioButton();
            this.rbDistancia = new System.Windows.Forms.RadioButton();
            this.rbCusto = new System.Windows.Forms.RadioButton();
            this.pbMapa = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvMenorCaminho = new System.Windows.Forms.DataGridView();
            this.dgvCaminhos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lsbDestino = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lsbOrigem = new System.Windows.Forms.ListBox();
            this.tpArvore = new System.Windows.Forms.TabPage();
            this.pnlArvore = new System.Windows.Forms.Panel();
            this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
            this.tbAbas.SuspendLayout();
            this.tpRotas.SuspendLayout();
            this.gbMetodo.SuspendLayout();
            this.gbCriterio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMapa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenorCaminho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaminhos)).BeginInit();
            this.tpArvore.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbAbas
            // 
            this.tbAbas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAbas.Controls.Add(this.tpRotas);
            this.tbAbas.Controls.Add(this.tpArvore);
            this.tbAbas.Location = new System.Drawing.Point(2, 4);
            this.tbAbas.Name = "tbAbas";
            this.tbAbas.SelectedIndex = 0;
            this.tbAbas.Size = new System.Drawing.Size(1326, 551);
            this.tbAbas.TabIndex = 0;
            this.tbAbas.SelectedIndexChanged += new System.EventHandler(this.tbAbas_SelectedIndexChanged);
            // 
            // tpRotas
            // 
            this.tpRotas.Controls.Add(this.lbTotal);
            this.tpRotas.Controls.Add(this.gbMetodo);
            this.tpRotas.Controls.Add(this.gbCriterio);
            this.tpRotas.Controls.Add(this.pbMapa);
            this.tpRotas.Controls.Add(this.btnBuscar);
            this.tpRotas.Controls.Add(this.dgvMenorCaminho);
            this.tpRotas.Controls.Add(this.dgvCaminhos);
            this.tpRotas.Controls.Add(this.label4);
            this.tpRotas.Controls.Add(this.label3);
            this.tpRotas.Controls.Add(this.label2);
            this.tpRotas.Controls.Add(this.lsbDestino);
            this.tpRotas.Controls.Add(this.label1);
            this.tpRotas.Controls.Add(this.lsbOrigem);
            this.tpRotas.Location = new System.Drawing.Point(4, 22);
            this.tpRotas.Name = "tpRotas";
            this.tpRotas.Padding = new System.Windows.Forms.Padding(3);
            this.tpRotas.Size = new System.Drawing.Size(1318, 525);
            this.tpRotas.TabIndex = 0;
            this.tpRotas.Text = "Rotas entre cidades";
            this.tpRotas.UseVisualStyleBackColor = true;
            this.tpRotas.Click += new System.EventHandler(this.tpRotas_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(1040, 497);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(152, 13);
            this.lbTotal.TabIndex = 14;
            this.lbTotal.Text = "Total do menor percurso: --------";
            // 
            // gbMetodo
            // 
            this.gbMetodo.Controls.Add(this.rbRecursao);
            this.gbMetodo.Controls.Add(this.rbDijkstra);
            this.gbMetodo.Controls.Add(this.rbBack);
            this.gbMetodo.Location = new System.Drawing.Point(1181, 114);
            this.gbMetodo.Name = "gbMetodo";
            this.gbMetodo.Size = new System.Drawing.Size(127, 92);
            this.gbMetodo.TabIndex = 13;
            this.gbMetodo.TabStop = false;
            this.gbMetodo.Text = "Método";
            // 
            // rbRecursao
            // 
            this.rbRecursao.AutoSize = true;
            this.rbRecursao.Location = new System.Drawing.Point(7, 66);
            this.rbRecursao.Name = "rbRecursao";
            this.rbRecursao.Size = new System.Drawing.Size(71, 17);
            this.rbRecursao.TabIndex = 5;
            this.rbRecursao.TabStop = true;
            this.rbRecursao.Text = "Recursão";
            this.rbRecursao.UseVisualStyleBackColor = true;
            this.rbRecursao.CheckedChanged += new System.EventHandler(this.rbRecursao_CheckedChanged);
            // 
            // rbDijkstra
            // 
            this.rbDijkstra.AutoSize = true;
            this.rbDijkstra.Location = new System.Drawing.Point(7, 43);
            this.rbDijkstra.Name = "rbDijkstra";
            this.rbDijkstra.Size = new System.Drawing.Size(60, 17);
            this.rbDijkstra.TabIndex = 4;
            this.rbDijkstra.TabStop = true;
            this.rbDijkstra.Text = "Dijkstra";
            this.rbDijkstra.UseVisualStyleBackColor = true;
            this.rbDijkstra.CheckedChanged += new System.EventHandler(this.rbDijsktra_CheckedChanged);
            // 
            // rbBack
            // 
            this.rbBack.AutoSize = true;
            this.rbBack.Location = new System.Drawing.Point(6, 20);
            this.rbBack.Name = "rbBack";
            this.rbBack.Size = new System.Drawing.Size(88, 17);
            this.rbBack.TabIndex = 6;
            this.rbBack.TabStop = true;
            this.rbBack.Text = "Backtracking";
            this.rbBack.UseVisualStyleBackColor = true;
            this.rbBack.CheckedChanged += new System.EventHandler(this.rbBack_CheckedChanged);
            // 
            // gbCriterio
            // 
            this.gbCriterio.Controls.Add(this.rbTempo);
            this.gbCriterio.Controls.Add(this.rbDistancia);
            this.gbCriterio.Controls.Add(this.rbCusto);
            this.gbCriterio.Location = new System.Drawing.Point(1041, 114);
            this.gbCriterio.Name = "gbCriterio";
            this.gbCriterio.Size = new System.Drawing.Size(124, 92);
            this.gbCriterio.TabIndex = 12;
            this.gbCriterio.TabStop = false;
            this.gbCriterio.Text = "Critério";
            // 
            // rbTempo
            // 
            this.rbTempo.AutoSize = true;
            this.rbTempo.Location = new System.Drawing.Point(7, 66);
            this.rbTempo.Name = "rbTempo";
            this.rbTempo.Size = new System.Drawing.Size(58, 17);
            this.rbTempo.TabIndex = 2;
            this.rbTempo.TabStop = true;
            this.rbTempo.Text = "Tempo";
            this.rbTempo.UseVisualStyleBackColor = true;
            this.rbTempo.CheckedChanged += new System.EventHandler(this.rbTempo_CheckedChanged);
            // 
            // rbDistancia
            // 
            this.rbDistancia.AutoSize = true;
            this.rbDistancia.Location = new System.Drawing.Point(7, 43);
            this.rbDistancia.Name = "rbDistancia";
            this.rbDistancia.Size = new System.Drawing.Size(69, 17);
            this.rbDistancia.TabIndex = 1;
            this.rbDistancia.TabStop = true;
            this.rbDistancia.Text = "Distância";
            this.rbDistancia.UseVisualStyleBackColor = true;
            this.rbDistancia.CheckedChanged += new System.EventHandler(this.rbDistancia_CheckedChanged);
            // 
            // rbCusto
            // 
            this.rbCusto.AutoSize = true;
            this.rbCusto.Location = new System.Drawing.Point(7, 20);
            this.rbCusto.Name = "rbCusto";
            this.rbCusto.Size = new System.Drawing.Size(52, 17);
            this.rbCusto.TabIndex = 0;
            this.rbCusto.TabStop = true;
            this.rbCusto.Text = "Custo";
            this.rbCusto.UseVisualStyleBackColor = true;
            this.rbCusto.CheckedChanged += new System.EventHandler(this.rbCusto_CheckedChanged);
            // 
            // pbMapa
            // 
            this.pbMapa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMapa.Image = ((System.Drawing.Image)(resources.GetObject("pbMapa.Image")));
            this.pbMapa.Location = new System.Drawing.Point(7, 4);
            this.pbMapa.Name = "pbMapa";
            this.pbMapa.Size = new System.Drawing.Size(1024, 512);
            this.pbMapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMapa.TabIndex = 0;
            this.pbMapa.TabStop = false;
            this.pbMapa.Paint += new System.Windows.Forms.PaintEventHandler(this.pbMapa_Paint);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(1230, 212);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(84, 20);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // dgvMenorCaminho
            // 
            this.dgvMenorCaminho.AllowUserToAddRows = false;
            this.dgvMenorCaminho.AllowUserToDeleteRows = false;
            this.dgvMenorCaminho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMenorCaminho.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMenorCaminho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenorCaminho.ColumnHeadersVisible = false;
            this.dgvMenorCaminho.Location = new System.Drawing.Point(1038, 442);
            this.dgvMenorCaminho.Name = "dgvMenorCaminho";
            this.dgvMenorCaminho.ReadOnly = true;
            this.dgvMenorCaminho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenorCaminho.Size = new System.Drawing.Size(277, 45);
            this.dgvMenorCaminho.TabIndex = 10;
            this.dgvMenorCaminho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenorCaminho_CellClick);
            // 
            // dgvCaminhos
            // 
            this.dgvCaminhos.AllowUserToAddRows = false;
            this.dgvCaminhos.AllowUserToDeleteRows = false;
            this.dgvCaminhos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCaminhos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvCaminhos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaminhos.ColumnHeadersVisible = false;
            this.dgvCaminhos.Location = new System.Drawing.Point(1037, 238);
            this.dgvCaminhos.Name = "dgvCaminhos";
            this.dgvCaminhos.ReadOnly = true;
            this.dgvCaminhos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCaminhos.Size = new System.Drawing.Size(277, 181);
            this.dgvCaminhos.TabIndex = 9;
            this.dgvCaminhos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCaminhos_CellClick);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1035, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Melhor caminho";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1034, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Caminhos encontrados:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1178, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Destino";
            // 
            // lsbDestino
            // 
            this.lsbDestino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lsbDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbDestino.FormattingEnabled = true;
            this.lsbDestino.ItemHeight = 16;
            this.lsbDestino.Location = new System.Drawing.Point(1181, 24);
            this.lsbDestino.Name = "lsbDestino";
            this.lsbDestino.Size = new System.Drawing.Size(127, 84);
            this.lsbDestino.TabIndex = 3;
            this.lsbDestino.SelectedIndexChanged += new System.EventHandler(this.lsbDestino_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1040, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Origem";
            // 
            // lsbOrigem
            // 
            this.lsbOrigem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lsbOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbOrigem.FormattingEnabled = true;
            this.lsbOrigem.ItemHeight = 16;
            this.lsbOrigem.Location = new System.Drawing.Point(1043, 24);
            this.lsbOrigem.Name = "lsbOrigem";
            this.lsbOrigem.Size = new System.Drawing.Size(122, 84);
            this.lsbOrigem.TabIndex = 1;
            this.lsbOrigem.SelectedIndexChanged += new System.EventHandler(this.lsbOrigem_SelectedIndexChanged);
            // 
            // tpArvore
            // 
            this.tpArvore.Controls.Add(this.pnlArvore);
            this.tpArvore.Location = new System.Drawing.Point(4, 22);
            this.tpArvore.Name = "tpArvore";
            this.tpArvore.Padding = new System.Windows.Forms.Padding(3);
            this.tpArvore.Size = new System.Drawing.Size(1318, 525);
            this.tpArvore.TabIndex = 1;
            this.tpArvore.Text = "Árvore de Cidades";
            this.tpArvore.UseVisualStyleBackColor = true;
            this.tpArvore.Click += new System.EventHandler(this.tpArvore_Click);
            // 
            // pnlArvore
            // 
            this.pnlArvore.Location = new System.Drawing.Point(6, 6);
            this.pnlArvore.Name = "pnlArvore";
            this.pnlArvore.Size = new System.Drawing.Size(1305, 510);
            this.pnlArvore.TabIndex = 0;
            // 
            // dlgAbrir
            // 
            this.dlgAbrir.FileName = "openFileDialog1";
            // 
            // FrmCaminhosMarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 554);
            this.Controls.Add(this.tbAbas);
            this.Name = "FrmCaminhosMarte";
            this.Text = "Projeto III - Busca de caminhos entre cidades";
            this.Load += new System.EventHandler(this.FrmCaminhos_Load);
            this.tbAbas.ResumeLayout(false);
            this.tpRotas.ResumeLayout(false);
            this.tpRotas.PerformLayout();
            this.gbMetodo.ResumeLayout(false);
            this.gbMetodo.PerformLayout();
            this.gbCriterio.ResumeLayout(false);
            this.gbCriterio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMapa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenorCaminho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaminhos)).EndInit();
            this.tpArvore.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbAbas;
        private System.Windows.Forms.TabPage tpRotas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lsbDestino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lsbOrigem;
        private System.Windows.Forms.PictureBox pbMapa;
        private System.Windows.Forms.TabPage tpArvore;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvMenorCaminho;
        private System.Windows.Forms.OpenFileDialog dlgAbrir;
        private System.Windows.Forms.Panel pnlArvore;
        private System.Windows.Forms.DataGridView dgvCaminhos;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.GroupBox gbMetodo;
        private System.Windows.Forms.GroupBox gbCriterio;
        private System.Windows.Forms.RadioButton rbTempo;
        private System.Windows.Forms.RadioButton rbDistancia;
        private System.Windows.Forms.RadioButton rbCusto;
        private System.Windows.Forms.RadioButton rbRecursao;
        private System.Windows.Forms.RadioButton rbDijkstra;
        private System.Windows.Forms.RadioButton rbBack;
    }
}

