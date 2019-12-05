using SistemaDeEmpacotamento.View;
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
    public partial class frmTelaPrincipal : Form
    {
        public usuario user;

        public frmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void frmTelaPrincipal_Load(object sender, EventArgs e)
        {
            frmLogin tl = new frmLogin(this);
            this.Hide();
            tl.ShowDialog();


            if (user != null)
            {
                this.Show();
                lbUsuario.Text = user.USnome.ToUpper();
                if (user.Cargo!= "Administrador")
                {
                    btnCadastroUsuario.Visible = false;
                    msCadastroLogin.Visible= false;
                    mmLogs.Visible = false;
                }
            }
            else
            {
                this.Close();
            }
        }

        private void MsInicioEmbalagem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void MsCadastroEmbalagem_Click(object sender, EventArgs e)
        {
            frmCadastroEmbalagem tl = new frmCadastroEmbalagem(user);
            tl.ShowDialog();
        }

        private void BtnCadastrarEmbalagem_Click(object sender, EventArgs e)
        {
            frmCadastroEmbalagem tl = new frmCadastroEmbalagem(user);
            tl.ShowDialog();
        }

        private void BtnCadastrarProduto_Click(object sender, EventArgs e)
        {
            frmCadastroProduto tl = new frmCadastroProduto(user);
            tl.ShowDialog();
        }

        private void MsSair_Click(object sender, EventArgs e)
        {
           


        }

        private void MsCadastroProduto_Click(object sender, EventArgs e)
        {
            frmCadastroProduto tl = new frmCadastroProduto(user);
            tl.ShowDialog();
        }

        private void MsCalculo_Click(object sender, EventArgs e)
        {
            frmCalculo tl = new frmCalculo(user);
            tl.ShowDialog();
        }

        private void BtnCadastroUsuario_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario tl = new frmCadastroUsuario(user);
            tl.ShowDialog();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void BtnDeslogar_Click(object sender, EventArgs e)
        {
            user = null;
            frmLogin tl = new frmLogin(this);
            this.Hide();
            tl.ShowDialog();
            if (user != null)
            {
                this.Show();
                lbUsuario.Text = user.USnome.ToUpper();
                if (user.Cargo != "Administrador")
                {
                    btnCadastroUsuario.Visible = false;
                    msCadastroLogin.Visible = false;
                    mmLogs.Visible = false;
                }
                else
                {
                    btnCadastroUsuario.Visible = true;
                    msCadastroLogin.Visible = true;
                    mmLogs.Visible = true;
                }
            }
            else
            {
                this.Close();
            }
        }

        private void MsCadastroLogin_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario tl = new frmCadastroUsuario(user);
            tl.ShowDialog();
        }

        private void CalcularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalculo tl = new frmCalculo(user);
            tl.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmCalculo tl = new frmCalculo(user);
            tl.ShowDialog();
        }

        private void mmLogs_Click(object sender, EventArgs e)
        {
            frmLogsSistema tl = new frmLogsSistema();
            tl.ShowDialog();

        }
    }
}
