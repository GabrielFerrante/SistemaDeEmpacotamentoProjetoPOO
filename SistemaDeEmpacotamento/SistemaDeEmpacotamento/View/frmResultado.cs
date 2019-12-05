using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CromulentBisgetti.ContainerPacking;
using CromulentBisgetti.ContainerPacking.Algorithms;
using CromulentBisgetti.ContainerPacking.Entities;
using BinContainer = CromulentBisgetti.ContainerPacking.Entities.Container;

namespace SistemaDeEmpacotamento
{
    public partial class frmResultado : Form
    {
        public frmResultado(List<produto> produtos)
        {
            InitializeComponent();
            dgvResultado.DataSource = null;
            

            this.calcular(produtos);
        }

        public void calcular(List<produto> produtos)
        {
            using (Entities ef = new Entities())
            {
                List<pacote> pacotes = ef.pacotes.ToList();
                List<BinContainer> containers = new List<BinContainer>();
                List<Item> items = new List<Item>();

                List<int> algorithms = new List<int>();
                algorithms.Add((int)AlgorithmType.EB_AFIT);

                foreach (pacote item in pacotes)
                {
                    containers.Add(new BinContainer(item.PAid, item.PAprofundidade, item.PAlargura, item.PAaltura));
                }

                foreach (produto produto in produtos)
                {
                    items.Add(new Item(produto.PRid, produto.PRprofundidade, produto.PRlargura, produto.PRaltura, Convert.ToInt32(produto.PRquantidade)));
                }

                List<ContainerPackingResult> result = PackingService.Pack(containers, items, algorithms);

                List<ItemTabelaResultado> resultado = new List<ItemTabelaResultado>();

                foreach (ContainerPackingResult container in result)
                {
                    pacote pct = ef.pacotes.Find(container.ContainerID);
                    ItemTabelaResultado tblItem = new ItemTabelaResultado(pct.PAtipo);

                    foreach (AlgorithmPackingResult algResult in container.AlgorithmPackingResults)
                    {
                        foreach (Item altItem in algResult.PackedItems)
                        {
                            if (altItem.IsPacked)
                            {
                                produto p = ef.produtos.Find(altItem.ID);
                                tblItem.produtos = tblItem.produtos + p.PRnome + Environment.NewLine;
                                
                            }
                        }
                    }

                    resultado.Add(tblItem);
                }

                dgvResultado.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvResultado.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvResultado.DataSource = resultado;
                
            }
        }

        private void FrmResultado_Load(object sender, EventArgs e)
        {

        }
    }
}
