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
    public partial class FrmFichaClinica : Form
    {
        public FrmFichaClinica()
        {
            InitializeComponent();
        }

        private void txtHistoricoClinico_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtExames.Clear();
            txtHistoricoClinico.Clear();
            txtObservacao.Clear();
            txtPesquisaAnimal.Clear();
            txtPrescricao.Clear();
            txtQueixa.Clear();
            txtSintomas.Clear();
            txtSuspeita.Clear();
            dtgAnimal.ClearSelection();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Telas.FrmMenu menu = new FrmMenu();
            menu.Show();
            Close();
        }
    }
}
