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
    public partial class frmCalculo : Form
    {
        List<produto> listaProdutos = new List<produto>();
       
        usuario usuarioLogado;
        public frmCalculo(usuario user)
        {
            this.usuarioLogado = user;
            InitializeComponent();
            this.CarregarGridAdd();
        }
       
        private void CarregarGridAdd()
        {
            try
            {
                using (Entities ef = new Entities())
                {
                    List<produto> listaProdutos = ef.produtos.ToList();
                    dgvAdicionar.AutoGenerateColumns = false;
                    dgvAdicionar.DataSource = listaProdutos;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossível carregar dados" + " " + ex, "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CarregarGridCalc()
        {
            dgvCalcular.DataSource = null;
            dgvCalcular.AutoGenerateColumns = false;
            dgvCalcular.DataSource = this.listaProdutos;
        }

        private void FrmCalculo_Load(object sender, EventArgs e)
        {

        }

        public void addProduct(produto pro, int qtd)
        {
            if (qtd > pro.PRquantidade)
            {
                MessageBox.Show("Quantidade maior que a existente", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                pro.PRquantidade = qtd;

                if (this.listaProdutos == null)
                {
                    this.listaProdutos.Add(pro);
                    this.CarregarGridCalc();
                }
                else if (this.listaProdutos.Exists(pr => pr.PRid.Equals(pro.PRid)))
                {

                    MessageBox.Show("Produto já existente na lista", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    this.listaProdutos.Add(pro);
                    this.CarregarGridCalc();
                }

            }
        }

        private void btnAdicionarCalculo_Click(object sender, EventArgs e)
        {
            if (dgvAdicionar.RowCount > 0)
            {
                if (!dgvAdicionar.CurrentRow.Cells[0].Value.ToString().Equals(""))
                {
                    int id = Convert.ToInt32(dgvAdicionar.CurrentRow.Cells[0].Value.ToString());
                    using (Entities ef = new Entities())
                    {
                        produto pro = ef.produtos.Find(id);
                        (new frmQuantidade(pro, this, id)).ShowDialog();
                    }

                }
            }
            else
            {
                MessageBox.Show("Não existe produtos cadastrados", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

           
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (this.listaProdutos.Count == 0)
            {
                MessageBox.Show("NÃO HÁ PRODUTOS SELECIONADOS !", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("É UMA SIMULAÇÃO ? \nSE NÃO FOR, IRÁ ALTERAR A QUANTIDADE !", "AVISO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes))
                {
                    (new frmResultado(this.listaProdutos)).ShowDialog();
                }
                else
                {
                    (new frmResultado(this.listaProdutos)).ShowDialog();
                    foreach (produto item in this.listaProdutos)
                    {
                        using (Entities ef = new Entities())
                        {
                            produto pr = ef.produtos.Find(item.PRid);
                            ef.alterarProduto(
                                item.PRid,
                                item.PRnome,
                                item.PRpeso,
                                item.PRlargura,
                                item.PRaltura,
                                item.PRprofundidade,
                                usuarioLogado.USid,
                                pr.PRquantidade - item.PRquantidade
                            );
                        }
                    }

                }
                this.CarregarGridAdd();
            }
            
            
            
        }

        private void BtnPesquisarNome_Click(object sender, EventArgs e)
        {
            try
            {
                using (Entities ef = new Entities())
                {
                    var listaProdutosFiltrados = ef.produtos.Where(pr => pr.PRnome.Contains(txtNomePesquisa.Text)).ToList();
                    dgvAdicionar.AutoGenerateColumns = false;
                    dgvAdicionar.DataSource = listaProdutosFiltrados;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO FAZER A OPERAÇÃO " + ex, "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GbCalculoCalcula_Enter(object sender, EventArgs e)
        {

        }

        private void BtnLimparGrid_Click(object sender, EventArgs e)
        {
            dgvCalcular.DataSource = null;
            this.listaProdutos.RemoveAll(p => p.PRid != 0);
        }

        private void BtnLimparPesquisa_Click(object sender, EventArgs e)
        {
            txtNomePesquisa.Text = string.Empty;
            CarregarGridAdd();
        }
    }
}
