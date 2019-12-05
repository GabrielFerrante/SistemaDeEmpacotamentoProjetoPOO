namespace SistemaDeEmpacotamento
{
    partial class frmQuantidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuantidade));
            this.pnlQuantidade = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNomeProduto = new System.Windows.Forms.Label();
            this.btnAdicionarQuantidade = new System.Windows.Forms.Button();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.pnlQuantidade.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlQuantidade
            // 
            this.pnlQuantidade.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlQuantidade.BackgroundImage")));
            this.pnlQuantidade.Controls.Add(this.label2);
            this.pnlQuantidade.Controls.Add(this.lbNomeProduto);
            this.pnlQuantidade.Controls.Add(this.btnAdicionarQuantidade);
            this.pnlQuantidade.Controls.Add(this.txtQtd);
            this.pnlQuantidade.Controls.Add(this.lblQuantidade);
            this.pnlQuantidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQuantidade.Location = new System.Drawing.Point(0, 0);
            this.pnlQuantidade.Name = "pnlQuantidade";
            this.pnlQuantidade.Size = new System.Drawing.Size(372, 139);
            this.pnlQuantidade.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "PRODUTO SELECIONADO :";
            // 
            // lbNomeProduto
            // 
            this.lbNomeProduto.AutoSize = true;
            this.lbNomeProduto.BackColor = System.Drawing.Color.Transparent;
            this.lbNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeProduto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNomeProduto.Location = new System.Drawing.Point(176, 9);
            this.lbNomeProduto.Name = "lbNomeProduto";
            this.lbNomeProduto.Size = new System.Drawing.Size(56, 20);
            this.lbNomeProduto.TabIndex = 7;
            this.lbNomeProduto.Text = "NOME";
            // 
            // btnAdicionarQuantidade
            // 
            this.btnAdicionarQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarQuantidade.Location = new System.Drawing.Point(157, 104);
            this.btnAdicionarQuantidade.Name = "btnAdicionarQuantidade";
            this.btnAdicionarQuantidade.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarQuantidade.TabIndex = 6;
            this.btnAdicionarQuantidade.Text = "Adicionar";
            this.btnAdicionarQuantidade.UseVisualStyleBackColor = true;
            this.btnAdicionarQuantidade.Click += new System.EventHandler(this.btnAdicionarQuantidade_Click);
            // 
            // txtQtd
            // 
            this.txtQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtd.Location = new System.Drawing.Point(105, 75);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(173, 23);
            this.txtQtd.TabIndex = 5;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblQuantidade.Location = new System.Drawing.Point(146, 46);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(86, 17);
            this.lblQuantidade.TabIndex = 4;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // frmQuantidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 139);
            this.Controls.Add(this.pnlQuantidade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuantidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quantidade";
            this.Load += new System.EventHandler(this.FrmQuantidade_Load);
            this.Leave += new System.EventHandler(this.FrmQuantidade_Leave);
            this.pnlQuantidade.ResumeLayout(false);
            this.pnlQuantidade.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlQuantidade;
        private System.Windows.Forms.Button btnAdicionarQuantidade;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lbNomeProduto;
        private System.Windows.Forms.Label label2;
    }
}