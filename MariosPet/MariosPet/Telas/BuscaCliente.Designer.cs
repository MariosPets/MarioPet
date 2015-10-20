namespace MariosPet.Telas
{
    partial class BuscaCliente
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
            this.buttonCancela = new System.Windows.Forms.Button();
            this.buttonSelecionar = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonPesquisa = new System.Windows.Forms.Button();
            this.comboBoxPesquisa = new System.Windows.Forms.ComboBox();
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.labelPesquisa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancela
            // 
            this.buttonCancela.FlatAppearance.BorderSize = 0;
            this.buttonCancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancela.Image = global::MariosPet.Properties.Resources.botaoCancelarVerde;
            this.buttonCancela.Location = new System.Drawing.Point(328, 283);
            this.buttonCancela.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancela.Name = "buttonCancela";
            this.buttonCancela.Size = new System.Drawing.Size(117, 50);
            this.buttonCancela.TabIndex = 6;
            this.buttonCancela.UseVisualStyleBackColor = true;
            this.buttonCancela.Click += new System.EventHandler(this.buttonCancela_Click);
            // 
            // buttonSelecionar
            // 
            this.buttonSelecionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSelecionar.FlatAppearance.BorderSize = 0;
            this.buttonSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelecionar.Location = new System.Drawing.Point(449, 294);
            this.buttonSelecionar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSelecionar.Name = "buttonSelecionar";
            this.buttonSelecionar.Size = new System.Drawing.Size(92, 27);
            this.buttonSelecionar.TabIndex = 5;
            this.buttonSelecionar.Text = "Selecionar";
            this.buttonSelecionar.UseVisualStyleBackColor = true;
            this.buttonSelecionar.Click += new System.EventHandler(this.buttonSelecionar_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(235)))), ((int)(((byte)(156)))));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(18, 90);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(523, 189);
            this.dataGridView.TabIndex = 4;
            // 
            // buttonPesquisa
            // 
            this.buttonPesquisa.BackgroundImage = global::MariosPet.Properties.Resources.botaoPesquisarLaranja;
            this.buttonPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonPesquisa.FlatAppearance.BorderSize = 0;
            this.buttonPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesquisa.Location = new System.Drawing.Point(421, 38);
            this.buttonPesquisa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPesquisa.Name = "buttonPesquisa";
            this.buttonPesquisa.Size = new System.Drawing.Size(120, 46);
            this.buttonPesquisa.TabIndex = 3;
            this.buttonPesquisa.UseVisualStyleBackColor = true;
            // 
            // comboBoxPesquisa
            // 
            this.comboBoxPesquisa.FormattingEnabled = true;
            this.comboBoxPesquisa.Items.AddRange(new object[] {
            "",
            "",
            "ID",
            "Nome",
            "CPF",
            "RG"});
            this.comboBoxPesquisa.Location = new System.Drawing.Point(325, 48);
            this.comboBoxPesquisa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxPesquisa.Name = "comboBoxPesquisa";
            this.comboBoxPesquisa.Size = new System.Drawing.Size(92, 21);
            this.comboBoxPesquisa.TabIndex = 2;
            // 
            // textBoxPesquisa
            // 
            this.textBoxPesquisa.Location = new System.Drawing.Point(18, 49);
            this.textBoxPesquisa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(209, 20);
            this.textBoxPesquisa.TabIndex = 0;
            // 
            // labelPesquisa
            // 
            this.labelPesquisa.AutoSize = true;
            this.labelPesquisa.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPesquisa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.labelPesquisa.Location = new System.Drawing.Point(231, 51);
            this.labelPesquisa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPesquisa.Name = "labelPesquisa";
            this.labelPesquisa.Size = new System.Drawing.Size(90, 13);
            this.labelPesquisa.TabIndex = 1;
            this.labelPesquisa.Text = "Pesquisar por:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.label1.Image = global::MariosPet.Properties.Resources.pataVerdeAmareloGrande;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "     Pesquisar Cliente";
            // 
            // BuscaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(563, 355);
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
            this.Name = "BuscaCliente";
            this.Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancela;
        private System.Windows.Forms.Button buttonSelecionar;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonPesquisa;
        private System.Windows.Forms.ComboBox comboBoxPesquisa;
        private System.Windows.Forms.TextBox textBoxPesquisa;
        private System.Windows.Forms.Label labelPesquisa;
        private System.Windows.Forms.Label label1;
    }
}