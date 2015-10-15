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
    public partial class FrmLaboratorio : Form
    {
        public FrmLaboratorio()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBairro.Clear();
            txtCidade.Clear();
            txtComplemento.Clear();
            txtEmail1.Clear();
            txtEmail2.Clear();
            txtNomeLaboratorio.Clear();
            txtNumero.Clear();
            txtRua.Clear();
            txtTelefone1.Clear();
            txtTelefone2.Clear();
            mstCep.Clear();
            mstCNPJ.Clear();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Telas.FrmMenu frmmenu = new FrmMenu();
            frmmenu.Show();
            Close();
        }
    }
}
