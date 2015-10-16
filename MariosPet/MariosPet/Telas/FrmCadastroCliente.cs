using MariosPet.Classes;
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
        Cliente classeCli = new Cliente();
        Endereco classeEnd = new Endereco();

        public FrmCadastroCliente()
        {
            InitializeComponent();
        }

        private void copiarValores()
        {
            classeCli.nome = txtNomeCliente.Text;
            classeCli.cpf = mstCPF.Text;
            classeCli.rg = mstRG.Text;
            classeCli.nascimento = Convert.ToDateTime(mskNascimentoCliente.Text);
            classeCli.email = txtEmailCliente.Text;
            classeCli.telefone1 = Convert.ToInt32(txtTelefoneCliente.Text.ToString());
            classeCli.telefone2 = Convert.ToInt32(txtTelefone2Cliente.Text.ToString());
            classeCli.telefone3 = Convert.ToInt32(txtTelefone3Cliente.Text.ToString());

            classeEnd.rua = txtRuaCliente.Text;
            classeEnd.numero = Convert.ToInt32(txtNumeroCliente.Text.ToString());
            classeEnd.complemento = txtComplementoCliente.Text;
            classeEnd.bairro = txtBairroCliente.Text;
            classeEnd.cidade = txtCidadeCliente.Text;
            classeEnd.uf = cmbUFCliente.Text;
            classeEnd.cep = Convert.ToInt32(mskCepCliente.Text.ToString());
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

        private void btmSalvar_Click(object sender, EventArgs e)
        {
            copiarValores();
            classeCli.cadastrarCliente(classeCli, classeEnd);
        }

        private void lblTelefone_Click(object sender, EventArgs e)
        {

        }
       
    }
}
