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
    public partial class frmCadastroEmbalagem : Form
    {
        //1 Cadastro e 2 Alterar
        int modo = 1;
        int idPacote;
        usuario usuarioLogado;
        public frmCadastroEmbalagem(usuario user)
        {
            InitializeComponent();
            this.usuarioLogado = user;
            CarregarGrid();
            CarregarMateriais();
            this.LimparDados();
            
            cbMateriais.DropDownStyle = ComboBoxStyle.DropDownList;
            
            cbMateriaisPesquisa.DropDownStyle = ComboBoxStyle.DropDownList;


        }
        private void CarregarDadosAlterar()
        {
            try{
                using (Entities ef = new Entities())
                {
                    pacote pacotePAlterar = ef.pacotes.Find(this.idPacote);

                    txtAlturaPacote.Text = pacotePAlterar.PAaltura.ToString();
                    txtLarguraPacote.Text = pacotePAlterar.PAlargura.ToString();
                    txtPesoPacote.Text = pacotePAlterar.PApeso.ToString();
                    txtProfundidadePacote.Text = pacotePAlterar.PAprofundidade.ToString();
                    txtQuantidade.Text = pacotePAlterar.PAquantidade.ToString();
                    txtTipo.Text = pacotePAlterar.PAtipo.ToString();
                    cbMateriais.SelectedIndex = pacotePAlterar.MAid - 1;
                    

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Impossível carregar dados"+" "+ex,"AVISO!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
        private void CarregarMateriais()
        {
            try
            {
                using (Entities ef = new Entities())
                {
                    List<materiai> listaMateriais = ef.materiais.ToList();
                    cbMateriais.DataSource = listaMateriais;
                    cbMateriais.ValueMember = "MAid";
                    cbMateriais.DisplayMember = "nome";

                    cbMateriaisPesquisa.DataSource = listaMateriais;
                    cbMateriaisPesquisa.ValueMember = "MAid";
                    cbMateriaisPesquisa.DisplayMember = "nome";
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossível carregar dados" + " " + ex, "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
        private int VerificaDados()
        {
            if(txtAlturaPacote.Text.Equals("")
                || txtLarguraPacote.Text.Equals("")
                || cbMateriais.Text.Equals("")
                || txtPesoPacote.Text.Equals("")
                || txtProfundidadePacote.Text.Equals("")
                || txtQuantidade.Text.Equals(""))
            {
                return 1;
            }else 
            {
                int qtd, peso, prof, lar, alt;
                if (!Int32.TryParse(txtAlturaPacote.Text, out alt)
                    ||
                    !Int32.TryParse(txtLarguraPacote.Text, out lar)
                    ||
                    !Int32.TryParse(txtPesoPacote.Text, out peso)
                    ||
                    !Int32.TryParse(txtProfundidadePacote.Text, out prof)
                    ||
                    !Int32.TryParse(txtQuantidade.Text, out qtd)
                    )
                {
                    return 2;
                }
                return 0;
            }
            

        }
        private void HabilitarCampos()
        {
            txtAlturaPacote.Enabled = true;
            txtLarguraPacote.Enabled = true;
            txtPesoPacote.Enabled = true;
            txtProfundidadePacote.Enabled = true;
            txtQuantidade.Enabled = true;
            cbMateriais.Enabled = true;
            txtTipo.Enabled = true;
        }
        private void DesabilitarCampos()
        {
            txtAlturaPacote.Enabled = false;
            txtLarguraPacote.Enabled = false;
            txtPesoPacote.Enabled = false;
            txtProfundidadePacote.Enabled = false;
            txtQuantidade.Enabled = false;
            cbMateriais.Enabled = false;
            txtTipo.Enabled = false;
        }
        private void LimparDados()
        {
            txtAlturaPacote.Text = string.Empty;
            txtLarguraPacote.Text = string.Empty;
            cbMateriais.SelectedIndex = 0;
            cbMateriaisPesquisa.SelectedIndex = 0;
            txtPesoPacote.Text = string.Empty;
            txtPesquisaTipo.Text = string.Empty;
            txtProfundidadePacote.Text = string.Empty;
            txtQuantidade.Text = string.Empty;
            txtTipo.Text = string.Empty;
        }
        private void CarregarGrid()
        {
            try
            {
                using (Entities ef = new Entities())
                {
                    object listaPacotes = (
                         from pac in ef.pacotes
                         join mat in ef.materiais
                         on pac.MAid equals mat.MAid
                         select new
                         {
                             pac.PAid,
                             pac.PAtipo,
                             pac.PAquantidade,
                             pac.PAlargura,
                             pac.PAaltura,
                             pac.PAprofundidade,
                             pac.PApeso,
                             mat.nome
                         }
                     ).ToList();

                    dgvCadastroEmbalagem.AutoGenerateColumns = false;
                    dgvCadastroEmbalagem.DataSource = listaPacotes;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossível carregar dados "+ ex, "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void BtnSalvarPacote_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.VerificaDados() == 1)
                {
                    MessageBox.Show("Preencha todos os dados para salvar!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (this.VerificaDados() == 2)
                {
                    MessageBox.Show("Dados não numéricos!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (modo.Equals(1))
                    {
                        using (Entities ef = new Entities())
                        {

                            ef.salvarPacote(
                                txtTipo.Text,
                                Convert.ToInt32(txtQuantidade.Text),
                                Convert.ToInt32(txtLarguraPacote.Text),
                                Convert.ToInt32(txtAlturaPacote.Text),
                                Convert.ToInt32(txtProfundidadePacote.Text),
                                Convert.ToInt32(txtPesoPacote.Text),
                                Convert.ToInt32(cbMateriais.SelectedValue),
                                usuarioLogado.USid
                                );
                            ef.SaveChanges();
                        }
                        MessageBox.Show("Pacote cadastrado com sucesso", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        using (Entities ef = new Entities())
                        {
                            ef.alterarPacote(
                                idPacote,
                                txtTipo.Text,
                                Convert.ToInt32(txtQuantidade.Text),
                                Convert.ToInt32(txtLarguraPacote.Text),
                                Convert.ToInt32(txtAlturaPacote.Text),
                                Convert.ToInt32(txtProfundidadePacote.Text),
                                Convert.ToInt32(txtPesoPacote.Text),
                                Convert.ToInt32(cbMateriais.SelectedValue),
                                usuarioLogado.USid
                                );
                            ef.SaveChanges();


                        }
                        MessageBox.Show("Pacote Alterado com sucesso", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.modo = 1;
                    LimparDados();
                    this.CarregarGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO FAZER A OPERAÇÃO " + ex, "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
          
        }

        private void LblPesoPacote_Click(object sender, EventArgs e)
        {

        }

        private void BtnAlterarPacote_Click(object sender, EventArgs e)
        {
            if (dgvCadastroEmbalagem.RowCount > 0)
            {
                if (!dgvCadastroEmbalagem.CurrentRow.Cells[0].Value.ToString().Equals(""))
                {
                    
                    this.idPacote = Convert.ToInt32(dgvCadastroEmbalagem.CurrentRow.Cells[0].Value.ToString());
                    this.CarregarDadosAlterar();
                    this.modo = 2;
                }
                
            }
            else
            {
                MessageBox.Show("Não existe pacotes cadastrados","AVISO!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            this.LimparDados();
            this.modo = 1;
        }

        private void BtnExcluirProduto_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCadastroEmbalagem.Rows.Count < 1)
                {
                    MessageBox.Show("Não há pacotes/embalagens cadastrados", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (MessageBox.Show("Deseja excluir o pacote ?\nCÓDIGO DO PACOTE: "+ dgvCadastroEmbalagem.CurrentRow.Cells[0].Value.ToString()
                        ,"AVISO!",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (!dgvCadastroEmbalagem.CurrentRow.Cells[0].Value.ToString().Equals(""))
                        {
                            this.idPacote = Convert.ToInt32(dgvCadastroEmbalagem.CurrentRow.Cells[0].Value.ToString());
                            
                            using (Entities ef = new Entities())
                            {
                                pacote pac = ef.pacotes.Find(idPacote);
                                log l = new log();
                                l.LOoperacao = "Exclusão do pacote: " + pac.PAid.ToString();
                                l.LOdata = DateTime.Now;
                                l.USid = usuarioLogado.USid;


                                ef.logs.Add(l);
                                ef.pacotes.Remove(pac);
                                ef.SaveChanges();
                            }
                            MessageBox.Show("Pacote excluído com sucesso", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }
                        this.CarregarGrid();
                        this.LimparDados();
                        this.CarregarMateriais();


                    }
                   
                }

            }catch(Exception ex)
            {
                MessageBox.Show("Não foi possível excluir","ERRO!",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnPesquisarPacote_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                    using (Entities ef = new Entities())
                    {

                    var listaPacotesFiltrados = (
                       from pac in ef.pacotes
                       join mat in ef.materiais
                       on pac.MAid equals mat.MAid
                       select new
                       {
                           pac.PAid,
                           pac.PAtipo,
                           pac.PAquantidade,
                           pac.PAlargura,
                           pac.PAaltura,
                           pac.PAprofundidade,
                           pac.PApeso,
                           mat.nome,
                           
                       }
                   ).Where(pac => pac.PAtipo.Contains(txtPesquisaTipo.Text)).ToList();
                        if (listaPacotesFiltrados.Count == 0)
                        {
                            MessageBox.Show("Não houve resultados da pesquisa com esse tipo", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.CarregarGrid();
                        }
                        else
                        {
                            dgvCadastroEmbalagem.AutoGenerateColumns = false;
                            dgvCadastroEmbalagem.DataSource = listaPacotesFiltrados;
                        }
                       
                         
                    }
                
               
            }catch(Exception ex){
                MessageBox.Show("Não foi possível pesquisar", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbTipoPacote_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void cbTipoPacote_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnLimparFiltros_Click(object sender, EventArgs e)
        {
            txtPesquisaTipo.Text = string.Empty;
            cbMateriaisPesquisa.SelectedIndex = 0;
            this.CarregarGrid();

        }

        private void cbMateriais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisaMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                using(Entities ef = new Entities()){
                    int aux = Convert.ToInt32(cbMateriaisPesquisa.SelectedValue);
                    
                    var listaPacotesFiltrados = (
                         from pac in ef.pacotes
                         join mat in ef.materiais
                         on pac.MAid equals mat.MAid
                         select new
                         {
                             pac.PAid,
                             pac.PAtipo,
                             pac.PAquantidade,
                             pac.PAlargura,
                             pac.PAaltura,
                             pac.PAprofundidade,
                             pac.PApeso,
                             mat.nome,
                             pac.MAid
                         }
                     ).Where(pac => pac.MAid == aux).ToList();
                   
                    
                    if (listaPacotesFiltrados.Count == 0)
                    {
                        
                        MessageBox.Show("Não houve resultados da pesquisa com esse material", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.CarregarGrid();
                    }
                    else
                    {
                        dgvCadastroEmbalagem.AutoGenerateColumns = false;
                        dgvCadastroEmbalagem.DataSource = listaPacotesFiltrados;
                    }
                }
            }catch(Exception ex){
                MessageBox.Show("Não foi possível pesquisar", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblTipoPacote_Click(object sender, EventArgs e)
        {

        }
    }
}
