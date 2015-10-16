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
    public partial class FrmAnamnese : Form
    {
        public FrmAnamnese()
        {
            InitializeComponent();
        }

        private void btmLimpar_Click(object sender, EventArgs e)
        {
            txtPesquisaAnimal.Clear();
            dtgAnimal.ClearSelection();
            richTextBoxDoenca.Clear();
            richTextBoxCardioRespiratorio.Clear();
            richTextBoxDigestorio.Clear();
            richTextBoxGenitoUrinario.Clear();
            richTextBoxManejo.Clear();
            richTextBoxNervosoLocomotor.Clear();
            richTextBoxPelesAnexos.Clear();
            richTextBoxTratamento.Clear();
        }

        private void btmVoltar_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();
            Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmAnimal animal = new FrmAnimal();
            animal.Show();
            Close();
        }
    }
}
