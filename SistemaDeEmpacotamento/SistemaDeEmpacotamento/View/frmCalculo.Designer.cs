namespace SistemaDeEmpacotamento
{
    partial class frmCalculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlCalculo = new System.Windows.Forms.Panel();
            this.gbCalculoCalcula = new System.Windows.Forms.GroupBox();
            this.btnLimparGrid = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.dgvCalcular = new System.Windows.Forms.DataGridView();
            this.ID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRpeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Largura2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Altura2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profundidade2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbCalculoAdicionar = new System.Windows.Forms.GroupBox();
            this.btnPesquisarNome = new System.Windows.Forms.Button();
            this.txtNomePesquisa = new System.Windows.Forms.TextBox();
            this.btnAdicionarCalculo = new System.Windows.Forms.Button();
            this.dgvAdicionar = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRquantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Largura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Altura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profundidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.msCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.msCadastroLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.msCadastroEmbalagem = new System.Windows.Forms.ToolStripMenuItem();
            this.msCadastroProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.msCalculo = new System.Windows.Forms.ToolStripMenuItem();
            this.msSair = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLimparPesquisa = new System.Windows.Forms.Button();
            this.pnlCalculo.SuspendLayout();
            this.gbCalculoCalcula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalcular)).BeginInit();
            this.gbCalculoAdicionar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdicionar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCalculo
            // 
            this.pnlCalculo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCalculo.BackgroundImage")));
            this.pnlCalculo.Controls.Add(this.gbCalculoCalcula);
            this.pnlCalculo.Controls.Add(this.gbCalculoAdicionar);
            this.pnlCalculo.Controls.Add(this.menuStrip1);
            this.pnlCalculo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCalculo.Location = new System.Drawing.Point(0, 0);
            this.pnlCalculo.Name = "pnlCalculo";
            this.pnlCalculo.Size = new System.Drawing.Size(850, 616);
            this.pnlCalculo.TabIndex = 0;
            // 
            // gbCalculoCalcula
            // 
            this.gbCalculoCalcula.BackColor = System.Drawing.Color.Transparent;
            this.gbCalculoCalcula.Controls.Add(this.btnLimparGrid);
            this.gbCalculoCalcula.Controls.Add(this.btnCalcular);
            this.gbCalculoCalcula.Controls.Add(this.dgvCalcular);
            this.gbCalculoCalcula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCalculoCalcula.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbCalculoCalcula.Location = new System.Drawing.Point(12, 381);
            this.gbCalculoCalcula.Name = "gbCalculoCalcula";
            this.gbCalculoCalcula.Size = new System.Drawing.Size(826, 223);
            this.gbCalculoCalcula.TabIndex = 4;
            this.gbCalculoCalcula.TabStop = false;
            this.gbCalculoCalcula.Text = "Calcular";
            this.gbCalculoCalcula.Enter += new System.EventHandler(this.GbCalculoCalcula_Enter);
            // 
            // btnLimparGrid
            // 
            this.btnLimparGrid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimparGrid.Location = new System.Drawing.Point(17, 175);
            this.btnLimparGrid.Name = "btnLimparGrid";
            this.btnLimparGrid.Size = new System.Drawing.Size(86, 32);
            this.btnLimparGrid.TabIndex = 4;
            this.btnLimparGrid.Text = "Limpar";
            this.btnLimparGrid.UseVisualStyleBackColor = true;
            this.btnLimparGrid.Click += new System.EventHandler(this.BtnLimparGrid_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCalcular.Location = new System.Drawing.Point(726, 166);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(94, 50);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // dgvCalcular
            // 
            this.dgvCalcular.AllowUserToAddRows = false;
            this.dgvCalcular.AllowUserToDeleteRows = false;
            this.dgvCalcular.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvCalcular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalcular.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID2,
            this.Nome2,
            this.Quantidade2,
            this.PRpeso,
            this.Largura2,
            this.Altura2,
            this.Profundidade2});
            this.dgvCalcular.Location = new System.Drawing.Point(6, 22);
            this.dgvCalcular.Name = "dgvCalcular";
            this.dgvCalcular.ReadOnly = true;
            this.dgvCalcular.Size = new System.Drawing.Size(814, 138);
            this.dgvCalcular.TabIndex = 1;
            // 
            // ID2
            // 
            this.ID2.DataPropertyName = "PRid";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.ID2.DefaultCellStyle = dataGridViewCellStyle1;
            this.ID2.HeaderText = "ID";
            this.ID2.Name = "ID2";
            this.ID2.ReadOnly = true;
            this.ID2.Width = 50;
            // 
            // Nome2
            // 
            this.Nome2.DataPropertyName = "PRnome";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.Nome2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Nome2.HeaderText = "Nome";
            this.Nome2.Name = "Nome2";
            this.Nome2.ReadOnly = true;
            this.Nome2.Width = 150;
            // 
            // Quantidade2
            // 
            this.Quantidade2.DataPropertyName = "PRquantidade";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.Quantidade2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Quantidade2.HeaderText = "Quantidade";
            this.Quantidade2.Name = "Quantidade2";
            this.Quantidade2.ReadOnly = true;
            // 
            // PRpeso
            // 
            this.PRpeso.DataPropertyName = "PRpeso";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.PRpeso.DefaultCellStyle = dataGridViewCellStyle4;
            this.PRpeso.HeaderText = "Peso";
            this.PRpeso.Name = "PRpeso";
            this.PRpeso.ReadOnly = true;
            // 
            // Largura2
            // 
            this.Largura2.DataPropertyName = "PRlargura";
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.Largura2.DefaultCellStyle = dataGridViewCellStyle5;
            this.Largura2.HeaderText = "Largura (cm)";
            this.Largura2.Name = "Largura2";
            this.Largura2.ReadOnly = true;
            this.Largura2.Width = 130;
            // 
            // Altura2
            // 
            this.Altura2.DataPropertyName = "PRaltura";
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.Altura2.DefaultCellStyle = dataGridViewCellStyle6;
            this.Altura2.HeaderText = "Altura (cm)";
            this.Altura2.Name = "Altura2";
            this.Altura2.ReadOnly = true;
            this.Altura2.Width = 110;
            // 
            // Profundidade2
            // 
            this.Profundidade2.DataPropertyName = "PRprofundidade";
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.Profundidade2.DefaultCellStyle = dataGridViewCellStyle7;
            this.Profundidade2.HeaderText = "Profundidade (cm)";
            this.Profundidade2.Name = "Profundidade2";
            this.Profundidade2.ReadOnly = true;
            this.Profundidade2.Width = 150;
            // 
            // gbCalculoAdicionar
            // 
            this.gbCalculoAdicionar.BackColor = System.Drawing.Color.Transparent;
            this.gbCalculoAdicionar.Controls.Add(this.btnLimparPesquisa);
            this.gbCalculoAdicionar.Controls.Add(this.btnPesquisarNome);
            this.gbCalculoAdicionar.Controls.Add(this.txtNomePesquisa);
            this.gbCalculoAdicionar.Controls.Add(this.btnAdicionarCalculo);
            this.gbCalculoAdicionar.Controls.Add(this.dgvAdicionar);
            this.gbCalculoAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCalculoAdicionar.ForeColor = System.Drawing.Color.White;
            this.gbCalculoAdicionar.Location = new System.Drawing.Point(12, 37);
            this.gbCalculoAdicionar.Name = "gbCalculoAdicionar";
            this.gbCalculoAdicionar.Size = new System.Drawing.Size(826, 338);
            this.gbCalculoAdicionar.TabIndex = 2;
            this.gbCalculoAdicionar.TabStop = false;
            this.gbCalculoAdicionar.Text = "Adicionar";
            // 
            // btnPesquisarNome
            // 
            this.btnPesquisarNome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPesquisarNome.Location = new System.Drawing.Point(6, 294);
            this.btnPesquisarNome.Name = "btnPesquisarNome";
            this.btnPesquisarNome.Size = new System.Drawing.Size(145, 28);
            this.btnPesquisarNome.TabIndex = 17;
            this.btnPesquisarNome.Text = "Pesquisar por nome";
            this.btnPesquisarNome.UseVisualStyleBackColor = true;
            this.btnPesquisarNome.Click += new System.EventHandler(this.BtnPesquisarNome_Click);
            // 
            // txtNomePesquisa
            // 
            this.txtNomePesquisa.Location = new System.Drawing.Point(167, 297);
            this.txtNomePesquisa.Name = "txtNomePesquisa";
            this.txtNomePesquisa.Size = new System.Drawing.Size(344, 23);
            this.txtNomePesquisa.TabIndex = 16;
            // 
            // btnAdicionarCalculo
            // 
            this.btnAdicionarCalculo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdicionarCalculo.Location = new System.Drawing.Point(723, 274);
            this.btnAdicionarCalculo.Name = "btnAdicionarCalculo";
            this.btnAdicionarCalculo.Size = new System.Drawing.Size(86, 48);
            this.btnAdicionarCalculo.TabIndex = 2;
            this.btnAdicionarCalculo.Text = "Adicionar";
            this.btnAdicionarCalculo.UseVisualStyleBackColor = true;
            this.btnAdicionarCalculo.Click += new System.EventHandler(this.btnAdicionarCalculo_Click);
            // 
            // dgvAdicionar
            // 
            this.dgvAdicionar.AllowUserToAddRows = false;
            this.dgvAdicionar.AllowUserToDeleteRows = false;
            this.dgvAdicionar.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvAdicionar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdicionar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.PRquantidade,
            this.peso,
            this.Largura,
            this.Altura,
            this.Profundidade});
            this.dgvAdicionar.GridColor = System.Drawing.SystemColors.Control;
            this.dgvAdicionar.Location = new System.Drawing.Point(6, 22);
            this.dgvAdicionar.Name = "dgvAdicionar";
            this.dgvAdicionar.ReadOnly = true;
            this.dgvAdicionar.Size = new System.Drawing.Size(814, 246);
            this.dgvAdicionar.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "PRid";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.ID.DefaultCellStyle = dataGridViewCellStyle8;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "PRnome";
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            this.Nome.DefaultCellStyle = dataGridViewCellStyle9;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 160;
            // 
            // PRquantidade
            // 
            this.PRquantidade.DataPropertyName = "PRquantidade";
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.PRquantidade.DefaultCellStyle = dataGridViewCellStyle10;
            this.PRquantidade.HeaderText = "Quantidade";
            this.PRquantidade.Name = "PRquantidade";
            this.PRquantidade.ReadOnly = true;
            // 
            // peso
            // 
            this.peso.DataPropertyName = "PRpeso";
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            this.peso.DefaultCellStyle = dataGridViewCellStyle11;
            this.peso.HeaderText = "Peso";
            this.peso.Name = "peso";
            this.peso.ReadOnly = true;
            // 
            // Largura
            // 
            this.Largura.DataPropertyName = "PRlargura";
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            this.Largura.DefaultCellStyle = dataGridViewCellStyle12;
            this.Largura.HeaderText = "Largura (cm)";
            this.Largura.Name = "Largura";
            this.Largura.ReadOnly = true;
            this.Largura.Width = 120;
            // 
            // Altura
            // 
            this.Altura.DataPropertyName = "PRaltura";
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            this.Altura.DefaultCellStyle = dataGridViewCellStyle13;
            this.Altura.HeaderText = "Altura (cm)";
            this.Altura.Name = "Altura";
            this.Altura.ReadOnly = true;
            this.Altura.Width = 110;
            // 
            // Profundidade
            // 
            this.Profundidade.DataPropertyName = "PRprofundidade";
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            this.Profundidade.DefaultCellStyle = dataGridViewCellStyle14;
            this.Profundidade.HeaderText = "Profundidade (cm)";
            this.Profundidade.Name = "Profundidade";
            this.Profundidade.ReadOnly = true;
            this.Profundidade.Width = 160;
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
            this.menuStrip1.Size = new System.Drawing.Size(850, 24);
            this.menuStrip1.TabIndex = 1;
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
            // btnLimparPesquisa
            // 
            this.btnLimparPesquisa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimparPesquisa.Location = new System.Drawing.Point(517, 294);
            this.btnLimparPesquisa.Name = "btnLimparPesquisa";
            this.btnLimparPesquisa.Size = new System.Drawing.Size(83, 28);
            this.btnLimparPesquisa.TabIndex = 18;
            this.btnLimparPesquisa.Text = "Limpar";
            this.btnLimparPesquisa.UseVisualStyleBackColor = true;
            this.btnLimparPesquisa.Click += new System.EventHandler(this.BtnLimparPesquisa_Click);
            // 
            // frmCalculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 616);
            this.Controls.Add(this.pnlCalculo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCalculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo ";
            this.Load += new System.EventHandler(this.FrmCalculo_Load);
            this.pnlCalculo.ResumeLayout(false);
            this.pnlCalculo.PerformLayout();
            this.gbCalculoCalcula.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalcular)).EndInit();
            this.gbCalculoAdicionar.ResumeLayout(false);
            this.gbCalculoAdicionar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdicionar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCalculo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msInicio;
        private System.Windows.Forms.ToolStripMenuItem msCadastro;
        private System.Windows.Forms.ToolStripMenuItem msCadastroEmbalagem;
        private System.Windows.Forms.ToolStripMenuItem msCadastroProduto;
        private System.Windows.Forms.ToolStripMenuItem msCalculo;
        private System.Windows.Forms.ToolStripMenuItem msSair;
        private System.Windows.Forms.GroupBox gbCalculoCalcula;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DataGridView dgvCalcular;
        private System.Windows.Forms.GroupBox gbCalculoAdicionar;
        private System.Windows.Forms.Button btnAdicionarCalculo;
        private System.Windows.Forms.DataGridView dgvAdicionar;
        private System.Windows.Forms.ToolStripMenuItem msCadastroLogin;
        private System.Windows.Forms.TextBox txtNomePesquisa;
        private System.Windows.Forms.Button btnPesquisarNome;
        private System.Windows.Forms.Button btnLimparGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRpeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Largura2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Altura2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profundidade2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRquantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Largura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Altura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profundidade;
        private System.Windows.Forms.Button btnLimparPesquisa;
    }
}