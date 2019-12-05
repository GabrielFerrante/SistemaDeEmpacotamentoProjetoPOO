namespace SistemaDeEmpacotamento
{
    partial class frmCadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroUsuario));
            this.pnlCadastroUsuario = new System.Windows.Forms.Panel();
            this.dgvCadastroUsuarios = new System.Windows.Forms.DataGridView();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gbOpcaoes = new System.Windows.Forms.GroupBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.msCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.msCadastroLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.msCadastroEmbalagem = new System.Windows.Forms.ToolStripMenuItem();
            this.msCadastroProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.msCalculo = new System.Windows.Forms.ToolStripMenuItem();
            this.msSair = new System.Windows.Forms.ToolStripMenuItem();
            this.USid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USnome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USlogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAnome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlCadastroUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroUsuarios)).BeginInit();
            this.gbLogin.SuspendLayout();
            this.gbOpcaoes.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCadastroUsuario
            // 
            this.pnlCadastroUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCadastroUsuario.BackgroundImage")));
            this.pnlCadastroUsuario.Controls.Add(this.dgvCadastroUsuarios);
            this.pnlCadastroUsuario.Controls.Add(this.gbLogin);
            this.pnlCadastroUsuario.Controls.Add(this.menuStrip1);
            this.pnlCadastroUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCadastroUsuario.Location = new System.Drawing.Point(0, 0);
            this.pnlCadastroUsuario.Name = "pnlCadastroUsuario";
            this.pnlCadastroUsuario.Size = new System.Drawing.Size(570, 651);
            this.pnlCadastroUsuario.TabIndex = 0;
            this.pnlCadastroUsuario.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCadastroUsuario_Paint);
            // 
            // dgvCadastroUsuarios
            // 
            this.dgvCadastroUsuarios.AllowUserToAddRows = false;
            this.dgvCadastroUsuarios.AllowUserToDeleteRows = false;
            this.dgvCadastroUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastroUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.USid,
            this.USnome,
            this.USlogin,
            this.CAnome});
            this.dgvCadastroUsuarios.Location = new System.Drawing.Point(0, 408);
            this.dgvCadastroUsuarios.Name = "dgvCadastroUsuarios";
            this.dgvCadastroUsuarios.ReadOnly = true;
            this.dgvCadastroUsuarios.Size = new System.Drawing.Size(575, 240);
            this.dgvCadastroUsuarios.TabIndex = 14;
            // 
            // gbLogin
            // 
            this.gbLogin.BackColor = System.Drawing.Color.Transparent;
            this.gbLogin.Controls.Add(this.btnLimpar);
            this.gbLogin.Controls.Add(this.gbOpcaoes);
            this.gbLogin.Controls.Add(this.label2);
            this.gbLogin.Controls.Add(this.cbCargo);
            this.gbLogin.Controls.Add(this.txtSenha);
            this.gbLogin.Controls.Add(this.label1);
            this.gbLogin.Controls.Add(this.txtLogin);
            this.gbLogin.Controls.Add(this.lblSenha);
            this.gbLogin.Controls.Add(this.lblNome);
            this.gbLogin.Controls.Add(this.txtNome);
            this.gbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbLogin.Location = new System.Drawing.Point(12, 39);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(546, 363);
            this.gbLogin.TabIndex = 13;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Cadastro de Usuários";
            // 
            // btnLimpar
            // 
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpar.Location = new System.Drawing.Point(449, 231);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // gbOpcaoes
            // 
            this.gbOpcaoes.BackColor = System.Drawing.Color.Transparent;
            this.gbOpcaoes.Controls.Add(this.btnAlterar);
            this.gbOpcaoes.Controls.Add(this.btnSalvar);
            this.gbOpcaoes.Controls.Add(this.btnExcluir);
            this.gbOpcaoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpcaoes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbOpcaoes.Location = new System.Drawing.Point(121, 288);
            this.gbOpcaoes.Name = "gbOpcaoes";
            this.gbOpcaoes.Size = new System.Drawing.Size(328, 60);
            this.gbOpcaoes.TabIndex = 18;
            this.gbOpcaoes.TabStop = false;
            this.gbOpcaoes.Text = "Opções";
            // 
            // btnAlterar
            // 
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAlterar.Location = new System.Drawing.Point(90, 19);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 26);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalvar.Location = new System.Drawing.Point(9, 19);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 26);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExcluir.Location = new System.Drawing.Point(232, 19);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 26);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cargo";
            // 
            // cbCargo
            // 
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Items.AddRange(new object[] {
            "Administrador",
            "Funcionário"});
            this.cbCargo.Location = new System.Drawing.Point(11, 230);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(216, 24);
            this.cbCargo.TabIndex = 4;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(11, 172);
            this.txtSenha.MaxLength = 12;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(136, 23);
            this.txtSenha.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(8, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Senha: (Max: 12 caracteres)";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(9, 106);
            this.txtLogin.MaxLength = 30;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(218, 23);
            this.txtLogin.TabIndex = 2;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSenha.Location = new System.Drawing.Point(6, 86);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(47, 17);
            this.lblSenha.TabIndex = 12;
            this.lblSenha.Text = "Login:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNome.Location = new System.Drawing.Point(6, 26);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 17);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(9, 46);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(529, 23);
            this.txtNome.TabIndex = 0;
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
            this.menuStrip1.Size = new System.Drawing.Size(570, 24);
            this.menuStrip1.TabIndex = 12;
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
            // USid
            // 
            this.USid.DataPropertyName = "USid";
            this.USid.HeaderText = "Código";
            this.USid.Name = "USid";
            this.USid.ReadOnly = true;
            // 
            // USnome
            // 
            this.USnome.DataPropertyName = "USnome";
            this.USnome.HeaderText = "Nome";
            this.USnome.Name = "USnome";
            this.USnome.ReadOnly = true;
            this.USnome.Width = 225;
            // 
            // USlogin
            // 
            this.USlogin.DataPropertyName = "USlogin";
            this.USlogin.HeaderText = "Login";
            this.USlogin.Name = "USlogin";
            this.USlogin.ReadOnly = true;
            // 
            // CAnome
            // 
            this.CAnome.DataPropertyName = "Cargo";
            this.CAnome.HeaderText = "Cargo";
            this.CAnome.Name = "CAnome";
            this.CAnome.ReadOnly = true;
            // 
            // frmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(570, 651);
            this.Controls.Add(this.pnlCadastroUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Login";
            this.pnlCadastroUsuario.ResumeLayout(false);
            this.pnlCadastroUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroUsuarios)).EndInit();
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.gbOpcaoes.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCadastroUsuario;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msInicio;
        private System.Windows.Forms.ToolStripMenuItem msCadastro;
        private System.Windows.Forms.ToolStripMenuItem msCadastroEmbalagem;
        private System.Windows.Forms.ToolStripMenuItem msCadastroProduto;
        private System.Windows.Forms.ToolStripMenuItem msCalculo;
        private System.Windows.Forms.ToolStripMenuItem msSair;
        private System.Windows.Forms.ToolStripMenuItem msCadastroLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.GroupBox gbOpcaoes;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridView dgvCadastroUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn USid;
        private System.Windows.Forms.DataGridViewTextBoxColumn USnome;
        private System.Windows.Forms.DataGridViewTextBoxColumn USlogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAnome;
    }
}