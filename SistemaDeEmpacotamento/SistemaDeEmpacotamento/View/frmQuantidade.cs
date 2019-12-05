using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeEmpacotamento
{
    public partial class frmQuantidade : Form
    {
        produto produtoP;

        frmCalculo wCalculo;

        int currId;
        
        public frmQuantidade(produto pro, frmCalculo wCalculo, int currId)
        {
            this.produtoP = pro;
            this.wCalculo = wCalculo;
            this.currId = currId;
            
            InitializeComponent();
            lbNomeProduto.Text = this.produtoP.PRnome.ToString();
        }
        public int pegandoQtd(){
            int qtd;
            if (Int32.TryParse(txtQtd.Text, out qtd))
            {
                return qtd;
            }
            else
            {
               MessageBox.Show("Entre com um número","AVISO!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
               return 0;
            }
        }

        private void btnAdicionarQuantidade_Click(object sender, EventArgs e)
        {
            this.wCalculo.addProduct(this.produtoP, this.pegandoQtd());

            this.Close();
        }

        private void FrmQuantidade_Load(object sender, EventArgs e)
        {

        }

        private void FrmQuantidade_Leave(object sender, EventArgs e)
        {

        }
    }
}
