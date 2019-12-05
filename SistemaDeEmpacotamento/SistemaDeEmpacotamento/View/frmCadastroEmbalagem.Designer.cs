namespace SistemaDeEmpacotamento
{
    partial class frmCadastroEmbalagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroEmbalagem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbFiltrosPacotes = new System.Windows.Forms.GroupBox();
            this.txtPesquisaTipo = new System.Windows.Forms.TextBox();
            this.cbMateriaisPesquisa = new System.Windows.Forms.ComboBox();
            this.btnPesquisaMaterial = new System.Windows.Forms.Button();
            this.btnLimparFiltros = new System.Windows.Forms.Button();
            this.btnPesquisarTipo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msInicioEmbalagem = new System.Windows.Forms.ToolStripMenuItem();
            this.msCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.msCadastroLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.msCadastroEmbalagem = new System.Windows.Forms.ToolStripMenuItem();
            this.msCadastroProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.msCalculo = new System.Windows.Forms.ToolStripMenuItem();
            this.msSair = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvCadastroEmbalagem = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.btnSalvarPacote = new System.Windows.Forms.Button();
            this.btnAlterarPacote = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.cbMateriais = new System.Windows.Forms.ComboBox();
            this.lblMaterialPacote = new System.Windows.Forms.Label();
            this.lblPesoPacote = new System.Windows.Forms.Label();
            this.txtPesoPacote = new System.Windows.Forms.TextBox();
            this.txtProfundidadePacote = new System.Windows.Forms.TextBox();
            this.lblProfundidadePacote = new System.Windows.Forms.Label();
            this.lblAlturaPacote = new System.Windows.Forms.Label();
            this.txtAlturaPacote = new System.Windows.Forms.TextBox();
            this.txtLarguraPacote = new System.Windows.Forms.TextBox();
            this.lblLargura = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblTipoPacote = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPacote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Largura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Altura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profundidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.gbFiltrosPacotes.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroEmbalagem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.gbFiltrosPacotes);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.dgvCadastroEmbalagem);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 672);
            this.panel1.TabIndex = 0;
            // 
            // gbFiltrosPacotes
            // 
            this.gbFiltrosPacotes.BackColor = System.Drawing.Color.Transparent;
            this.gbFiltrosPacotes.Controls.Add(this.txtPesquisaTipo);
            this.gbFiltrosPacotes.Controls.Add(this.cbMateriaisPesquisa);
            this.gbFiltrosPacotes.Controls.Add(this.btnPesquisaMaterial);
            this.gbFiltrosPacotes.Controls.Add(this.btnLimparFiltros);
            this.gbFiltrosPacotes.Controls.Add(this.btnPesquisarTipo);
            this.gbFiltrosPacotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltrosPacotes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbFiltrosPacotes.Location = new System.Drawing.Point(12, 543);
            this.gbFiltrosPacotes.Name = "gbFiltrosPacotes";
            this.gbFiltrosPacotes.Size = new System.Drawing.Size(636, 117);
            this.gbFiltrosPacotes.TabIndex = 6;
            this.gbFiltrosPacotes.TabStop = false;
            this.gbFiltrosPacotes.Text = "Filtros de pesquisa";
            // 
            // txtPesquisaTipo
            // 
            this.txtPesquisaTipo.Location = new System.Drawing.Point(6, 22);
            this.txtPesquisaTipo.Name = "txtPesquisaTipo";
            this.txtPesquisaTipo.Size = new System.Drawing.Size(215, 23);
            this.txtPesquisaTipo.TabIndex = 20;
            // 
            // cbMateriaisPesquisa
            // 
            this.cbMateriaisPesquisa.FormattingEnabled = true;
            this.cbMateriaisPesquisa.Location = new System.Drawing.Point(9, 72);
            this.cbMateriaisPesquisa.Name = "cbMateriaisPesquisa";
            this.cbMateriaisPesquisa.Size = new System.Drawing.Size(215, 24);
            this.cbMateriaisPesquisa.TabIndex = 19;
            // 
            // btnPesquisaMaterial
            // 
            this.btnPesquisaMaterial.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPesquisaMaterial.Location = new System.Drawing.Point(236, 72);
            this.btnPesquisaMaterial.Name = "btnPesquisaMaterial";
            this.btnPesquisaMaterial.Size = new System.Drawing.Size(169, 28);
            this.btnPesquisaMaterial.TabIndex = 18;
            this.btnPesquisaMaterial.Text = "Pesquisar por material";
            this.btnPesquisaMaterial.UseVisualStyleBackColor = true;
            this.btnPesquisaMaterial.Click += new System.EventHandler(this.btnPesquisaMaterial_Click);
            // 
            // btnLimparFiltros
            // 
            this.btnLimparFiltros.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimparFiltros.Location = new System.Drawing.Point(470, 51);
            this.btnLimparFiltros.Name = "btnLimparFiltros";
            this.btnLimparFiltros.Size = new System.Drawing.Size(128, 27);
            this.btnLimparFiltros.TabIndex = 17;
            this.btnLimparFiltros.Text = "Limpar pesquisa";
            this.btnLimparFiltros.UseVisualStyleBackColor = true;
            this.btnLimparFiltros.Click += new System.EventHandler(this.btnLimparFiltros_Click);
            // 
            // btnPesquisarTipo
            // 
            this.btnPesquisarTipo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPesquisarTipo.Location = new System.Drawing.Point(236, 19);
            this.btnPesquisarTipo.Name = "btnPesquisarTipo";
            this.btnPesquisarTipo.Size = new System.Drawing.Size(169, 28);
            this.btnPesquisarTipo.TabIndex = 3;
            this.btnPesquisarTipo.Text = "Pesquisar por tipo";
            this.btnPesquisarTipo.UseVisualStyleBackColor = true;
            this.btnPesquisarTipo.Click += new System.EventHandler(this.Button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Enabled = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msInicioEmbalagem,
            this.msCadastro,
            this.msSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(660, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msInicioEmbalagem
            // 
            this.msInicioEmbalagem.Name = "msInicioEmbalagem";
            this.msInicioEmbalagem.Size = new System.Drawing.Size(48, 20);
            this.msInicioEmbalagem.Text = "Início";
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
            // dgvCadastroEmbalagem
            // 
            this.dgvCadastroEmbalagem.AllowUserToAddRows = false;
            this.dgvCadastroEmbalagem.AllowUserToDeleteRows = false;
            this.dgvCadastroEmbalagem.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvCadastroEmbalagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastroEmbalagem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TipoPacote,
            this.Quantidade,
            this.Largura,
            this.Altura,
            this.Profundidade,
            this.Peso,
            this.Material});
            this.dgvCadastroEmbalagem.Location = new System.Drawing.Point(0, 280);
            this.dgvCadastroEmbalagem.Name = "dgvCadastroEmbalagem";
            this.dgvCadastroEmbalagem.ReadOnly = true;
            this.dgvCadastroEmbalagem.Size = new System.Drawing.Size(660, 257);
            this.dgvCadastroEmbalagem.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtTipo);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.cbMateriais);
            this.groupBox1.Controls.Add(this.lblMaterialPacote);
            this.groupBox1.Controls.Add(this.lblPesoPacote);
            this.groupBox1.Controls.Add(this.txtPesoPacote);
            this.groupBox1.Controls.Add(this.txtProfundidadePacote);
            this.groupBox1.Controls.Add(this.lblProfundidadePacote);
            this.groupBox1.Controls.Add(this.lblAlturaPacote);
            this.groupBox1.Controls.Add(this.txtAlturaPacote);
            this.groupBox1.Controls.Add(this.txtLarguraPacote);
            this.groupBox1.Controls.Add(this.lblLargura);
            this.groupBox1.Controls.Add(this.txtQuantidade);
            this.groupBox1.Controls.Add(this.lblQuantidade);
            this.groupBox1.Controls.Add(this.lblTipoPacote);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Pacotes / Embalagens";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(9, 52);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(215, 23);
            this.txtTipo.TabIndex = 17;
            this.txtTipo.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnExcluirProduto);
            this.groupBox2.Controls.Add(this.btnSalvarPacote);
            this.groupBox2.Controls.Add(this.btnAlterarPacote);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(144, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 60);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opções";
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExcluirProduto.Location = new System.Drawing.Point(235, 22);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(75, 27);
            this.btnExcluirProduto.TabIndex = 2;
            this.btnExcluirProduto.Text = "Excluir";
            this.btnExcluirProduto.UseVisualStyleBackColor = true;
            this.btnExcluirProduto.Click += new System.EventHandler(this.BtnExcluirProduto_Click);
            // 
            // btnSalvarPacote
            // 
            this.btnSalvarPacote.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalvarPacote.Location = new System.Drawing.Point(15, 22);
            this.btnSalvarPacote.Name = "btnSalvarPacote";
            this.btnSalvarPacote.Size = new System.Drawing.Size(75, 27);
            this.btnSalvarPacote.TabIndex = 0;
            this.btnSalvarPacote.Text = "Salvar";
            this.btnSalvarPacote.UseVisualStyleBackColor = true;
            this.btnSalvarPacote.Click += new System.EventHandler(this.BtnSalvarPacote_Click);
            // 
            // btnAlterarPacote
            // 
            this.btnAlterarPacote.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAlterarPacote.Location = new System.Drawing.Point(96, 22);
            this.btnAlterarPacote.Name = "btnAlterarPacote";
            this.btnAlterarPacote.Size = new System.Drawing.Size(75, 27);
            this.btnAlterarPacote.TabIndex = 1;
            this.btnAlterarPacote.Text = "Alterar";
            this.btnAlterarPacote.UseVisualStyleBackColor = true;
            this.btnAlterarPacote.Click += new System.EventHandler(this.BtnAlterarPacote_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpar.Location = new System.Drawing.Point(544, 107);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // cbMateriais
            // 
            this.cbMateriais.FormattingEnabled = true;
            this.cbMateriais.Location = new System.Drawing.Point(399, 53);
            this.cbMateriais.Name = "cbMateriais";
            this.cbMateriais.Size = new System.Drawing.Size(169, 24);
            this.cbMateriais.TabIndex = 2;
            this.cbMateriais.SelectedIndexChanged += new System.EventHandler(this.cbMateriais_SelectedIndexChanged);
            // 
            // lblMaterialPacote
            // 
            this.lblMaterialPacote.AutoSize = true;
            this.lblMaterialPacote.Location = new System.Drawing.Point(396, 31);
            this.lblMaterialPacote.Name = "lblMaterialPacote";
            this.lblMaterialPacote.Size = new System.Drawing.Size(62, 17);
            this.lblMaterialPacote.TabIndex = 15;
            this.lblMaterialPacote.Text = "Material:";
            // 
            // lblPesoPacote
            // 
            this.lblPesoPacote.AutoSize = true;
            this.lblPesoPacote.Location = new System.Drawing.Point(396, 87);
            this.lblPesoPacote.Name = "lblPesoPacote";
            this.lblPesoPacote.Size = new System.Drawing.Size(66, 17);
            this.lblPesoPacote.TabIndex = 14;
            this.lblPesoPacote.Text = "Peso: (g)";
            this.lblPesoPacote.Click += new System.EventHandler(this.LblPesoPacote_Click);
            // 
            // txtPesoPacote
            // 
            this.txtPesoPacote.Location = new System.Drawing.Point(399, 107);
            this.txtPesoPacote.Name = "txtPesoPacote";
            this.txtPesoPacote.Size = new System.Drawing.Size(125, 23);
            this.txtPesoPacote.TabIndex = 6;
            // 
            // txtProfundidadePacote
            // 
            this.txtProfundidadePacote.Location = new System.Drawing.Point(252, 107);
            this.txtProfundidadePacote.Name = "txtProfundidadePacote";
            this.txtProfundidadePacote.Size = new System.Drawing.Size(125, 23);
            this.txtProfundidadePacote.TabIndex = 5;
            // 
            // lblProfundidadePacote
            // 
            this.lblProfundidadePacote.AutoSize = true;
            this.lblProfundidadePacote.Location = new System.Drawing.Point(249, 87);
            this.lblProfundidadePacote.Name = "lblProfundidadePacote";
            this.lblProfundidadePacote.Size = new System.Drawing.Size(129, 17);
            this.lblProfundidadePacote.TabIndex = 10;
            this.lblProfundidadePacote.Text = "Profundidade: (cm)";
            // 
            // lblAlturaPacote
            // 
            this.lblAlturaPacote.AutoSize = true;
            this.lblAlturaPacote.Location = new System.Drawing.Point(127, 87);
            this.lblAlturaPacote.Name = "lblAlturaPacote";
            this.lblAlturaPacote.Size = new System.Drawing.Size(81, 17);
            this.lblAlturaPacote.TabIndex = 9;
            this.lblAlturaPacote.Text = "Altura: (cm)";
            // 
            // txtAlturaPacote
            // 
            this.txtAlturaPacote.Location = new System.Drawing.Point(130, 107);
            this.txtAlturaPacote.Name = "txtAlturaPacote";
            this.txtAlturaPacote.Size = new System.Drawing.Size(94, 23);
            this.txtAlturaPacote.TabIndex = 4;
            // 
            // txtLarguraPacote
            // 
            this.txtLarguraPacote.Location = new System.Drawing.Point(9, 107);
            this.txtLarguraPacote.Name = "txtLarguraPacote";
            this.txtLarguraPacote.Size = new System.Drawing.Size(96, 23);
            this.txtLarguraPacote.TabIndex = 3;
            // 
            // lblLargura
            // 
            this.lblLargura.AutoSize = true;
            this.lblLargura.Location = new System.Drawing.Point(6, 87);
            this.lblLargura.Name = "lblLargura";
            this.lblLargura.Size = new System.Drawing.Size(94, 17);
            this.lblLargura.TabIndex = 6;
            this.lblLargura.Text = "Largura: (cm)";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(252, 52);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(125, 23);
            this.txtQuantidade.TabIndex = 1;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(249, 31);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(86, 17);
            this.lblQuantidade.TabIndex = 4;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblTipoPacote
            // 
            this.lblTipoPacote.AutoSize = true;
            this.lblTipoPacote.Location = new System.Drawing.Point(6, 30);
            this.lblTipoPacote.Name = "lblTipoPacote";
            this.lblTipoPacote.Size = new System.Drawing.Size(153, 17);
            this.lblTipoPacote.TabIndex = 3;
            this.lblTipoPacote.Text = "Nome / Tipo do Pacote";
            this.lblTipoPacote.Click += new System.EventHandler(this.LblTipoPacote_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "PAid";
            this.ID.HeaderText = "Código";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // TipoPacote
            // 
            this.TipoPacote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TipoPacote.DataPropertyName = "PAtipo";
            this.TipoPacote.HeaderText = "Nome/Tipo";
            this.TipoPacote.Name = "TipoPacote";
            this.TipoPacote.ReadOnly = true;
            this.TipoPacote.Width = 86;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "PAquantidade";
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // Largura
            // 
            this.Largura.DataPropertyName = "PAlargura";
            this.Largura.HeaderText = "Largura (cm)";
            this.Largura.Name = "Largura";
            this.Largura.ReadOnly = true;
            // 
            // Altura
            // 
            this.Altura.DataPropertyName = "PAaltura";
            this.Altura.HeaderText = "Altura (cm)";
            this.Altura.Name = "Altura";
            this.Altura.ReadOnly = true;
            // 
            // Profundidade
            // 
            this.Profundidade.DataPropertyName = "PAprofundidade";
            this.Profundidade.HeaderText = "Profundidade (cm)";
            this.Profundidade.Name = "Profundidade";
            this.Profundidade.ReadOnly = true;
            // 
            // Peso
            // 
            this.Peso.DataPropertyName = "PApeso";
            this.Peso.HeaderText = "Peso (g)";
            this.Peso.Name = "Peso";
            this.Peso.ReadOnly = true;
            // 
            // Material
            // 
            this.Material.DataPropertyName = "nome";
            this.Material.HeaderText = "Material";
            this.Material.Name = "Material";
            this.Material.ReadOnly = true;
            // 
            // frmCadastroEmbalagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 672);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCadastroEmbalagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Embalagem";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbFiltrosPacotes.ResumeLayout(false);
            this.gbFiltrosPacotes.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroEmbalagem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMaterialPacote;
        private System.Windows.Forms.Label lblPesoPacote;
        private System.Windows.Forms.TextBox txtPesoPacote;
        private System.Windows.Forms.TextBox txtProfundidadePacote;
        private System.Windows.Forms.Label lblProfundidadePacote;
        private System.Windows.Forms.Label lblAlturaPacote;
        private System.Windows.Forms.TextBox txtAlturaPacote;
        private System.Windows.Forms.TextBox txtLarguraPacote;
        private System.Windows.Forms.Label lblLargura;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblTipoPacote;
        private System.Windows.Forms.DataGridView dgvCadastroEmbalagem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msInicioEmbalagem;
        private System.Windows.Forms.ToolStripMenuItem msCadastro;
        private System.Windows.Forms.ToolStripMenuItem msCadastroEmbalagem;
        private System.Windows.Forms.ToolStripMenuItem msCadastroProduto;
        private System.Windows.Forms.ToolStripMenuItem msCalculo;
        private System.Windows.Forms.ToolStripMenuItem msSair;
        private System.Windows.Forms.ToolStripMenuItem msCadastroLogin;
        private System.Windows.Forms.ComboBox cbMateriais;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox gbFiltrosPacotes;
        private System.Windows.Forms.Button btnPesquisarTipo;
        private System.Windows.Forms.Button btnExcluirProduto;
        private System.Windows.Forms.Button btnAlterarPacote;
        private System.Windows.Forms.Button btnSalvarPacote;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLimparFiltros;
        private System.Windows.Forms.ComboBox cbMateriaisPesquisa;
        private System.Windows.Forms.Button btnPesquisaMaterial;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtPesquisaTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPacote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Largura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Altura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profundidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
    }
}