﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MariosPet.Telas
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.FrmCadastroCliente cadcli = new FrmCadastroCliente();
            cadcli.Show();
        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAnimal animal = new FrmAnimal();
            animal.Show();
        }

        private void cadastroToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmFornecedor fornecedor = new FrmFornecedor();
            fornecedor.Show();
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.FrmServico servico = new FrmServico();
            servico.ShowDialog();
            
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.FrmProduto produto = new FrmProduto();
            produto.ShowDialog();
        }

        private void laboratóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.FrmLaboratorio laboratorio = new FrmLaboratorio();
            laboratorio.ShowDialog();
        }

        private void fichaClínicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.FrmFichaClinica fichaClinica = new FrmFichaClinica();
            fichaClinica.ShowDialog();
        }
    }
}
