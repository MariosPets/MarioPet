namespace MariosPet.Telas
{
    partial class BuscaFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelPesquisa = new System.Windows.Forms.Label();
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.comboBoxPesquisa = new System.Windows.Forms.ComboBox();
            this.buttonPesquisa = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonSelecionar = new System.Windows.Forms.Button();
            this.buttonCancela = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTipPesquisaFuncionario = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPesquisa
            // 
            this.labelPesquisa.AutoSize = true;
            this.labelPesquisa.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPesquisa.Location = new System.Drawing.Point(264, 70);
            this.labelPesquisa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPesquisa.Name = "labelPesquisa";
            this.labelPesquisa.Size = new System.Drawing.Size(90, 13);
            this.labelPesquisa.TabIndex = 1;
            this.labelPesquisa.Text = "Pesquisar por:";
            // 
            // textBoxPesquisa
            // 
            this.textBoxPesquisa.Location = new System.Drawing.Point(28, 67);
            this.textBoxPesquisa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(226, 20);
            this.textBoxPesquisa.TabIndex = 0;
            this.toolTipPesquisaFuncionario.SetToolTip(this.textBoxPesquisa, "Digite o nome do funcionário que está procurando.");
            // 
            // comboBoxPesquisa
            // 
            this.comboBoxPesquisa.FormattingEnabled = true;
            this.comboBoxPesquisa.Items.AddRange(new object[] {
            "",
            "ID",
            "Nome",
            "CPF",
            "RG",
            "Tipo",
            "Apelido"});
            this.comboBoxPesquisa.Location = new System.Drawing.Point(358, 67);
            this.comboBoxPesquisa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxPesquisa.Name = "comboBoxPesquisa";
            this.comboBoxPesquisa.Size = new System.Drawing.Size(92, 21);
            this.comboBoxPesquisa.TabIndex = 1;
            // 
            // buttonPesquisa
            // 
            this.buttonPesquisa.FlatAppearance.BorderSize = 0;
            this.buttonPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesquisa.Image = global::MariosPet.Properties.Resources.botaoPesquisarLaranja;
            this.buttonPesquisa.Location = new System.Drawing.Point(446, 46);
            this.buttonPesquisa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPesquisa.Name = "buttonPesquisa";
            this.buttonPesquisa.Size = new System.Drawing.Size(129, 61);
            this.buttonPesquisa.TabIndex = 2;
            this.buttonPesquisa.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(235)))), ((int)(((byte)(156)))));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(28, 107);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(547, 199);
            this.dataGridView.TabIndex = 3;
            // 
            // buttonSelecionar
            // 
            this.buttonSelecionar.FlatAppearance.BorderSize = 0;
            this.buttonSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelecionar.Location = new System.Drawing.Point(512, 322);
            this.buttonSelecionar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSelecionar.Name = "buttonSelecionar";
            this.buttonSelecionar.Size = new System.Drawing.Size(63, 19);
            this.buttonSelecionar.TabIndex = 4;
            this.buttonSelecionar.Text = "Selecionar";
            this.buttonSelecionar.UseVisualStyleBackColor = true;
            this.buttonSelecionar.Click += new System.EventHandler(this.buttonSelecionar_Click);
            // 
            // buttonCancela
            // 
            this.buttonCancela.BackgroundImage = global::MariosPet.Properties.Resources.botaoCancelarLaranja;
            this.buttonCancela.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCancela.FlatAppearance.BorderSize = 0;
            this.buttonCancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancela.Location = new System.Drawing.Point(376, 310);
            this.buttonCancela.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancela.Name = "buttonCancela";
            this.buttonCancela.Size = new System.Drawing.Size(116, 45);
            this.buttonCancela.TabIndex = 5;
            this.buttonCancela.UseVisualStyleBackColor = true;
            this.buttonCancela.Click += new System.EventHandler(this.buttonCancela_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.label1.Image = global::MariosPet.Properties.Resources.pataVerdeAmareloGrande;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "     Pesquisar Funcionário";
            // 
            // BuscaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(597, 362);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancela);
            this.Controls.Add(this.buttonSelecionar);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonPesquisa);
            this.Controls.Add(this.comboBoxPesquisa);
            this.Controls.Add(this.textBoxPesquisa);
            this.Controls.Add(this.labelPesquisa);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BuscaFuncionario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionário";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPesquisa;
        private System.Windows.Forms.TextBox textBoxPesquisa;
        private System.Windows.Forms.ComboBox comboBoxPesquisa;
        private System.Windows.Forms.Button buttonPesquisa;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonSelecionar;
        private System.Windows.Forms.Button buttonCancela;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTipPesquisaFuncionario;
    }
}