﻿using System;
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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.FrmCadastroCliente cadcli = new FrmCadastroCliente();
            cadcli.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
