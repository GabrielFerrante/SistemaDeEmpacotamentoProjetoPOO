namespace SistemaDeEmpacotamento
{
    partial class frmCadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroProduto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbFiltrosPacotes = new System.Windows.Forms.GroupBox();
            this.txtNomePesquisa = new System.Windows.Forms.TextBox();
            this.btnLimparFiltros = new System.Windows.Forms.Button();
            this.btnPesquisarNome = new System.Windows.Forms.Button();
            this.dgvCadastroProduto = new System.Windows.Forms.DataGridView();
            this.gbCadastroProduto = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.gbOpcaoes = new System.Windows.Forms.GroupBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtProfundidade = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.txtLargura = new System.Windows.Forms.TextBox();
            this.lblLargura = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblProfundidade = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.msCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.msCadastroLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.msCadastroEmbalagem = new System.Windows.Forms.ToolStripMenuItem();
            this.msCadastroProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.msCalculo = new System.Windows.Forms.ToolStripMenuItem();
            this.msSair = new System.Windows.Forms.ToolStripMenuItem();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Largura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Altura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profundidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRquantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.gbFiltrosPacotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroProduto)).BeginInit();
            this.gbCadastroProduto.SuspendLayout();
            this.gbOpcaoes.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.gbFiltrosPacotes);
            this.panel1.Controls.Add(this.dgvCadastroProduto);
            this.panel1.Controls.Add(this.gbCadastroProduto);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 689);
            this.panel1.TabIndex = 0;
            // 
            // gbFiltrosPacotes
            // 
            this.gbFiltrosPacotes.BackColor = System.Drawing.Color.Transparent;
            this.gbFiltrosPacotes.Controls.Add(this.txtNomePesquisa);
            this.gbFiltrosPacotes.Controls.Add(this.btnLimparFiltros);
            this.gbFiltrosPacotes.Controls.Add(this.btnPesquisarNome);
            this.gbFiltrosPacotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltrosPacotes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbFiltrosPacotes.Location = new System.Drawing.Point(9, 564);
            this.gbFiltrosPacotes.Name = "gbFiltrosPacotes";
            this.gbFiltrosPacotes.Size = new System.Drawing.Size(623, 117);
            this.gbFiltrosPacotes.TabIndex = 17;
            this.gbFiltrosPacotes.TabStop = false;
            this.gbFiltrosPacotes.Text = "Filtros de pesquisa";
            // 
            // txtNomePesquisa
            // 
            this.txtNomePesquisa.Location = new System.Drawing.Point(6, 36);
            this.txtNomePesquisa.Name = "txtNomePesquisa";
            this.txtNomePesquisa.Size = new System.Drawing.Size(611, 23);
            this.txtNomePesquisa.TabIndex = 15;
            // 
            // btnLimparFiltros
            // 
            this.btnLimparFiltros.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimparFiltros.Location = new System.Drawing.Point(476, 84);
            this.btnLimparFiltros.Name = "btnLimparFiltros";
            this.btnLimparFiltros.Size = new System.Drawing.Size(128, 27);
            this.btnLimparFiltros.TabIndex = 17;
            this.btnLimparFiltros.Text = "Limpar pesquisa";
            this.btnLimparFiltros.UseVisualStyleBackColor = true;
            this.btnLimparFiltros.Click += new System.EventHandler(this.btnLimparFiltros_Click);
            // 
            // btnPesquisarNome
            // 
            this.btnPesquisarNome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPesquisarNome.Location = new System.Drawing.Point(205, 65);
            this.btnPesquisarNome.Name = "btnPesquisarNome";
            this.btnPesquisarNome.Size = new System.Drawing.Size(169, 28);
            this.btnPesquisarNome.TabIndex = 3;
            this.btnPesquisarNome.Text = "Pesquisar por nome";
            this.btnPesquisarNome.UseVisualStyleBackColor = true;
            this.btnPesquisarNome.Click += new System.EventHandler(this.btnPesquisarNome_Click);
            // 
            // dgvCadastroProduto
            // 
            this.dgvCadastroProduto.AllowUserToAddRows = false;
            this.dgvCadastroProduto.AllowUserToDeleteRows = false;
            this.dgvCadastroProduto.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvCadastroProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastroProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Peso,
            this.Largura,
            this.Altura,
            this.Profundidade,
            this.PRquantidade});
            this.dgvCadastroProduto.Location = new System.Drawing.Point(0, 276);
            this.dgvCadastroProduto.Name = "dgvCadastroProduto";
            this.dgvCadastroProduto.ReadOnly = true;
            this.dgvCadastroProduto.Size = new System.Drawing.Size(643, 282);
            this.dgvCadastroProduto.TabIndex = 16;
            // 
            // gbCadastroProduto
            // 
            this.gbCadastroProduto.BackColor = System.Drawing.Color.Transparent;
            this.gbCadastroProduto.Controls.Add(this.label1);
            this.gbCadastroProduto.Controls.Add(this.txtQuantidade);
            this.gbCadastroProduto.Controls.Add(this.btnLimpar);
            this.gbCadastroProduto.Controls.Add(this.txtNome);
            this.gbCadastroProduto.Controls.Add(this.gbOpcaoes);
            this.gbCadastroProduto.Controls.Add(this.txtProfundidade);
            this.gbCadastroProduto.Controls.Add(this.lblPeso);
            this.gbCadastroProduto.Controls.Add(this.txtAltura);
            this.gbCadastroProduto.Controls.Add(this.lblNomeProduto);
            this.gbCadastroProduto.Controls.Add(this.txtLargura);
            this.gbCadastroProduto.Controls.Add(this.lblLargura);
            this.gbCadastroProduto.Controls.Add(this.txtPeso);
            this.gbCadastroProduto.Controls.Add(this.lblAltura);
            this.gbCadastroProduto.Controls.Add(this.lblProfundidade);
            this.gbCadastroProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCadastroProduto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbCadastroProduto.Location = new System.Drawing.Point(12, 36);
            this.gbCadastroProduto.Name = "gbCadastroProduto";
            this.gbCadastroProduto.Size = new System.Drawing.Size(623, 225);
            this.gbCadastroProduto.TabIndex = 11;
            this.gbCadastroProduto.TabStop = false;
            this.gbCadastroProduto.Text = "Cadastrar Produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(497, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(500, 45);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(91, 23);
            this.txtQuantidade.TabIndex = 15;
            // 
            // btnLimpar
            // 
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpar.Location = new System.Drawing.Point(516, 101);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(6, 45);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(457, 23);
            this.txtNome.TabIndex = 0;
            // 
            // gbOpcaoes
            // 
            this.gbOpcaoes.BackColor = System.Drawing.Color.Transparent;
            this.gbOpcaoes.Controls.Add(this.btnAlterar);
            this.gbOpcaoes.Controls.Add(this.btnSalvar);
            this.gbOpcaoes.Controls.Add(this.btnExcluir);
            this.gbOpcaoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpcaoes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbOpcaoes.Location = new System.Drawing.Point(166, 150);
            this.gbOpcaoes.Name = "gbOpcaoes";
            this.gbOpcaoes.Size = new System.Drawing.Size(328, 60);
            this.gbOpcaoes.TabIndex = 14;
            this.gbOpcaoes.TabStop = false;
            this.gbOpcaoes.Text = "Opções";
            // 
            // btnAlterar
            // 
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAlterar.Location = new System.Drawing.Point(90, 19);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 26);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalvar.Location = new System.Drawing.Point(9, 19);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 26);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExcluir.Location = new System.Drawing.Point(232, 19);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 26);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // txtProfundidade
            // 
            this.txtProfundidade.Location = new System.Drawing.Point(337, 101);
            this.txtProfundidade.Name = "txtProfundidade";
            this.txtProfundidade.Size = new System.Drawing.Size(126, 23);
            this.txtProfundidade.TabIndex = 4;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.BackColor = System.Drawing.Color.Transparent;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPeso.Location = new System.Drawing.Point(6, 81);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(66, 17);
            this.lblPeso.TabIndex = 1;
            this.lblPeso.Text = "Peso: (g)";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(224, 101);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(91, 23);
            this.txtAltura.TabIndex = 3;
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProduto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNomeProduto.Location = new System.Drawing.Point(6, 25);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(49, 17);
            this.lblNomeProduto.TabIndex = 2;
            this.lblNomeProduto.Text = "Nome:";
            // 
            // txtLargura
            // 
            this.txtLargura.Location = new System.Drawing.Point(116, 101);
            this.txtLargura.Name = "txtLargura";
            this.txtLargura.Size = new System.Drawing.Size(91, 23);
            this.txtLargura.TabIndex = 2;
            // 
            // lblLargura
            // 
            this.lblLargura.AutoSize = true;
            this.lblLargura.BackColor = System.Drawing.Color.Transparent;
            this.lblLargura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLargura.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLargura.Location = new System.Drawing.Point(113, 81);
            this.lblLargura.Name = "lblLargura";
            this.lblLargura.Size = new System.Drawing.Size(94, 17);
            this.lblLargura.TabIndex = 3;
            this.lblLargura.Text = "Largura: (cm)";
            this.lblLargura.Click += new System.EventHandler(this.LblLargura_Click);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(6, 101);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(91, 23);
            this.txtPeso.TabIndex = 1;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.BackColor = System.Drawing.Color.Transparent;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAltura.Location = new System.Drawing.Point(221, 81);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(81, 17);
            this.lblAltura.TabIndex = 4;
            this.lblAltura.Text = "Altura: (cm)";
            // 
            // lblProfundidade
            // 
            this.lblProfundidade.AutoSize = true;
            this.lblProfundidade.BackColor = System.Drawing.Color.Transparent;
            this.lblProfundidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfundidade.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProfundidade.Location = new System.Drawing.Point(334, 81);
            this.lblProfundidade.Name = "lblProfundidade";
            this.lblProfundidade.Size = new System.Drawing.Size(129, 17);
            this.lblProfundidade.TabIndex = 5;
            this.lblProfundidade.Text = "Profundidade: (cm)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Enabled = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msInicio,
            this.msCadastro,
            this.msSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(644, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msInicio
            // 
            this.msInicio.Name = "msInicio";
            this.msInicio.Size = new System.Drawing.Size(48, 20);
            this.msInicio.Text = "Início";
            // 
            // msCadastro
            // 
            this.msCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msCadastroLogin,
            this.msCadastroEmbalagem,
            this.msCadastroProduto,
            this.msCalculo});
            this.msCadastro.Name = "msCadastro";
            this.msCadastro.Size = new System.Drawing.Size(66, 20);
            this.msCadastro.Text = "Cadastro";
            // 
            // msCadastroLogin
            // 
            this.msCadastroLogin.Name = "msCadastroLogin";
            this.msCadastroLogin.Size = new System.Drawing.Size(187, 22);
            this.msCadastroLogin.Text = "Cadastro Login";
            // 
            // msCadastroEmbalagem
            // 
            this.msCadastroEmbalagem.Name = "msCadastroEmbalagem";
            this.msCadastroEmbalagem.Size = new System.Drawing.Size(187, 22);
            this.msCadastroEmbalagem.Text = "Cadastro Embalagem";
            // 
            // msCadastroProduto
            // 
            this.msCadastroProduto.Name = "msCadastroProduto";
            this.msCadastroProduto.Size = new System.Drawing.Size(187, 22);
            this.msCadastroProduto.Text = "Cadastro Produto";
            // 
            // msCalculo
            // 
            this.msCalculo.Name = "msCalculo";
            this.msCalculo.Size = new System.Drawing.Size(187, 22);
            this.msCalculo.Text = "Cálculo";
            // 
            // msSair
            // 
            this.msSair.Name = "msSair";
            this.msSair.Size = new System.Drawing.Size(38, 20);
            this.msSair.Text = "Sair";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "PRid";
            this.ID.HeaderText = "Código";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "PRnome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 150;
            // 
            // Peso
            // 
            this.Peso.DataPropertyName = "PRpeso";
            this.Peso.HeaderText = "Peso";
            this.Peso.Name = "Peso";
            this.Peso.ReadOnly = true;
            // 
            // Largura
            // 
            this.Largura.DataPropertyName = "PRlargura";
            this.Largura.HeaderText = "Largura";
            this.Largura.Name = "Largura";
            this.Largura.ReadOnly = true;
            // 
            // Altura
            // 
            this.Altura.DataPropertyName = "PRaltura";
            this.Altura.HeaderText = "Altura";
            this.Altura.Name = "Altura";
            this.Altura.ReadOnly = true;
            // 
            // Profundidade
            // 
            this.Profundidade.DataPropertyName = "PRprofundidade";
            this.Profundidade.HeaderText = "Profundidade";
            this.Profundidade.Name = "Profundidade";
            this.Profundidade.ReadOnly = true;
            // 
            // PRquantidade
            // 
            this.PRquantidade.DataPropertyName = "PRquantidade";
            this.PRquantidade.HeaderText = "Quantidade";
            this.PRquantidade.Name = "PRquantidade";
            this.PRquantidade.ReadOnly = true;
            // 
            // frmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 689);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmCadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro do Produto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbFiltrosPacotes.ResumeLayout(false);
            this.gbFiltrosPacotes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroProduto)).EndInit();
            this.gbCadastroProduto.ResumeLayout(false);
            this.gbCadastroProduto.PerformLayout();
            this.gbOpcaoes.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtProfundidade;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtLargura;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblProfundidade;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblLargura;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msInicio;
        private System.Windows.Forms.ToolStripMenuItem msSair;
        private System.Windows.Forms.DataGridView dgvCadastroProduto;
        private System.Windows.Forms.GroupBox gbOpcaoes;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox gbCadastroProduto;
        private System.Windows.Forms.ToolStripMenuItem msCadastro;
        private System.Windows.Forms.ToolStripMenuItem msCadastroEmbalagem;
        private System.Windows.Forms.ToolStripMenuItem msCadastroProduto;
        private System.Windows.Forms.ToolStripMenuItem msCalculo;
        private System.Windows.Forms.ToolStripMenuItem msCadastroLogin;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox gbFiltrosPacotes;
        private System.Windows.Forms.Button btnLimparFiltros;
        private System.Windows.Forms.Button btnPesquisarNome;
        private System.Windows.Forms.TextBox txtNomePesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Largura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Altura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profundidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRquantidade;
    }
}