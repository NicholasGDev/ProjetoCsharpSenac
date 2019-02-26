namespace FolhaPagamento
{
    partial class frmFolhaPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFolhaPagamento));
            this.lblDataFolha = new System.Windows.Forms.Label();
            this.dtpDataFolha = new System.Windows.Forms.DateTimePicker();
            this.lblClubedelazer = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblSalarioFolha = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtSalariofolha = new System.Windows.Forms.TextBox();
            this.txtImpostoderenda = new System.Windows.Forms.TextBox();
            this.txtSalarioliquido = new System.Windows.Forms.TextBox();
            this.ckbPlanSaude = new System.Windows.Forms.CheckBox();
            this.cboClubedelazer = new System.Windows.Forms.ComboBox();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDataFolha
            // 
            this.lblDataFolha.AutoSize = true;
            this.lblDataFolha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFolha.Location = new System.Drawing.Point(22, 29);
            this.lblDataFolha.Name = "lblDataFolha";
            this.lblDataFolha.Size = new System.Drawing.Size(89, 17);
            this.lblDataFolha.TabIndex = 0;
            this.lblDataFolha.Text = "Data da Folha";
            // 
            // dtpDataFolha
            // 
            this.dtpDataFolha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataFolha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFolha.Location = new System.Drawing.Point(25, 48);
            this.dtpDataFolha.Name = "dtpDataFolha";
            this.dtpDataFolha.Size = new System.Drawing.Size(108, 25);
            this.dtpDataFolha.TabIndex = 1;
            // 
            // lblClubedelazer
            // 
            this.lblClubedelazer.AutoSize = true;
            this.lblClubedelazer.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblClubedelazer.Location = new System.Drawing.Point(22, 216);
            this.lblClubedelazer.Name = "lblClubedelazer";
            this.lblClubedelazer.Size = new System.Drawing.Size(95, 17);
            this.lblClubedelazer.TabIndex = 2;
            this.lblClubedelazer.Text = "Clube de Lazer";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblSalario.Location = new System.Drawing.Point(22, 90);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(48, 17);
            this.lblSalario.TabIndex = 4;
            this.lblSalario.Text = "Salário";
            // 
            // lblSalarioFolha
            // 
            this.lblSalarioFolha.AutoSize = true;
            this.lblSalarioFolha.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblSalarioFolha.Location = new System.Drawing.Point(233, 37);
            this.lblSalarioFolha.Name = "lblSalarioFolha";
            this.lblSalarioFolha.Size = new System.Drawing.Size(83, 17);
            this.lblSalarioFolha.TabIndex = 5;
            this.lblSalarioFolha.Text = "Salário Folha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label5.Location = new System.Drawing.Point(207, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Imposto de Renda";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label6.Location = new System.Drawing.Point(221, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Salário Liquido";
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtSalario.Location = new System.Drawing.Point(25, 120);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 25);
            this.txtSalario.TabIndex = 8;
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);
            // 
            // txtSalariofolha
            // 
            this.txtSalariofolha.Enabled = false;
            this.txtSalariofolha.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtSalariofolha.Location = new System.Drawing.Point(322, 29);
            this.txtSalariofolha.Name = "txtSalariofolha";
            this.txtSalariofolha.Size = new System.Drawing.Size(100, 25);
            this.txtSalariofolha.TabIndex = 9;
            // 
            // txtImpostoderenda
            // 
            this.txtImpostoderenda.Enabled = false;
            this.txtImpostoderenda.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtImpostoderenda.Location = new System.Drawing.Point(322, 57);
            this.txtImpostoderenda.Name = "txtImpostoderenda";
            this.txtImpostoderenda.Size = new System.Drawing.Size(100, 25);
            this.txtImpostoderenda.TabIndex = 10;
            // 
            // txtSalarioliquido
            // 
            this.txtSalarioliquido.Enabled = false;
            this.txtSalarioliquido.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtSalarioliquido.Location = new System.Drawing.Point(322, 87);
            this.txtSalarioliquido.Name = "txtSalarioliquido";
            this.txtSalarioliquido.Size = new System.Drawing.Size(100, 25);
            this.txtSalarioliquido.TabIndex = 11;
            // 
            // ckbPlanSaude
            // 
            this.ckbPlanSaude.AutoSize = true;
            this.ckbPlanSaude.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ckbPlanSaude.Location = new System.Drawing.Point(25, 167);
            this.ckbPlanSaude.Name = "ckbPlanSaude";
            this.ckbPlanSaude.Size = new System.Drawing.Size(119, 21);
            this.ckbPlanSaude.TabIndex = 12;
            this.ckbPlanSaude.Text = "Plano De Saude";
            this.ckbPlanSaude.UseVisualStyleBackColor = true;
            this.ckbPlanSaude.CheckedChanged += new System.EventHandler(this.ckbPlanSaude_CheckedChanged);
            // 
            // cboClubedelazer
            // 
            this.cboClubedelazer.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboClubedelazer.FormattingEnabled = true;
            this.cboClubedelazer.Location = new System.Drawing.Point(25, 246);
            this.cboClubedelazer.Name = "cboClubedelazer";
            this.cboClubedelazer.Size = new System.Drawing.Size(121, 25);
            this.cboClubedelazer.TabIndex = 13;
            this.cboClubedelazer.SelectedIndexChanged += new System.EventHandler(this.cboClubedelazer_SelectedIndexChanged);
            // 
            // btnCalcula
            // 
            this.btnCalcula.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnCalcula.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcula.Image")));
            this.btnCalcula.Location = new System.Drawing.Point(268, 216);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(158, 55);
            this.btnCalcula.TabIndex = 14;
            this.btnCalcula.Text = "Calcula";
            this.btnCalcula.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // frmFolhaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 315);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.cboClubedelazer);
            this.Controls.Add(this.ckbPlanSaude);
            this.Controls.Add(this.txtSalarioliquido);
            this.Controls.Add(this.txtImpostoderenda);
            this.Controls.Add(this.txtSalariofolha);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSalarioFolha);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblClubedelazer);
            this.Controls.Add(this.dtpDataFolha);
            this.Controls.Add(this.lblDataFolha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFolhaPagamento";
            this.Text = "Folha de Pagamento";
            this.Load += new System.EventHandler(this.frmFolhaPagamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataFolha;
        private System.Windows.Forms.DateTimePicker dtpDataFolha;
        private System.Windows.Forms.Label lblClubedelazer;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblSalarioFolha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtSalariofolha;
        private System.Windows.Forms.TextBox txtImpostoderenda;
        private System.Windows.Forms.TextBox txtSalarioliquido;
        private System.Windows.Forms.CheckBox ckbPlanSaude;
        private System.Windows.Forms.ComboBox cboClubedelazer;
        private System.Windows.Forms.Button btnCalcula;
    }
}