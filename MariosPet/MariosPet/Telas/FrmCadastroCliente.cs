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
    public partial class FrmCadastroCliente : Form
    {
        public FrmCadastroCliente()
        {
            InitializeComponent();
        }

        private void lblTelefone_Click(object sender, EventArgs e)
        {

        }

        private void btmLimpar_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Clear();
            txtBairroCliente.Clear();
            txtCidadeCliente.Clear();
            txtComplementoCliente.Clear();
            txtEmailCliente.Clear();
            txtNumeroCliente.Clear();
            txtRuaCliente.Clear();
            txtTelefone2Cliente.Clear();
            txtTelefone3Cliente.Clear();
            txtTelefoneCliente.Clear();
            mskCepCliente.Clear();
            mskNascimentoCliente.Clear();
            mstCPF.Clear();
            mstRG.Clear();
        }

        private void btmVoltar_Click(object sender, EventArgs e)
        {
            Telas.FrmMenu frmmenu = new FrmMenu();
            frmmenu.Show();
            Close();
        }

       
    }
}
