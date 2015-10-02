namespace MariosPet.Telas
{
    partial class FrmAnimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnimal));
            this.pictureBoxAnimal = new System.Windows.Forms.PictureBox();
            this.groupBoxAnimal = new System.Windows.Forms.GroupBox();
            this.maskedTxtNascimentoAnimal = new System.Windows.Forms.MaskedTextBox();
            this.lblPelagemCor = new System.Windows.Forms.Label();
            this.txtPelagemCor = new System.Windows.Forms.TextBox();
            this.txtRacaPorte = new System.Windows.Forms.TextBox();
            this.txtNomeAnimal = new System.Windows.Forms.TextBox();
            this.lblRacaPorte = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNomeAnimal = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.lblNascimentoAnimal = new System.Windows.Forms.Label();
            this.btmLimpar = new System.Windows.Forms.Button();
            this.btmVoltar = new System.Windows.Forms.Button();
            this.btmSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnimal)).BeginInit();
            this.groupBoxAnimal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxAnimal
            // 
            this.pictureBoxAnimal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxAnimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxAnimal.Location = new System.Drawing.Point(56, 51);
            this.pictureBoxAnimal.Name = "pictureBoxAnimal";
            this.pictureBoxAnimal.Size = new System.Drawing.Size(170, 167);
            this.pictureBoxAnimal.TabIndex = 1;
            this.pictureBoxAnimal.TabStop = false;
            // 
            // groupBoxAnimal
            // 
            this.groupBoxAnimal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxAnimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.groupBoxAnimal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxAnimal.BackgroundImage")));
            this.groupBoxAnimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxAnimal.Controls.Add(this.btmLimpar);
            this.groupBoxAnimal.Controls.Add(this.btmVoltar);
            this.groupBoxAnimal.Controls.Add(this.btmSalvar);
            this.groupBoxAnimal.Controls.Add(this.lblNascimentoAnimal);
            this.groupBoxAnimal.Controls.Add(this.txtSexo);
            this.groupBoxAnimal.Controls.Add(this.maskedTxtNascimentoAnimal);
            this.groupBoxAnimal.Controls.Add(this.pictureBoxAnimal);
            this.groupBoxAnimal.Controls.Add(this.lblPelagemCor);
            this.groupBoxAnimal.Controls.Add(this.txtPelagemCor);
            this.groupBoxAnimal.Controls.Add(this.txtRacaPorte);
            this.groupBoxAnimal.Controls.Add(this.txtNomeAnimal);
            this.groupBoxAnimal.Controls.Add(this.lblRacaPorte);
            this.groupBoxAnimal.Controls.Add(this.lblEmail);
            this.groupBoxAnimal.Controls.Add(this.lblNomeAnimal);
            this.groupBoxAnimal.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAnimal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.groupBoxAnimal.Location = new System.Drawing.Point(58, 123);
            this.groupBoxAnimal.Name = "groupBoxAnimal";
            this.groupBoxAnimal.Size = new System.Drawing.Size(801, 324);
            this.groupBoxAnimal.TabIndex = 6;
            this.groupBoxAnimal.TabStop = false;
            this.groupBoxAnimal.Text = "   Dados do Animal";
            // 
            // maskedTxtNascimentoAnimal
            // 
            this.maskedTxtNascimentoAnimal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTxtNascimentoAnimal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.maskedTxtNascimentoAnimal.Location = new System.Drawing.Point(388, 191);
            this.maskedTxtNascimentoAnimal.Mask = "00/00/0000";
            this.maskedTxtNascimentoAnimal.Name = "maskedTxtNascimentoAnimal";
            this.maskedTxtNascimentoAnimal.Size = new System.Drawing.Size(158, 27);
            this.maskedTxtNascimentoAnimal.TabIndex = 15;
            this.maskedTxtNascimentoAnimal.ValidatingType = typeof(System.DateTime);
            // 
            // lblPelagemCor
            // 
            this.lblPelagemCor.AutoSize = true;
            this.lblPelagemCor.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPelagemCor.Location = new System.Drawing.Point(232, 146);
            this.lblPelagemCor.Name = "lblPelagemCor";
            this.lblPelagemCor.Size = new System.Drawing.Size(141, 23);
            this.lblPelagemCor.TabIndex = 14;
            this.lblPelagemCor.Text = "Pelagem/Cor:";
            // 
            // txtPelagemCor
            // 
            this.txtPelagemCor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPelagemCor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.txtPelagemCor.Location = new System.Drawing.Point(388, 142);
            this.txtPelagemCor.MaxLength = 20;
            this.txtPelagemCor.Name = "txtPelagemCor";
            this.txtPelagemCor.Size = new System.Drawing.Size(345, 27);
            this.txtPelagemCor.TabIndex = 11;
            // 
            // txtRacaPorte
            // 
            this.txtRacaPorte.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRacaPorte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.txtRacaPorte.Location = new System.Drawing.Point(388, 94);
            this.txtRacaPorte.MaxLength = 20;
            this.txtRacaPorte.Name = "txtRacaPorte";
            this.txtRacaPorte.Size = new System.Drawing.Size(345, 27);
            this.txtRacaPorte.TabIndex = 10;
            // 
            // txtNomeAnimal
            // 
            this.txtNomeAnimal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAnimal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.txtNomeAnimal.Location = new System.Drawing.Point(388, 51);
            this.txtNomeAnimal.MaxLength = 20;
            this.txtNomeAnimal.Name = "txtNomeAnimal";
            this.txtNomeAnimal.Size = new System.Drawing.Size(345, 27);
            this.txtNomeAnimal.TabIndex = 7;
            // 
            // lblRacaPorte
            // 
            this.lblRacaPorte.AutoSize = true;
            this.lblRacaPorte.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRacaPorte.Location = new System.Drawing.Point(232, 98);
            this.lblRacaPorte.Name = "lblRacaPorte";
            this.lblRacaPorte.Size = new System.Drawing.Size(129, 23);
            this.lblRacaPorte.TabIndex = 5;
            this.lblRacaPorte.Text = "Raça/Porte: ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(601, 195);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(66, 23);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Sexo:";
            // 
            // lblNomeAnimal
            // 
            this.lblNomeAnimal.AutoSize = true;
            this.lblNomeAnimal.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeAnimal.Location = new System.Drawing.Point(232, 55);
            this.lblNomeAnimal.Name = "lblNomeAnimal";
            this.lblNomeAnimal.Size = new System.Drawing.Size(74, 23);
            this.lblNomeAnimal.TabIndex = 0;
            this.lblNomeAnimal.Text = "Nome:";
            // 
            // txtSexo
            // 
            this.txtSexo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.txtSexo.Location = new System.Drawing.Point(673, 191);
            this.txtSexo.MaxLength = 1;
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(60, 27);
            this.txtSexo.TabIndex = 16;
            // 
            // lblNascimentoAnimal
            // 
            this.lblNascimentoAnimal.AutoSize = true;
            this.lblNascimentoAnimal.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNascimentoAnimal.Location = new System.Drawing.Point(232, 195);
            this.lblNascimentoAnimal.Name = "lblNascimentoAnimal";
            this.lblNascimentoAnimal.Size = new System.Drawing.Size(130, 23);
            this.lblNascimentoAnimal.TabIndex = 17;
            this.lblNascimentoAnimal.Text = "Nascimento:";
            // 
            // btmLimpar
            // 
            this.btmLimpar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btmLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.btmLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btmLimpar.BackgroundImage")));
            this.btmLimpar.FlatAppearance.BorderSize = 0;
            this.btmLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmLimpar.Location = new System.Drawing.Point(330, 261);
            this.btmLimpar.Name = "btmLimpar";
            this.btmLimpar.Size = new System.Drawing.Size(117, 44);
            this.btmLimpar.TabIndex = 20;
            this.btmLimpar.UseVisualStyleBackColor = false;
            // 
            // btmVoltar
            // 
            this.btmVoltar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btmVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.btmVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btmVoltar.BackgroundImage")));
            this.btmVoltar.FlatAppearance.BorderSize = 0;
            this.btmVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmVoltar.Location = new System.Drawing.Point(110, 261);
            this.btmVoltar.Name = "btmVoltar";
            this.btmVoltar.Size = new System.Drawing.Size(116, 44);
            this.btmVoltar.TabIndex = 19;
            this.btmVoltar.UseVisualStyleBackColor = false;
            this.btmVoltar.Click += new System.EventHandler(this.btmVoltar_Click);
            // 
            // btmSalvar
            // 
            this.btmSalvar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btmSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.btmSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btmSalvar.BackgroundImage")));
            this.btmSalvar.FlatAppearance.BorderSize = 0;
            this.btmSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmSalvar.Location = new System.Drawing.Point(550, 261);
            this.btmSalvar.Name = "btmSalvar";
            this.btmSalvar.Size = new System.Drawing.Size(117, 42);
            this.btmSalvar.TabIndex = 18;
            this.btmSalvar.UseVisualStyleBackColor = false;
            // 
            // FrmAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1019, 508);
            this.Controls.Add(this.groupBoxAnimal);
            this.Name = "FrmAnimal";
            this.Text = "FrmAnimal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnimal)).EndInit();
            this.groupBoxAnimal.ResumeLayout(false);
            this.groupBoxAnimal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAnimal;
        private System.Windows.Forms.GroupBox groupBoxAnimal;
        private System.Windows.Forms.MaskedTextBox maskedTxtNascimentoAnimal;
        private System.Windows.Forms.Label lblPelagemCor;
        private System.Windows.Forms.TextBox txtPelagemCor;
        private System.Windows.Forms.TextBox txtRacaPorte;
        private System.Windows.Forms.TextBox txtNomeAnimal;
        private System.Windows.Forms.Label lblRacaPorte;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNomeAnimal;
        private System.Windows.Forms.Label lblNascimentoAnimal;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.Button btmLimpar;
        private System.Windows.Forms.Button btmVoltar;
        private System.Windows.Forms.Button btmSalvar;


    }
}