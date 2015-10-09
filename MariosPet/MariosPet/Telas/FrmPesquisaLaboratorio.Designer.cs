namespace MariosPet.Telas
{
    partial class FrmPesquisaLaboratorio
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
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewLaboratorio = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtPesquisaLaboratorio = new System.Windows.Forms.TextBox();
            this.lblNomeLaboratório = new System.Windows.Forms.Label();
            this.toolTipPesquisaLaboratorio = new System.Windows.Forms.ToolTip(this.components);
            this.btnVoltar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLaboratorio)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.btnVoltar);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.dataGridViewLaboratorio);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.txtPesquisaLaboratorio);
            this.groupBox1.Controls.Add(this.lblNomeLaboratório);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.groupBox1.Location = new System.Drawing.Point(74, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 455);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "   Pesquisa";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(568, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 44);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cadastrar";
            this.toolTipPesquisaLaboratorio.SetToolTip(this.button2, "Cadastrar Novo Fornecedor");
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewLaboratorio
            // 
            this.dataGridViewLaboratorio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.dataGridViewLaboratorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLaboratorio.Location = new System.Drawing.Point(10, 93);
            this.dataGridViewLaboratorio.Name = "dataGridViewLaboratorio";
            this.dataGridViewLaboratorio.Size = new System.Drawing.Size(674, 278);
            this.dataGridViewLaboratorio.TabIndex = 2;
            this.toolTipPesquisaLaboratorio.SetToolTip(this.dataGridViewLaboratorio, "Resultados da Pesquisa");
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(568, 41);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(116, 44);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.toolTipPesquisaLaboratorio.SetToolTip(this.btnConsultar, "Consultar");
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisaLaboratorio
            // 
            this.txtPesquisaLaboratorio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaLaboratorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(46)))));
            this.txtPesquisaLaboratorio.Location = new System.Drawing.Point(234, 46);
            this.txtPesquisaLaboratorio.Name = "txtPesquisaLaboratorio";
            this.txtPesquisaLaboratorio.Size = new System.Drawing.Size(328, 27);
            this.txtPesquisaLaboratorio.TabIndex = 0;
            this.toolTipPesquisaLaboratorio.SetToolTip(this.txtPesquisaLaboratorio, "Insira o Nome do Laboratório");
            // 
            // lblNomeLaboratório
            // 
            this.lblNomeLaboratório.AutoSize = true;
            this.lblNomeLaboratório.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeLaboratório.Location = new System.Drawing.Point(6, 50);
            this.lblNomeLaboratório.Name = "lblNomeLaboratório";
            this.lblNomeLaboratório.Size = new System.Drawing.Size(222, 23);
            this.lblNomeLaboratório.TabIndex = 16;
            this.lblNomeLaboratório.Text = "Nome do Laboratório:";
            // 
            // toolTipPesquisaLaboratorio
            // 
            this.toolTipPesquisaLaboratorio.AutomaticDelay = 100;
            this.toolTipPesquisaLaboratorio.IsBalloon = true;
            this.toolTipPesquisaLaboratorio.StripAmpersands = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(422, 395);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(116, 44);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "Voltar";
            this.toolTipPesquisaLaboratorio.SetToolTip(this.btnVoltar, "Voltar ao Menu");
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // FrmPesquisaLaboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(847, 576);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPesquisaLaboratorio";
            this.Text = "frmPesquisaLaboratorio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLaboratorio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridViewLaboratorio;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtPesquisaLaboratorio;
        private System.Windows.Forms.Label lblNomeLaboratório;
        private System.Windows.Forms.ToolTip toolTipPesquisaLaboratorio;
        private System.Windows.Forms.Button btnVoltar;
    }
}