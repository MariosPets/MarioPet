﻿namespace MariosPet.Telas
{
    partial class FrmBuscaVacina
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
            this.groupBoxBuscaVacina = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dtgBuscaVacina = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtPesquisaVacina = new System.Windows.Forms.TextBox();
            this.lblNomeVacina = new System.Windows.Forms.Label();
            this.groupBoxBuscaVacina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuscaVacina)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxBuscaVacina
            // 
            this.groupBoxBuscaVacina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxBuscaVacina.BackgroundImage = global::MariosPet.Properties.Resources.pataAmareloMarromGrande;
            this.groupBoxBuscaVacina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxBuscaVacina.Controls.Add(this.btnSalvar);
            this.groupBoxBuscaVacina.Controls.Add(this.btnLimpar);
            this.groupBoxBuscaVacina.Controls.Add(this.btnVoltar);
            this.groupBoxBuscaVacina.Controls.Add(this.btnNovo);
            this.groupBoxBuscaVacina.Controls.Add(this.dtgBuscaVacina);
            this.groupBoxBuscaVacina.Controls.Add(this.btnConsultar);
            this.groupBoxBuscaVacina.Controls.Add(this.txtPesquisaVacina);
            this.groupBoxBuscaVacina.Controls.Add(this.lblNomeVacina);
            this.groupBoxBuscaVacina.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold);
            this.groupBoxBuscaVacina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.groupBoxBuscaVacina.Location = new System.Drawing.Point(50, 36);
            this.groupBoxBuscaVacina.Name = "groupBoxBuscaVacina";
            this.groupBoxBuscaVacina.Size = new System.Drawing.Size(717, 263);
            this.groupBoxBuscaVacina.TabIndex = 5;
            this.groupBoxBuscaVacina.TabStop = false;
            this.groupBoxBuscaVacina.Text = "   Busca Vacina";
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = global::MariosPet.Properties.Resources.botaoSalvarVerde;
            this.btnSalvar.Location = new System.Drawing.Point(568, 213);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(117, 31);
            this.btnSalvar.TabIndex = 21;
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = global::MariosPet.Properties.Resources.botaoLimparLaranja;
            this.btnLimpar.Location = new System.Drawing.Point(454, 213);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(108, 31);
            this.btnLimpar.TabIndex = 19;
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Image = global::MariosPet.Properties.Resources.botaoVoltarVerde;
            this.btnVoltar.Location = new System.Drawing.Point(300, 213);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(126, 31);
            this.btnVoltar.TabIndex = 20;
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = global::MariosPet.Properties.Resources.botaoNovoLaranja;
            this.btnNovo.Location = new System.Drawing.Point(10, 213);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(117, 38);
            this.btnNovo.TabIndex = 3;
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // dtgBuscaVacina
            // 
            this.dtgBuscaVacina.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(235)))), ((int)(((byte)(156)))));
            this.dtgBuscaVacina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBuscaVacina.Location = new System.Drawing.Point(10, 91);
            this.dtgBuscaVacina.Name = "dtgBuscaVacina";
            this.dtgBuscaVacina.Size = new System.Drawing.Size(674, 97);
            this.dtgBuscaVacina.TabIndex = 2;
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
            this.txtPesquisaVacina.MaxLength = 50;
            this.txtPesquisaVacina.Name = "txtPesquisaVacina";
            this.txtPesquisaVacina.Size = new System.Drawing.Size(390, 27);
            this.txtPesquisaVacina.TabIndex = 0;
            // 
            // lblNomeVacina
            // 
            this.lblNomeVacina.AutoSize = true;
            this.lblNomeVacina.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeVacina.Location = new System.Drawing.Point(6, 50);
            this.lblNomeVacina.Name = "lblNomeVacina";
            this.lblNomeVacina.Size = new System.Drawing.Size(143, 23);
            this.lblNomeVacina.TabIndex = 16;
            this.lblNomeVacina.Text = "Nome Vacina:";
            // 
            // FrmBuscaVacina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(824, 334);
            this.Controls.Add(this.groupBoxBuscaVacina);
            this.Name = "FrmBuscaVacina";
            this.Text = "Busca Vacina";
            this.groupBoxBuscaVacina.ResumeLayout(false);
            this.groupBoxBuscaVacina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuscaVacina)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBuscaVacina;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dtgBuscaVacina;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtPesquisaVacina;
        private System.Windows.Forms.Label lblNomeVacina;

    }
}