namespace SistemaDeEmpacotamento.View
{
    partial class frmLogsSistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogsSistema));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbLogsPesquisa = new System.Windows.Forms.GroupBox();
            this.dtDataPesquisa = new System.Windows.Forms.DateTimePicker();
            this.btnPesquisarData = new System.Windows.Forms.Button();
            this.btnLimparPesquisa = new System.Windows.Forms.Button();
            this.dgvLogsSistema = new System.Windows.Forms.DataGridView();
            this.LOid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOoperacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOdata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USnome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.gbLogsPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogsSistema)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.gbLogsPesquisa);
            this.panel1.Controls.Add(this.dgvLogsSistema);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 338);
            this.panel1.TabIndex = 0;
            // 
            // gbLogsPesquisa
            // 
            this.gbLogsPesquisa.BackColor = System.Drawing.Color.Transparent;
            this.gbLogsPesquisa.Controls.Add(this.dtDataPesquisa);
            this.gbLogsPesquisa.Controls.Add(this.btnPesquisarData);
            this.gbLogsPesquisa.Controls.Add(this.btnLimparPesquisa);
            this.gbLogsPesquisa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbLogsPesquisa.Location = new System.Drawing.Point(12, 269);
            this.gbLogsPesquisa.Name = "gbLogsPesquisa";
            this.gbLogsPesquisa.Size = new System.Drawing.Size(528, 63);
            this.gbLogsPesquisa.TabIndex = 1;
            this.gbLogsPesquisa.TabStop = false;
            this.gbLogsPesquisa.Text = "Pesquisar por Data";
            // 
            // dtDataPesquisa
            // 
            this.dtDataPesquisa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataPesquisa.Location = new System.Drawing.Point(6, 24);
            this.dtDataPesquisa.Name = "dtDataPesquisa";
            this.dtDataPesquisa.Size = new System.Drawing.Size(200, 20);
            this.dtDataPesquisa.TabIndex = 10;
            // 
            // btnPesquisarData
            // 
            this.btnPesquisarData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPesquisarData.Location = new System.Drawing.Point(212, 19);
            this.btnPesquisarData.Name = "btnPesquisarData";
            this.btnPesquisarData.Size = new System.Drawing.Size(126, 25);
            this.btnPesquisarData.TabIndex = 9;
            this.btnPesquisarData.Text = "Pesquisar Data";
            this.btnPesquisarData.UseVisualStyleBackColor = true;
            this.btnPesquisarData.Click += new System.EventHandler(this.btnPesquisarData_Click);
            // 
            // btnLimparPesquisa
            // 
            this.btnLimparPesquisa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimparPesquisa.Location = new System.Drawing.Point(410, 18);
            this.btnLimparPesquisa.Name = "btnLimparPesquisa";
            this.btnLimparPesquisa.Size = new System.Drawing.Size(112, 26);
            this.btnLimparPesquisa.TabIndex = 8;
            this.btnLimparPesquisa.Text = "Limpar Pesquisa";
            this.btnLimparPesquisa.UseVisualStyleBackColor = true;
            this.btnLimparPesquisa.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dgvLogsSistema
            // 
            this.dgvLogsSistema.AllowUserToAddRows = false;
            this.dgvLogsSistema.AllowUserToDeleteRows = false;
            this.dgvLogsSistema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogsSistema.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LOid,
            this.LOoperacao,
            this.LOdata,
            this.USnome});
            this.dgvLogsSistema.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvLogsSistema.Location = new System.Drawing.Point(0, 0);
            this.dgvLogsSistema.Name = "dgvLogsSistema";
            this.dgvLogsSistema.ReadOnly = true;
            this.dgvLogsSistema.Size = new System.Drawing.Size(552, 263);
            this.dgvLogsSistema.TabIndex = 0;
            // 
            // LOid
            // 
            this.LOid.DataPropertyName = "LOid";
            this.LOid.HeaderText = "Código";
            this.LOid.Name = "LOid";
            this.LOid.ReadOnly = true;
            this.LOid.Width = 60;
            // 
            // LOoperacao
            // 
            this.LOoperacao.DataPropertyName = "LOoperacao";
            this.LOoperacao.HeaderText = "Operação";
            this.LOoperacao.Name = "LOoperacao";
            this.LOoperacao.ReadOnly = true;
            this.LOoperacao.Width = 200;
            // 
            // LOdata
            // 
            this.LOdata.DataPropertyName = "LOdata";
            this.LOdata.HeaderText = "Data";
            this.LOdata.Name = "LOdata";
            this.LOdata.ReadOnly = true;
            // 
            // USnome
            // 
            this.USnome.DataPropertyName = "USnome";
            this.USnome.HeaderText = "Usuário";
            this.USnome.Name = "USnome";
            this.USnome.ReadOnly = true;
            this.USnome.Width = 150;
            // 
            // frmLogsSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 338);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogsSistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logs do Sistema";
            this.panel1.ResumeLayout(false);
            this.gbLogsPesquisa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogsSistema)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvLogsSistema;
        private System.Windows.Forms.GroupBox gbLogsPesquisa;
        private System.Windows.Forms.DateTimePicker dtDataPesquisa;
        private System.Windows.Forms.Button btnPesquisarData;
        private System.Windows.Forms.Button btnLimparPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOid;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOoperacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn USnome;
    }
}