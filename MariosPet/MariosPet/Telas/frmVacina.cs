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
    public partial class frmVacina : Form
    {
        public frmVacina()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btmVoltar_Click(object sender, EventArgs e)
        {
            Telas.FrmFichaClinica fichaclinica = new FrmFichaClinica();
            fichaclinica.Show();
            Close();
        }

        private void btmLimpar_Click(object sender, EventArgs e)
        {
            txtPesquisaVacina.Clear();
            dtgVacina.ClearSelection();
            txtVermifugo.Clear();
            dtgVermifugo.ClearSelection();

        }
    }
}
