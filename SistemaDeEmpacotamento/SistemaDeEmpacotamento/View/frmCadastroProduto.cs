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
    public partial class frmCadastroProduto : Form
    {
        int idProduto;
        int modo = 1;
        usuario usuarioLogado;
        public frmCadastroProduto(usuario user)
        {
            this.usuarioLogado = user;
            InitializeComponent();
            CarregarGrid();
        }
        private void CarregarGrid()
        {
            try
            {
                using (Entities ef = new Entities())
                {
                List<produto> listaProdutos = ef.produtos.ToList();
                dgvCadastroProduto.AutoGenerateColumns = false;
                dgvCadastroProduto.DataSource = listaProdutos;
                
                }

            }catch(Exception ex){
                MessageBox.Show("Impossível carregar dados" + " " + ex, "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }
        private void CarregarCamposAlterar()
        {
            try
            {
                using (Entities ef = new Entities())
                {
                    produto pr = ef.produtos.Find(idProduto);

                    txtAltura.Text = pr.PRaltura.ToString();
                    txtLargura.Text = pr.PRlargura.ToString();
                    txtNome.Text = pr.PRnome;
                    txtPeso.Text = pr.PRpeso.ToString();
                    txtProfundidade.Text = pr.PRprofundidade.ToString();
                    txtQuantidade.Text = pr.PRquantidade.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossível carregar dados" + " " + ex,"ERRO!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private int verificaDados()
        {
            
            if (txtAltura.Text == string.Empty
                      || txtLargura.Text == string.Empty
                      || txtNome.Text == string.Empty
                      || txtPeso.Text == string.Empty
                      || txtProfundidade.Text == string.Empty
                      || txtQuantidade.Text == string.Empty)
            {

               return 1;
            }
            else
            {
                int  peso, prof, lar, alt, qtd;
                if (
                    !Int32.TryParse(txtAltura.Text,out alt)||
                    !Int32.TryParse(txtLargura.Text,out lar)||
                    !Int32.TryParse(txtPeso.Text,out peso)||
                    !Int32.TryParse(txtProfundidade.Text,out prof)||
                    !Int32.TryParse(txtQuantidade.Text,out qtd)
                    )
                {
                    return 2;
                }
                return 0;
            }
            
            
         
          
        }
        private void LimparDados()
        {
            txtAltura.Text = string.Empty;
            txtLargura.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtPeso.Text = string.Empty;
            txtProfundidade.Text = string.Empty;
            txtQuantidade.Text = string.Empty;
            
        }
        private void LblLargura_Click(object sender, EventArgs e)
        {

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            this.LimparDados();
            this.modo = 1;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (verificaDados() == 0) 
                {
                    using (Entities ef = new Entities())
                    {
                        if (modo.Equals(1))
                        {
                            ef.salvarProduto(
                                txtNome.Text,
                                Convert.ToInt32(txtPeso.Text),
                                Convert.ToInt32(txtLargura.Text),
                                Convert.ToInt32(txtAltura.Text),
                                Convert.ToInt32(txtProfundidade.Text),
                                usuarioLogado.USid,
                                Convert.ToInt32(txtQuantidade.Text)
                                );
                            MessageBox.Show("Produto cadastrado com sucesso", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            
                            ef.alterarProduto(
                                    idProduto,
                                    txtNome.Text,
                                    Convert.ToInt32(txtPeso.Text),
                                    Convert.ToInt32(txtLargura.Text),
                                    Convert.ToInt32(txtAltura.Text),
                                    Convert.ToInt32(txtProfundidade.Text),
                                    usuarioLogado.USid,
                                    Convert.ToInt32(txtQuantidade.Text)
                                );
                            MessageBox.Show("Produto alterado com sucesso", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.modo = 1;
                        }
                        ef.SaveChanges();
                    }   
                    
                    LimparDados();
                    CarregarGrid();
                }
                else
                {
                    if (this.verificaDados() == 2)
                    {
                        MessageBox.Show("Dados não numéricos!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Preencha todos os dados para salvar!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO FAZER A OPERAÇÃO " + ex, "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvCadastroProduto.Rows.Count > 0)
            {
                if (!dgvCadastroProduto.CurrentRow.Cells[0].Value.ToString().Equals(""))
                {
                    idProduto = Int32.Parse(dgvCadastroProduto.CurrentRow.Cells[0].Value.ToString());
                    this.CarregarCamposAlterar();
                    this.modo = 2;
                }
            }
            else
            {
                MessageBox.Show("Não existe produtos cadastrados", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCadastroProduto.Rows.Count > 0)
                {
                    if (MessageBox.Show(
                        "Deseja excluir o produto ?\nCÓDIGO DO PRODUTO: " + dgvCadastroProduto.CurrentRow.Cells[0].Value.ToString(),
                        "AVISO!",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (!dgvCadastroProduto.CurrentRow.Cells[0].Value.ToString().Equals(""))
                        {
                            this.idProduto = Convert.ToInt32(dgvCadastroProduto.CurrentRow.Cells[0].Value.ToString());
                            using (Entities ef = new Entities())
                            {
                                produto pro = ef.produtos.Find(idProduto);
                                log l = new log();
                                l.LOoperacao = "Exclusão do produto: " + pro.PRnome;
                                l.LOdata = DateTime.Now;
                                l.USid = usuarioLogado.USid;


                                ef.logs.Add(l);
                                ef.produtos.Remove(pro);
                                ef.SaveChanges();
                            }
                            MessageBox.Show("Produto excluído com sucesso", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        this.CarregarGrid();
                        this.LimparDados();
                    }
                }
                else
                {
                    MessageBox.Show("Não há produtos cadastrados", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível excluir", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void btnPesquisarNome_Click(object sender, EventArgs e)
        {
            try
            {
                using(Entities ef = new Entities()){
                    var listaProdutosFiltrados = ef.produtos.Where(pr => pr.PRnome.Contains(txtNomePesquisa.Text)).ToList();
                    dgvCadastroProduto.AutoGenerateColumns = false;
                    dgvCadastroProduto.DataSource = listaProdutosFiltrados;
                }
            }catch(Exception ex){
                MessageBox.Show("ERRO AO FAZER A OPERAÇÃO " + ex, "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimparFiltros_Click(object sender, EventArgs e)
        {
            CarregarGrid();
            txtNomePesquisa.Text = "";
        }
    }
}
