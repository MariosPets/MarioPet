﻿namespace MariosPet.Telas
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.roundButton1 = new MariosPet.Classes.RoundButton();
            this.roundButtonVacina = new MariosPet.Classes.RoundButton();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtExames = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtSintomas = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrescricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSuspeita = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQueixa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHistoricoClinico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTipFichaClinica = new System.Windows.Forms.ToolTip(this.components);
            this.btnNovo = new System.Windows.Forms.Button();
            this.dtgAnimal = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtPesquisaAnimal = new System.Windows.Forms.TextBox();
            this.groupBoxPesquisaAnimal = new System.Windows.Forms.GroupBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAnimal)).BeginInit();
            this.groupBoxPesquisaAnimal.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.BackgroundImage = global::MariosPet.Properties.Resources.pataMarromAmareloGrande;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.roundButton1);
            this.groupBox2.Controls.Add(this.roundButtonVacina);
            this.groupBox2.Controls.Add(this.txtObservacao);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtExames);
            this.groupBox2.Controls.Add(this.btnSalvar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnLimpar);
            this.groupBox2.Controls.Add(this.txtSintomas);
            this.groupBox2.Controls.Add(this.btnVoltar);
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
            this.groupBox2.Location = new System.Drawing.Point(12, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(968, 480);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "   Ficha Clínica";
            this.toolTipFichaClinica.SetToolTip(this.groupBox2, "Vacinas");
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(144)))), ((int)(((byte)(35)))));
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton1.Location = new System.Drawing.Point(530, 343);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(45, 45);
            this.roundButton1.TabIndex = 41;
            this.roundButton1.Text = "Vermifugo";
            this.roundButton1.UseVisualStyleBackColor = false;
            // 
            // roundButtonVacina
            // 
            this.roundButtonVacina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(190)))), ((int)(((byte)(142)))));
            this.roundButtonVacina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundButtonVacina.FlatAppearance.BorderSize = 0;
            this.roundButtonVacina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButtonVacina.Image = global::MariosPet.Properties.Resources.vaccineMarrom;
            this.roundButtonVacina.Location = new System.Drawing.Point(476, 343);
            this.roundButtonVacina.Name = "roundButtonVacina";
            this.roundButtonVacina.Size = new System.Drawing.Size(45, 45);
            this.roundButtonVacina.TabIndex = 40;
            this.roundButtonVacina.UseVisualStyleBackColor = false;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(10, 343);
            this.txtObservacao.MaxLength = 300;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(457, 77);
            this.txtObservacao.TabIndex = 38;
            this.toolTipFichaClinica.SetToolTip(this.txtObservacao, "Insira as Observações");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 18);
            this.label7.TabIndex = 39;
            this.label7.Text = "Observações:";
            // 
            // txtExames
            // 
            this.txtExames.Location = new System.Drawing.Point(474, 248);
            this.txtExames.MaxLength = 200;
            this.txtExames.Multiline = true;
            this.txtExames.Name = "txtExames";
            this.txtExames.Size = new System.Drawing.Size(477, 71);
            this.txtExames.TabIndex = 36;
            this.toolTipFichaClinica.SetToolTip(this.txtExames, "Exames Complementares");
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = global::MariosPet.Properties.Resources.botaoSalvarLaranja;
            this.btnSalvar.Location = new System.Drawing.Point(844, 343);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(124, 50);
            this.btnSalvar.TabIndex = 6;
            this.toolTipFichaClinica.SetToolTip(this.btnSalvar, "Salvar Ficha Clínica");
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(471, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 18);
            this.label6.TabIndex = 37;
            this.label6.Text = "Exames Complementares:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = global::MariosPet.Properties.Resources.botaoLimparLaranja;
            this.btnLimpar.Location = new System.Drawing.Point(731, 343);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(114, 50);
            this.btnLimpar.TabIndex = 5;
            this.toolTipFichaClinica.SetToolTip(this.btnLimpar, "Limpar Campos");
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtSintomas
            // 
            this.txtSintomas.Location = new System.Drawing.Point(10, 248);
            this.txtSintomas.MaxLength = 500;
            this.txtSintomas.Multiline = true;
            this.txtSintomas.Name = "txtSintomas";
            this.txtSintomas.Size = new System.Drawing.Size(457, 71);
            this.txtSintomas.TabIndex = 34;
            this.toolTipFichaClinica.SetToolTip(this.txtSintomas, "Descreva os Sintomas acometidos");
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnVoltar.BackgroundImage = global::MariosPet.Properties.Resources.botaoVoltarVerde;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(610, 346);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(115, 38);
            this.btnVoltar.TabIndex = 4;
            this.toolTipFichaClinica.SetToolTip(this.btnVoltar, "Voltar ao Menu");
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 35;
            this.label5.Text = "Sintomas:";
            // 
            // txtPrescricao
            // 
            this.txtPrescricao.Location = new System.Drawing.Point(476, 153);
            this.txtPrescricao.MaxLength = 300;
            this.txtPrescricao.Multiline = true;
            this.txtPrescricao.Name = "txtPrescricao";
            this.txtPrescricao.Size = new System.Drawing.Size(475, 71);
            this.txtPrescricao.TabIndex = 3;
            this.toolTipFichaClinica.SetToolTip(this.txtPrescricao, "Insira a Prescrição");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(473, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "Prescrição:";
            // 
            // txtSuspeita
            // 
            this.txtSuspeita.Location = new System.Drawing.Point(9, 153);
            this.txtSuspeita.MaxLength = 200;
            this.txtSuspeita.Multiline = true;
            this.txtSuspeita.Name = "txtSuspeita";
            this.txtSuspeita.Size = new System.Drawing.Size(458, 71);
            this.txtSuspeita.TabIndex = 2;
            this.toolTipFichaClinica.SetToolTip(this.txtSuspeita, "Insira a Suspeita");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 31;
            this.label3.Text = "Suspeita:";
            // 
            // txtQueixa
            // 
            this.txtQueixa.Location = new System.Drawing.Point(474, 57);
            this.txtQueixa.MaxLength = 200;
            this.txtQueixa.Multiline = true;
            this.txtQueixa.Name = "txtQueixa";
            this.txtQueixa.Size = new System.Drawing.Size(477, 72);
            this.txtQueixa.TabIndex = 1;
            this.toolTipFichaClinica.SetToolTip(this.txtQueixa, "Descreva as Principais Queixas");
            this.txtQueixa.TextChanged += new System.EventHandler(this.txtQueixa_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(471, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Principal Queixa:";
            // 
            // txtHistoricoClinico
            // 
            this.txtHistoricoClinico.Location = new System.Drawing.Point(9, 57);
            this.txtHistoricoClinico.MaxLength = 1000;
            this.txtHistoricoClinico.Multiline = true;
            this.txtHistoricoClinico.Name = "txtHistoricoClinico";
            this.txtHistoricoClinico.Size = new System.Drawing.Size(458, 72);
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
            // toolTipFichaClinica
            // 
            this.toolTipFichaClinica.AutomaticDelay = 100;
            this.toolTipFichaClinica.IsBalloon = true;
            this.toolTipFichaClinica.StripAmpersands = true;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = global::MariosPet.Properties.Resources.botaoNovoLaranja;
            this.btnNovo.Location = new System.Drawing.Point(789, 142);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(116, 44);
            this.btnNovo.TabIndex = 3;
            this.toolTipFichaClinica.SetToolTip(this.btnNovo, "Adicionar Novo");
            this.btnNovo.UseVisualStyleBackColor = false;
            // 
            // dtgAnimal
            // 
            this.dtgAnimal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(235)))), ((int)(((byte)(156)))));
            this.dtgAnimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAnimal.Location = new System.Drawing.Point(10, 93);
            this.dtgAnimal.Name = "dtgAnimal";
            this.dtgAnimal.Size = new System.Drawing.Size(726, 93);
            this.dtgAnimal.TabIndex = 2;
            this.toolTipFichaClinica.SetToolTip(this.dtgAnimal, "Resultado da Pesquisa");
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Image = global::MariosPet.Properties.Resources.botaoConsultarVerde;
            this.btnConsultar.Location = new System.Drawing.Point(789, 41);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(116, 44);
            this.btnConsultar.TabIndex = 1;
            this.toolTipFichaClinica.SetToolTip(this.btnConsultar, "Consultar");
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtPesquisaAnimal
            // 
            this.txtPesquisaAnimal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaAnimal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.txtPesquisaAnimal.Location = new System.Drawing.Point(159, 50);
            this.txtPesquisaAnimal.MaxLength = 80;
            this.txtPesquisaAnimal.Name = "txtPesquisaAnimal";
            this.txtPesquisaAnimal.Size = new System.Drawing.Size(577, 27);
            this.txtPesquisaAnimal.TabIndex = 0;
            this.toolTipFichaClinica.SetToolTip(this.txtPesquisaAnimal, "Insira o Nome do Animal");
            // 
            // groupBoxPesquisaAnimal
            // 
            this.groupBoxPesquisaAnimal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxPesquisaAnimal.BackgroundImage = global::MariosPet.Properties.Resources.pataMarromVerdeGrande;
            this.groupBoxPesquisaAnimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxPesquisaAnimal.Controls.Add(this.btnNovo);
            this.groupBoxPesquisaAnimal.Controls.Add(this.dtgAnimal);
            this.groupBoxPesquisaAnimal.Controls.Add(this.btnConsultar);
            this.groupBoxPesquisaAnimal.Controls.Add(this.txtPesquisaAnimal);
            this.groupBoxPesquisaAnimal.Controls.Add(this.lblNome);
            this.groupBoxPesquisaAnimal.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold);
            this.groupBoxPesquisaAnimal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.groupBoxPesquisaAnimal.Location = new System.Drawing.Point(12, 22);
            this.groupBoxPesquisaAnimal.Name = "groupBoxPesquisaAnimal";
            this.groupBoxPesquisaAnimal.Size = new System.Drawing.Size(951, 204);
            this.groupBoxPesquisaAnimal.TabIndex = 30;
            this.groupBoxPesquisaAnimal.TabStop = false;
            this.groupBoxPesquisaAnimal.Text = "   Pesquisa";
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
            // FrmFichaClinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1330, 733);
            this.Controls.Add(this.groupBoxPesquisaAnimal);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmFichaClinica";
            this.Text = "Ficha Clinica";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAnimal)).EndInit();
            this.groupBoxPesquisaAnimal.ResumeLayout(false);
            this.groupBoxPesquisaAnimal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPrescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSuspeita;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQueixa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHistoricoClinico;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTipFichaClinica;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtSintomas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtExames;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBoxPesquisaAnimal;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dtgAnimal;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtPesquisaAnimal;
        private System.Windows.Forms.Label lblNome;
        private Classes.RoundButton roundButtonVacina;
        private Classes.RoundButton roundButton1;
    }
}