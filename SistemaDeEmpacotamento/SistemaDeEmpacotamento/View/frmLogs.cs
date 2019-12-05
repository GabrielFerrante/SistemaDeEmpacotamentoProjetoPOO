using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeEmpacotamento.View
{
    public partial class frmLogsSistema : Form
    {
        public frmLogsSistema()
        {
            InitializeComponent();
            CarregarGrid();
        }
        private void CarregarGrid()
        {
            try
            {
                using(Entities ef = new Entities()){
                    object listaLogs = (
                        from lo in ef.logs
                        join us in ef.usuarios
                        on lo.USid equals us.USid
                        select new {
                            lo.LOid,
                            lo.LOoperacao,
                            lo.LOdata,
                            us.USnome
                        }
                    ).ToList();
                    dgvLogsSistema.AutoGenerateColumns = false;
                    dgvLogsSistema.DataSource = listaLogs;
                }
            }catch(Exception ex){
                MessageBox.Show("Impossível carregar dados " + ex, "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            CarregarGrid();
            dtDataPesquisa.Text = DateTime.Now.ToString();
        }

        private void btnPesquisarData_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime aux;
                DateTime.TryParse(dtDataPesquisa.Text, out aux);
                
                using (Entities ef = new Entities())
                {
                    var listaLogs = (
                        from lo in ef.logs
                        join us in ef.usuarios
                        on lo.USid equals us.USid
                        select new
                        {
                            lo.LOid,
                            lo.LOoperacao,
                            lo.LOdata,
                            us.USnome
                        }
                    ).Where(lo => EntityFunctions.TruncateTime(lo.LOdata) == EntityFunctions.TruncateTime(aux)).ToList();
                    //.Where(lo => lo.LOdata.Day == aux.Day && lo.LOdata.Month == aux.Month && lo.LOdata.Year == aux.Year).ToList();
                                        
                    dgvLogsSistema.AutoGenerateColumns = false;
                    dgvLogsSistema.DataSource = listaLogs;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO FAZER A OPERAÇÃO " + ex, "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
