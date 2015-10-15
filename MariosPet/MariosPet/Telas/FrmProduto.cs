using System;
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
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void lblRG_Click(object sender, EventArgs e)
        {

        }

        private void mstCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btmLimpar_Click(object sender, EventArgs e)
        {
            txtMargemLucro.Clear();
            txtMaxEstoque.Clear();
            txtMinEstoque.Clear();
            txtNomeProduto.Clear();
            txtQuantidade.Clear();
            txtTributacao.Clear();
            txtUnidade.Clear();
            txtCodBarras.Clear();
            txtFabricante.Clear();
            txtValorCusto.Clear();
            txtValorVenda.Clear();
            mstVencimento.Clear();
        }

        private void btmVoltar_Click(object sender, EventArgs e)
        {
            Telas.FrmMenu frmmenu = new FrmMenu();
            frmmenu.Show();
            Close();
        }
    }
}
