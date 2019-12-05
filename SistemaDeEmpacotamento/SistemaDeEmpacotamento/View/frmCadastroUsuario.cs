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
    public partial class frmCadastroUsuario : Form
    {
        int modo = 1;
        int idUsuario;
        usuario usuarioLogado;
        public frmCadastroUsuario(usuario user)
        {
            InitializeComponent();
            this.usuarioLogado = user;
            cbCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCargo.SelectedIndex = 0;
            CarregarGrid();
        }
        private int verificaDados()
        {
            using(Entities ef = new Entities()){
                List<usuario> listaUsuarios = ef.usuarios.ToList();
                foreach(usuario item in listaUsuarios){
                    if(item.USlogin.Equals(txtLogin.Text)&&this.modo==1){
                        MessageBox.Show("Login já existente","AVISO!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        return 1;
                    }
                }
            }
            if(txtNome.Text.Equals("")
                ||
                txtLogin.Text.Equals("")
                ||
                txtSenha.Text.Equals("")
              
                ){
                return 1;
            }
            return 2;
        }
        private void CarregarCamposAlterar()
        {
            using(Entities ef = new Entities()){
                usuario u = ef.usuarios.Find(this.idUsuario);
                txtNome.Text = u.USnome;
                txtLogin.Text = u.USlogin;
                txtSenha.Text = u.USsenha;
                cbCargo.Text = u.Cargo;
            }
        }
        private void CarregarGrid()
        {
            try
            {
                using(Entities ef = new Entities()){
                    List<usuario> users = ef.usuarios.ToList();
                    dgvCadastroUsuarios.AutoGenerateColumns = false;
                    dgvCadastroUsuarios.DataSource = users;
                    
                }
            }catch(Exception ex){
                 MessageBox.Show("Impossível carregar dados" + " " + ex, "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void limparDados()
        {
            txtSenha.Text = "";
            txtNome.Text = "";
            txtLogin.Text = "";
            cbCargo.SelectedIndex = 0;
        }
        private void pnlCadastroUsuario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try {
                if (verificaDados().Equals(2))
                {
                    using(Entities ef = new Entities()){
                        if (this.modo.Equals(1))
                        {
                            ef.salvarUsuario(
                                txtNome.Text,
                                txtLogin.Text,
                                txtSenha.Text,
                                cbCargo.Text,
                                usuarioLogado.USid
                                );
                            MessageBox.Show("Usuário cadastrado com sucesso", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            ef.alterarUsuario(
                                this.idUsuario,
                                txtNome.Text,
                                txtLogin.Text,
                                txtSenha.Text,
                                cbCargo.Text,
                                usuarioLogado.USid
                                );
                            MessageBox.Show("Usuário alterado com sucesso", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.modo = 1;
                        }
                        ef.SaveChanges();
                    }
                    
                    this.CarregarGrid();
                    this.limparDados();
                }
                else
                { 
                    MessageBox.Show("Preencha todos os dados para salvar!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }catch(Exception ex){
                MessageBox.Show("ERRO AO FAZER A OPERAÇÃO " + ex, "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvCadastroUsuarios.RowCount > 0)
            {
                if(!dgvCadastroUsuarios.CurrentRow.Cells[0].Value.ToString().Equals("")){
                    this.idUsuario = Convert.ToInt32(dgvCadastroUsuarios.CurrentRow.Cells[0].Value.ToString());
                }
                this.CarregarCamposAlterar();
                this.modo = 2;
            }
            else
            {
                MessageBox.Show("Não existe usuários cadastrados", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparDados();
            this.modo = 1;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCadastroUsuarios.RowCount > 0)
                {
                    if (MessageBox.Show(
                        "Deseja excluir o usuário ?\nCÓDIGO DO USUÁRIO:" + dgvCadastroUsuarios.CurrentRow.Cells[0].Value.ToString(), 
                        "AVISO!", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (!dgvCadastroUsuarios.CurrentRow.Cells[0].Value.ToString().Equals("") 
                            && dgvCadastroUsuarios.CurrentRow.Cells[0].Value.ToString() != usuarioLogado.USid.ToString())
                        {
                            this.idUsuario = Convert.ToInt32(dgvCadastroUsuarios.CurrentRow.Cells[0].Value.ToString());
                            using(Entities ef = new Entities()){
                                usuario u = ef.usuarios.Find(this.idUsuario);
                                log l = new log();
                                l.LOoperacao = "Exclusão de usuário: "+ u.USnome;
                                l.LOdata = DateTime.Now;
                                l.USid = usuarioLogado.USid;

                                ef.logs.Add(l);
                                ef.usuarios.Remove(u);
                                ef.SaveChanges();
                            }
                            MessageBox.Show("Usuário excluído com sucesso", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Não é possível excluir você mesmo!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        this.CarregarGrid();
                    }
                   
                }
                else
                {
                    MessageBox.Show("Não há usuários cadastrados", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }catch(Exception ex){
                MessageBox.Show("Não foi possível excluir", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
