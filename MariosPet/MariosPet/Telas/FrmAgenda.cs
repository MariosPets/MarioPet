using MariosPet.Classes;
using System;
using System.Windows.Forms;

namespace MariosPet.Telas
{
    public partial class FrmAgenda : Form
    {
        ConexaoPadrao conexao;
        Crud.CrudAgendamento crud;
        Funcionario funcionario;
        Cliente cliente;

        public FrmAgenda()
        {
            InitializeComponent();
        }

        private void buttonFuncionario_Click(object sender, EventArgs e)
        {
            BuscaFuncionario busca = new BuscaFuncionario();
            busca.ShowDialog();
        }

        private void textBoxFuncionario_TextChanged(object sender, EventArgs e)
        {
            if (textBoxFuncionario.Text != null)
            {
                groupBoxAgendamento.Enabled = true;
            }
            else
            {
                groupBoxAgendamento.Enabled = false;
            }
        }
    }
}
