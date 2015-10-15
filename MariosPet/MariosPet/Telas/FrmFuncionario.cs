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
    public partial class FrmFuncionario : Form
    {
        public FrmFuncionario()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBairroFuncionario.Clear();
            txtCidadeFuncionario.Clear();
            txtComplementoFuncionario.Clear();
            txtConfirmacaoSenha.Clear();
            txtEmailFuncionario.Clear();
            txtLogin.Clear();
            txtNomeFuncionario.Clear();
            txtNumeroFuncionario.Clear();
            txtRuaFuncionario.Clear();
            txtSenha.Clear();
            txtTelefone2Funcionario.Clear();
            txtTelefone3Funcionario.Clear();
            txtTelefoneFuncionario.Clear();
            mstCepFuncionario.Clear();
            mstCPFFuncionario.Clear();
            mstNascimentoFuncionario.Clear();
            mstRGFuncionario.Clear();
            
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Telas.FrmMenu frmmenu = new FrmMenu();
            frmmenu.Show();
            Close();
        }
    }
}
