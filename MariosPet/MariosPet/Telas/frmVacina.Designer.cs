namespace MariosPet.Telas
{
    partial class frmVacina
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControlVacinaVermifugo = new System.Windows.Forms.TabControl();
            this.tabPageVacina = new System.Windows.Forms.TabPage();
            this.tabPageVermifugo = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskData = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dtgVacina = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtPesquisaVacina = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btmVoltar = new System.Windows.Forms.Button();
            this.btmSalvar = new System.Windows.Forms.Button();
            this.mskDataFinal = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btmNovo = new System.Windows.Forms.Button();
            this.dtgVermifugo = new System.Windows.Forms.DataGridView();
            this.btmConsultar = new System.Windows.Forms.Button();
            this.txtVermifugo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btmLimpar = new System.Windows.Forms.Button();
            this.tabControlVacinaVermifugo.SuspendLayout();
            this.tabPageVacina.SuspendLayout();
            this.tabPageVermifugo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVacina)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVermifugo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlVacinaVermifugo
            // 
            this.tabControlVacinaVermifugo.Controls.Add(this.tabPageVacina);
            this.tabControlVacinaVermifugo.Controls.Add(this.tabPageVermifugo);
            this.tabControlVacinaVermifugo.Location = new System.Drawing.Point(26, 12);
            this.tabControlVacinaVermifugo.Name = "tabControlVacinaVermifugo";
            this.tabControlVacinaVermifugo.SelectedIndex = 0;
            this.tabControlVacinaVermifugo.Size = new System.Drawing.Size(892, 469);
            this.tabControlVacinaVermifugo.TabIndex = 5;
            // 
            // tabPageVacina
            // 
            this.tabPageVacina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.tabPageVacina.Controls.Add(this.groupBox1);
            this.tabPageVacina.Location = new System.Drawing.Point(4, 22);
            this.tabPageVacina.Name = "tabPageVacina";
            this.tabPageVacina.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVacina.Size = new System.Drawing.Size(884, 443);
            this.tabPageVacina.TabIndex = 0;
            this.tabPageVacina.Text = "Vacina";
            // 
            // tabPageVermifugo
            // 
            this.tabPageVermifugo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.tabPageVermifugo.Controls.Add(this.groupBox2);
            this.tabPageVermifugo.Location = new System.Drawing.Point(4, 22);
            this.tabPageVermifugo.Name = "tabPageVermifugo";
            this.tabPageVermifugo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVermifugo.Size = new System.Drawing.Size(884, 443);
            this.tabPageVermifugo.TabIndex = 1;
            this.tabPageVermifugo.Text = "Vermífugo";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackgroundImage = global::MariosPet.Properties.Resources.pataAmareloMarromGrande;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.btnNovo);
            this.groupBox1.Controls.Add(this.btnVoltar);
            this.groupBox1.Controls.Add(this.mskData);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.dtgVacina);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.txtPesquisaVacina);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.groupBox1.Location = new System.Drawing.Point(84, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 309);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "   Vacina";
            // 
            // mskData
            // 
            this.mskData.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.mskData.Location = new System.Drawing.Point(75, 209);
            this.mskData.Mask = "00/00/0000";
            this.mskData.Name = "mskData";
            this.mskData.Size = new System.Drawing.Size(112, 27);
            this.mskData.TabIndex = 4;
            this.mskData.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Data:";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::MariosPet.Properties.Resources.botaoNovoLaranja;
            this.button2.Location = new System.Drawing.Point(567, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 38);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dtgVacina
            // 
            this.dtgVacina.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(235)))), ((int)(((byte)(156)))));
            this.dtgVacina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVacina.Location = new System.Drawing.Point(10, 91);
            this.dtgVacina.Name = "dtgVacina";
            this.dtgVacina.Size = new System.Drawing.Size(674, 97);
            this.dtgVacina.TabIndex = 2;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.btnConsultar.BackgroundImage = global::MariosPet.Properties.Resources.botaoConsultarVerde;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(567, 42);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(117, 40);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.UseVisualStyleBackColor = false;
            // 
            // txtPesquisaVacina
            // 
            this.txtPesquisaVacina.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaVacina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.txtPesquisaVacina.Location = new System.Drawing.Point(159, 50);
            this.txtPesquisaVacina.Name = "txtPesquisaVacina";
            this.txtPesquisaVacina.Size = new System.Drawing.Size(390, 27);
            this.txtPesquisaVacina.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(6, 50);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(143, 23);
            this.lblNome.TabIndex = 16;
            this.lblNome.Text = "Nome Vacina:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.BackgroundImage = global::MariosPet.Properties.Resources.pataVerdeAmareloGrande;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.btmLimpar);
            this.groupBox2.Controls.Add(this.btmVoltar);
            this.groupBox2.Controls.Add(this.btmSalvar);
            this.groupBox2.Controls.Add(this.mskDataFinal);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.maskedTextBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btmNovo);
            this.groupBox2.Controls.Add(this.dtgVermifugo);
            this.groupBox2.Controls.Add(this.btmConsultar);
            this.groupBox2.Controls.Add(this.txtVermifugo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.groupBox2.Location = new System.Drawing.Point(46, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(717, 351);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "   Vermífugo";
            // 
            // btmVoltar
            // 
            this.btmVoltar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btmVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.btmVoltar.BackgroundImage = global::MariosPet.Properties.Resources.botaoVoltarVerde;
            this.btmVoltar.FlatAppearance.BorderSize = 0;
            this.btmVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmVoltar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmVoltar.Location = new System.Drawing.Point(348, 302);
            this.btmVoltar.Name = "btmVoltar";
            this.btmVoltar.Size = new System.Drawing.Size(116, 49);
            this.btmVoltar.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btmVoltar, "Botão que Volta para o Menu");
            this.btmVoltar.UseVisualStyleBackColor = false;
            // 
            // btmSalvar
            // 
            this.btmSalvar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btmSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.btmSalvar.BackgroundImage = global::MariosPet.Properties.Resources.botaoSalvarVerde;
            this.btmSalvar.FlatAppearance.BorderSize = 0;
            this.btmSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmSalvar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmSalvar.Location = new System.Drawing.Point(593, 302);
            this.btmSalvar.Name = "btmSalvar";
            this.btmSalvar.Size = new System.Drawing.Size(118, 43);
            this.btmSalvar.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btmSalvar, "Botão Salvar");
            this.btmSalvar.UseVisualStyleBackColor = false;
            // 
            // mskDataFinal
            // 
            this.mskDataFinal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDataFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.mskDataFinal.Location = new System.Drawing.Point(132, 259);
            this.mskDataFinal.Mask = "00/00/0000";
            this.mskDataFinal.Name = "mskDataFinal";
            this.mskDataFinal.Size = new System.Drawing.Size(112, 27);
            this.mskDataFinal.TabIndex = 5;
            this.toolTip1.SetToolTip(this.mskDataFinal, "Data Final do Tratamento");
            this.mskDataFinal.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "Data Final:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.maskedTextBox1.Location = new System.Drawing.Point(132, 215);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(112, 27);
            this.maskedTextBox1.TabIndex = 4;
            this.toolTip1.SetToolTip(this.maskedTextBox1, "Data de Início do Tratamento");
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Data Início:";
            // 
            // btmNovo
            // 
            this.btmNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.btmNovo.BackgroundImage = global::MariosPet.Properties.Resources.botaoNovoLaranja;
            this.btmNovo.FlatAppearance.BorderSize = 0;
            this.btmNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmNovo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmNovo.Location = new System.Drawing.Point(566, 194);
            this.btmNovo.Name = "btmNovo";
            this.btmNovo.Size = new System.Drawing.Size(115, 43);
            this.btmNovo.TabIndex = 3;
            this.btmNovo.UseVisualStyleBackColor = false;
            // 
            // dtgVermifugo
            // 
            this.dtgVermifugo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(235)))), ((int)(((byte)(156)))));
            this.dtgVermifugo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVermifugo.Location = new System.Drawing.Point(6, 91);
            this.dtgVermifugo.Name = "dtgVermifugo";
            this.dtgVermifugo.Size = new System.Drawing.Size(674, 97);
            this.dtgVermifugo.TabIndex = 2;
            // 
            // btmConsultar
            // 
            this.btmConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.btmConsultar.FlatAppearance.BorderSize = 0;
            this.btmConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmConsultar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmConsultar.Image = global::MariosPet.Properties.Resources.botaoConsultarVerde;
            this.btmConsultar.Location = new System.Drawing.Point(566, 46);
            this.btmConsultar.Name = "btmConsultar";
            this.btmConsultar.Size = new System.Drawing.Size(114, 32);
            this.btmConsultar.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btmConsultar, "Botão Consultar Vermífugo");
            this.btmConsultar.UseVisualStyleBackColor = false;
            // 
            // txtVermifugo
            // 
            this.txtVermifugo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVermifugo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.txtVermifugo.Location = new System.Drawing.Point(191, 51);
            this.txtVermifugo.Name = "txtVermifugo";
            this.txtVermifugo.Size = new System.Drawing.Size(369, 27);
            this.txtVermifugo.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtVermifugo, "Insira Nome Vermífugo");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nome Vermífugo:";
            // 
            // btnNovo
            // 
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = global::MariosPet.Properties.Resources.botaoLimparLaranja;
            this.btnNovo.Location = new System.Drawing.Point(450, 262);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(108, 31);
            this.btnNovo.TabIndex = 19;
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Image = global::MariosPet.Properties.Resources.botaoVoltarVerde;
            this.btnVoltar.Location = new System.Drawing.Point(296, 262);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(126, 31);
            this.btnVoltar.TabIndex = 20;
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = global::MariosPet.Properties.Resources.botaoSalvarVerde;
            this.btnSalvar.Location = new System.Drawing.Point(564, 262);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(117, 31);
            this.btnSalvar.TabIndex = 21;
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btmLimpar
            // 
            this.btmLimpar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btmLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.btmLimpar.BackgroundImage = global::MariosPet.Properties.Resources.botaoLimparLaranja;
            this.btmLimpar.FlatAppearance.BorderSize = 0;
            this.btmLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmLimpar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmLimpar.Location = new System.Drawing.Point(470, 302);
            this.btmLimpar.Name = "btmLimpar";
            this.btmLimpar.Size = new System.Drawing.Size(110, 40);
            this.btmLimpar.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btmLimpar, "Botão que Limpa os Campos");
            this.btmLimpar.UseVisualStyleBackColor = false;
            // 
            // frmVacina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1034, 733);
            this.Controls.Add(this.tabControlVacinaVermifugo);
            this.Name = "frmVacina";
            this.Text = "Vacina & Vermífugo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControlVacinaVermifugo.ResumeLayout(false);
            this.tabPageVacina.ResumeLayout(false);
            this.tabPageVermifugo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVacina)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVermifugo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabControl tabControlVacinaVermifugo;
        private System.Windows.Forms.TabPage tabPageVacina;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mskData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dtgVacina;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtPesquisaVacina;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TabPage tabPageVermifugo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btmVoltar;
        private System.Windows.Forms.Button btmSalvar;
        private System.Windows.Forms.MaskedTextBox mskDataFinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btmNovo;
        private System.Windows.Forms.DataGridView dtgVermifugo;
        private System.Windows.Forms.Button btmConsultar;
        private System.Windows.Forms.TextBox txtVermifugo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btmLimpar;

    }
}