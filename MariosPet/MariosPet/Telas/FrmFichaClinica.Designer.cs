namespace MariosPet.Telas
{
    partial class FrmFichaClinica
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btmNovo = new System.Windows.Forms.Button();
            this.dtgAnimal = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtPesquisaAnimal = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtExames = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSintomas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrescricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSuspeita = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQueixa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHistoricoClinico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnVermifugoVacina = new System.Windows.Forms.Button();
            this.toolTipFichaClinica = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAnimal)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.btmNovo);
            this.groupBox1.Controls.Add(this.dtgAnimal);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.txtPesquisaAnimal);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.groupBox1.Location = new System.Drawing.Point(182, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 252);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "   Pesquisa";
            // 
            // btmNovo
            // 
            this.btmNovo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmNovo.Location = new System.Drawing.Point(568, 196);
            this.btmNovo.Name = "btmNovo";
            this.btmNovo.Size = new System.Drawing.Size(116, 44);
            this.btmNovo.TabIndex = 3;
            this.btmNovo.Text = "Novo";
            this.toolTipFichaClinica.SetToolTip(this.btmNovo, "Cadastrar novo Animal");
            this.btmNovo.UseVisualStyleBackColor = true;
            this.btmNovo.Click += new System.EventHandler(this.btmNovo_Click);
            // 
            // dtgAnimal
            // 
            this.dtgAnimal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(235)))), ((int)(((byte)(156)))));
            this.dtgAnimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAnimal.Location = new System.Drawing.Point(10, 93);
            this.dtgAnimal.Name = "dtgAnimal";
            this.dtgAnimal.Size = new System.Drawing.Size(674, 97);
            this.dtgAnimal.TabIndex = 2;
            this.toolTipFichaClinica.SetToolTip(this.dtgAnimal, "Resultado da Consulta");
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(568, 41);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(116, 44);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.toolTipFichaClinica.SetToolTip(this.btnConsultar, "Consultar");
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisaAnimal
            // 
            this.txtPesquisaAnimal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaAnimal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.txtPesquisaAnimal.Location = new System.Drawing.Point(159, 50);
            this.txtPesquisaAnimal.Name = "txtPesquisaAnimal";
            this.txtPesquisaAnimal.Size = new System.Drawing.Size(301, 27);
            this.txtPesquisaAnimal.TabIndex = 0;
            this.toolTipFichaClinica.SetToolTip(this.txtPesquisaAnimal, "Insira o nome do Animal");
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(6, 50);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(147, 23);
            this.lblNome.TabIndex = 16;
            this.lblNome.Text = "Nome Animal:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.txtObservacao);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtExames);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtSintomas);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtPrescricao);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtSuspeita);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtQueixa);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtHistoricoClinico);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.groupBox2.Location = new System.Drawing.Point(182, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(717, 464);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "   Ficha Clínica";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(10, 422);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(674, 30);
            this.txtObservacao.TabIndex = 38;
            this.toolTipFichaClinica.SetToolTip(this.txtObservacao, "Insira a Prescrição");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 18);
            this.label7.TabIndex = 39;
            this.label7.Text = "Observações:";
            // 
            // txtExames
            // 
            this.txtExames.Location = new System.Drawing.Point(10, 368);
            this.txtExames.Multiline = true;
            this.txtExames.Name = "txtExames";
            this.txtExames.Size = new System.Drawing.Size(674, 30);
            this.txtExames.TabIndex = 36;
            this.toolTipFichaClinica.SetToolTip(this.txtExames, "Insira a Prescrição");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 18);
            this.label6.TabIndex = 37;
            this.label6.Text = "Exames Complementares:";
            // 
            // txtSintomas
            // 
            this.txtSintomas.Location = new System.Drawing.Point(9, 316);
            this.txtSintomas.Multiline = true;
            this.txtSintomas.Name = "txtSintomas";
            this.txtSintomas.Size = new System.Drawing.Size(674, 30);
            this.txtSintomas.TabIndex = 34;
            this.toolTipFichaClinica.SetToolTip(this.txtSintomas, "Insira a Prescrição");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 35;
            this.label5.Text = "Sintomas:";
            // 
            // txtPrescricao
            // 
            this.txtPrescricao.Location = new System.Drawing.Point(9, 262);
            this.txtPrescricao.Multiline = true;
            this.txtPrescricao.Name = "txtPrescricao";
            this.txtPrescricao.Size = new System.Drawing.Size(674, 30);
            this.txtPrescricao.TabIndex = 3;
            this.toolTipFichaClinica.SetToolTip(this.txtPrescricao, "Insira a Prescrição");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "Prescrição:";
            // 
            // txtSuspeita
            // 
            this.txtSuspeita.Location = new System.Drawing.Point(9, 193);
            this.txtSuspeita.Multiline = true;
            this.txtSuspeita.Name = "txtSuspeita";
            this.txtSuspeita.Size = new System.Drawing.Size(674, 41);
            this.txtSuspeita.TabIndex = 2;
            this.toolTipFichaClinica.SetToolTip(this.txtSuspeita, "Descreva os Sintomas Acometidos");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 31;
            this.label3.Text = "Suspeita:";
            // 
            // txtQueixa
            // 
            this.txtQueixa.Location = new System.Drawing.Point(10, 126);
            this.txtQueixa.Multiline = true;
            this.txtQueixa.Name = "txtQueixa";
            this.txtQueixa.Size = new System.Drawing.Size(674, 38);
            this.txtQueixa.TabIndex = 1;
            this.toolTipFichaClinica.SetToolTip(this.txtQueixa, "Descreva os Sintomas");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Principal Queixa:";
            // 
            // txtHistoricoClinico
            // 
            this.txtHistoricoClinico.Location = new System.Drawing.Point(9, 57);
            this.txtHistoricoClinico.Multiline = true;
            this.txtHistoricoClinico.Name = "txtHistoricoClinico";
            this.txtHistoricoClinico.Size = new System.Drawing.Size(674, 45);
            this.txtHistoricoClinico.TabIndex = 0;
            this.toolTipFichaClinica.SetToolTip(this.txtHistoricoClinico, "Insira o Histórico Clínico");
            this.txtHistoricoClinico.TextChanged += new System.EventHandler(this.txtHistoricoClinico_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Histórico Clinico:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLimpar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(931, 626);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(64, 21);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.toolTipFichaClinica.SetToolTip(this.btnLimpar, "Limpar Campos");
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnVoltar.BackgroundImage = global::MariosPet.Properties.Resources.botaoVoltarVerde;
            this.btnVoltar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(905, 554);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(115, 50);
            this.btnVoltar.TabIndex = 4;
            this.toolTipFichaClinica.SetToolTip(this.btnVoltar, "Voltar ao Menu");
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCadastrar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(931, 657);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(91, 21);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.toolTipFichaClinica.SetToolTip(this.btnCadastrar, "Cadastrar Ficha Clínica");
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnVermifugoVacina
            // 
            this.btnVermifugoVacina.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnVermifugoVacina.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVermifugoVacina.Location = new System.Drawing.Point(931, 696);
            this.btnVermifugoVacina.Name = "btnVermifugoVacina";
            this.btnVermifugoVacina.Size = new System.Drawing.Size(77, 42);
            this.btnVermifugoVacina.TabIndex = 7;
            this.btnVermifugoVacina.Text = "Vermífugo/Vacina";
            this.toolTipFichaClinica.SetToolTip(this.btnVermifugoVacina, "Ir para Vermífugo/Vacina");
            this.btnVermifugoVacina.UseVisualStyleBackColor = true;
            this.btnVermifugoVacina.Click += new System.EventHandler(this.btnVermifugoVacina_Click);
            // 
            // toolTipFichaClinica
            // 
            this.toolTipFichaClinica.AutomaticDelay = 100;
            this.toolTipFichaClinica.IsBalloon = true;
            this.toolTipFichaClinica.StripAmpersands = true;
            // 
            // FrmFichaClinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1034, 741);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVermifugoVacina);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnVoltar);
            this.Name = "FrmFichaClinica";
            this.Text = "FrmFichaClinica";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAnimal)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btmNovo;
        private System.Windows.Forms.DataGridView dtgAnimal;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtPesquisaAnimal;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPrescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSuspeita;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQueixa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHistoricoClinico;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnVermifugoVacina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTipFichaClinica;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtSintomas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtExames;
        private System.Windows.Forms.Label label6;
    }
}