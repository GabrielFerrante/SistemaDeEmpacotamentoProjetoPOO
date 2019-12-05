namespace SistemaDeEmpacotamento
{
    partial class frmTelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeslogar = new System.Windows.Forms.Button();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.msCadastroLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.msCadastroEmbalagem = new System.Windows.Forms.ToolStripMenuItem();
            this.msCadastroProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mmLogs = new System.Windows.Forms.ToolStripMenuItem();
            this.button4 = new System.Windows.Forms.Button();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.btnCadastrarEmbalagem = new System.Windows.Forms.Button();
            this.btnCadastroUsuario = new System.Windows.Forms.Button();
            this.pnlLogotipo = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btnDeslogar);
            this.panel1.Controls.Add(this.lbUsuario);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnCadastrarProduto);
            this.panel1.Controls.Add(this.btnCadastrarEmbalagem);
            this.panel1.Controls.Add(this.btnCadastroUsuario);
            this.panel1.Controls.Add(this.pnlLogotipo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 412);
            this.panel1.TabIndex = 0;
            // 
            // btnDeslogar
            // 
            this.btnDeslogar.BackColor = System.Drawing.Color.Transparent;
            this.btnDeslogar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeslogar.BackgroundImage")));
            this.btnDeslogar.Location = new System.Drawing.Point(582, 27);
            this.btnDeslogar.Name = "btnDeslogar";
            this.btnDeslogar.Size = new System.Drawing.Size(42, 51);
            this.btnDeslogar.TabIndex = 5;
            this.btnDeslogar.UseVisualStyleBackColor = false;
            this.btnDeslogar.Click += new System.EventHandler(this.BtnDeslogar_Click);
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lbUsuario.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbUsuario.Location = new System.Drawing.Point(12, 46);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(84, 32);
            this.lbUsuario.TabIndex = 6;
            this.lbUsuario.Text = "USUARIO";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msCadastro,
            this.calcularToolStripMenuItem,
            this.mmLogs});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(627, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msCadastro
            // 
            this.msCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msCadastroLogin,
            this.msCadastroEmbalagem,
            this.msCadastroProduto});
            this.msCadastro.Name = "msCadastro";
            this.msCadastro.Size = new System.Drawing.Size(71, 20);
            this.msCadastro.Text = "Cadastros";
            // 
            // msCadastroLogin
            // 
            this.msCadastroLogin.Name = "msCadastroLogin";
            this.msCadastroLogin.Size = new System.Drawing.Size(187, 22);
            this.msCadastroLogin.Text = "Cadastro Login";
            this.msCadastroLogin.Click += new System.EventHandler(this.MsCadastroLogin_Click);
            // 
            // msCadastroEmbalagem
            // 
            this.msCadastroEmbalagem.Name = "msCadastroEmbalagem";
            this.msCadastroEmbalagem.Size = new System.Drawing.Size(187, 22);
            this.msCadastroEmbalagem.Text = "Cadastro Embalagem";
            this.msCadastroEmbalagem.Click += new System.EventHandler(this.MsCadastroEmbalagem_Click);
            // 
            // msCadastroProduto
            // 
            this.msCadastroProduto.Name = "msCadastroProduto";
            this.msCadastroProduto.Size = new System.Drawing.Size(187, 22);
            this.msCadastroProduto.Text = "Cadastro Produto";
            this.msCadastroProduto.Click += new System.EventHandler(this.MsCadastroProduto_Click);
            // 
            // calcularToolStripMenuItem
            // 
            this.calcularToolStripMenuItem.Name = "calcularToolStripMenuItem";
            this.calcularToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.calcularToolStripMenuItem.Text = "Calcular entregas";
            this.calcularToolStripMenuItem.Click += new System.EventHandler(this.CalcularToolStripMenuItem_Click);
            // 
            // mmLogs
            // 
            this.mmLogs.Name = "mmLogs";
            this.mmLogs.Size = new System.Drawing.Size(44, 20);
            this.mmLogs.Text = "Logs";
            this.mmLogs.Click += new System.EventHandler(this.mmLogs_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.Location = new System.Drawing.Point(449, 250);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 150);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrarProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCadastrarProduto.BackgroundImage")));
            this.btnCadastrarProduto.Location = new System.Drawing.Point(449, 92);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(150, 150);
            this.btnCadastrarProduto.TabIndex = 3;
            this.btnCadastrarProduto.UseVisualStyleBackColor = false;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.BtnCadastrarProduto_Click);
            // 
            // btnCadastrarEmbalagem
            // 
            this.btnCadastrarEmbalagem.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrarEmbalagem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCadastrarEmbalagem.BackgroundImage")));
            this.btnCadastrarEmbalagem.Location = new System.Drawing.Point(278, 250);
            this.btnCadastrarEmbalagem.Name = "btnCadastrarEmbalagem";
            this.btnCadastrarEmbalagem.Size = new System.Drawing.Size(150, 150);
            this.btnCadastrarEmbalagem.TabIndex = 2;
            this.btnCadastrarEmbalagem.UseVisualStyleBackColor = false;
            this.btnCadastrarEmbalagem.Click += new System.EventHandler(this.BtnCadastrarEmbalagem_Click);
            // 
            // btnCadastroUsuario
            // 
            this.btnCadastroUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastroUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCadastroUsuario.BackgroundImage")));
            this.btnCadastroUsuario.Location = new System.Drawing.Point(278, 92);
            this.btnCadastroUsuario.Name = "btnCadastroUsuario";
            this.btnCadastroUsuario.Size = new System.Drawing.Size(150, 150);
            this.btnCadastroUsuario.TabIndex = 1;
            this.btnCadastroUsuario.UseVisualStyleBackColor = false;
            this.btnCadastroUsuario.Click += new System.EventHandler(this.BtnCadastroUsuario_Click);
            // 
            // pnlLogotipo
            // 
            this.pnlLogotipo.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogotipo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLogotipo.BackgroundImage")));
            this.pnlLogotipo.Location = new System.Drawing.Point(12, 92);
            this.pnlLogotipo.Name = "pnlLogotipo";
            this.pnlLogotipo.Size = new System.Drawing.Size(250, 250);
            this.pnlLogotipo.TabIndex = 0;
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 412);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empac Sistema";
            this.Load += new System.EventHandler(this.frmTelaPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlLogotipo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnCadastrarProduto;
        private System.Windows.Forms.Button btnCadastrarEmbalagem;
        private System.Windows.Forms.Button btnCadastroUsuario;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msCadastro;
        private System.Windows.Forms.ToolStripMenuItem msCadastroLogin;
        private System.Windows.Forms.ToolStripMenuItem msCadastroEmbalagem;
        private System.Windows.Forms.ToolStripMenuItem msCadastroProduto;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Button btnDeslogar;
        private System.Windows.Forms.ToolStripMenuItem calcularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mmLogs;
    }
}