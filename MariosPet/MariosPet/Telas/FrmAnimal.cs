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
    public partial class FrmAnimal : Form
    {
        public FrmAnimal()
        {
            InitializeComponent();
        }

        private void btmVoltar_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.ShowDialog();
            Close();
        }

        private void btmLimpar_Click(object sender, EventArgs e)
        {
            txtNomeAnimal.Clear();
            txtPelagemCor.Clear();
            txtRacaPorte.Clear();
            txtSexo.Clear();
            maskedTxtNascimentoAnimal.Clear();
        }
    }
}
