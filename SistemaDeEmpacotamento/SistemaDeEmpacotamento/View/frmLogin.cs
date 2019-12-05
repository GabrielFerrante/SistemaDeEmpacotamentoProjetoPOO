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
    public partial class frmLogin : Form
    {
        
        frmTelaPrincipal frmPrincipal;
        
        public frmLogin(frmTelaPrincipal _frmPrincipal)
        {
            this.frmPrincipal = _frmPrincipal;
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                using (Entities ef = new Entities())
                {
                    List<usuario> user = ef.usuarios.Where(u => u.USlogin.Equals(txtLogin.Text) && u.USsenha.Equals(txtSenha.Text)).ToList();
                    frmPrincipal.user = user.First();
                    MessageBox.Show("Bem-vindo ao sistema", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }catch(Exception ex){
                 MessageBox.Show("Senha não confere", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {   
            Application.Exit();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmPrincipal.user == null)
                Application.Exit();
            
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
