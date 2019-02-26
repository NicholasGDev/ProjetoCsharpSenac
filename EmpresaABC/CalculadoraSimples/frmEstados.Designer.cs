namespace CalculadoraSimples
{
    partial class frmEstados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstados));
            this.lblEstados = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCrrega = new System.Windows.Forms.Button();
            this.cboEstados = new System.Windows.Forms.ComboBox();
            this.ltbListaEstado = new System.Windows.Forms.ListBox();
            this.btnLista = new System.Windows.Forms.Button();
            this.lblRecebe = new System.Windows.Forms.Label();
            this.btnCarregaLabel = new System.Windows.Forms.Button();
            this.lblListaEstado = new System.Windows.Forms.Label();
            this.gpbSexo = new System.Windows.Forms.GroupBox();
            this.rdbMasc = new System.Windows.Forms.RadioButton();
            this.rdbFem = new System.Windows.Forms.RadioButton();
            this.lblSexo = new System.Windows.Forms.Label();
            this.gbpPeriodo = new System.Windows.Forms.GroupBox();
            this.ckbManha = new System.Windows.Forms.CheckBox();
            this.ckbTarde = new System.Windows.Forms.CheckBox();
            this.ckbNoite = new System.Windows.Forms.CheckBox();
            this.btnEscolha = new System.Windows.Forms.Button();
            this.gpbSexo.SuspendLayout();
            this.gbpPeriodo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEstados
            // 
            this.lblEstados.AutoSize = true;
            this.lblEstados.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstados.Location = new System.Drawing.Point(11, 12);
            this.lblEstados.Name = "lblEstados";
            this.lblEstados.Size = new System.Drawing.Size(54, 17);
            this.lblEstados.TabIndex = 0;
            this.lblEstados.Text = "Estados";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Enabled = false;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(162, 420);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(115, 42);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnCrrega
            // 
            this.btnCrrega.Enabled = false;
            this.btnCrrega.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrrega.Location = new System.Drawing.Point(14, 359);
            this.btnCrrega.Name = "btnCrrega";
            this.btnCrrega.Size = new System.Drawing.Size(123, 42);
            this.btnCrrega.TabIndex = 2;
            this.btnCrrega.Text = "Carrega Estados";
            this.btnCrrega.UseVisualStyleBackColor = true;
            this.btnCrrega.Click += new System.EventHandler(this.btnCrrega_Click_1);
            // 
            // cboEstados
            // 
            this.cboEstados.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstados.FormattingEnabled = true;
            this.cboEstados.Location = new System.Drawing.Point(14, 32);
            this.cboEstados.Name = "cboEstados";
            this.cboEstados.Size = new System.Drawing.Size(121, 25);
            this.cboEstados.TabIndex = 4;
            this.cboEstados.SelectedIndexChanged += new System.EventHandler(this.cboEstados_SelectedIndexChanged);
            // 
            // ltbListaEstado
            // 
            this.ltbListaEstado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbListaEstado.FormattingEnabled = true;
            this.ltbListaEstado.ItemHeight = 17;
            this.ltbListaEstado.Location = new System.Drawing.Point(14, 109);
            this.ltbListaEstado.Name = "ltbListaEstado";
            this.ltbListaEstado.Size = new System.Drawing.Size(141, 106);
            this.ltbListaEstado.TabIndex = 5;
            this.ltbListaEstado.SelectedIndexChanged += new System.EventHandler(this.ltbListaEstado_SelectedIndexChanged);
            // 
            // btnLista
            // 
            this.btnLista.Enabled = false;
            this.btnLista.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLista.Location = new System.Drawing.Point(14, 420);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(123, 42);
            this.btnLista.TabIndex = 6;
            this.btnLista.Text = "Carrega Lista";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // lblRecebe
            // 
            this.lblRecebe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRecebe.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblRecebe.Location = new System.Drawing.Point(334, 347);
            this.lblRecebe.Name = "lblRecebe";
            this.lblRecebe.Size = new System.Drawing.Size(100, 36);
            this.lblRecebe.TabIndex = 7;
            // 
            // btnCarregaLabel
            // 
            this.btnCarregaLabel.Enabled = false;
            this.btnCarregaLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnCarregaLabel.Location = new System.Drawing.Point(162, 359);
            this.btnCarregaLabel.Name = "btnCarregaLabel";
            this.btnCarregaLabel.Size = new System.Drawing.Size(115, 42);
            this.btnCarregaLabel.TabIndex = 8;
            this.btnCarregaLabel.Text = "Carrega Label";
            this.btnCarregaLabel.UseVisualStyleBackColor = true;
            this.btnCarregaLabel.Click += new System.EventHandler(this.btnCarregaLabel_Click);
            // 
            // lblListaEstado
            // 
            this.lblListaEstado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblListaEstado.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblListaEstado.Location = new System.Drawing.Point(334, 394);
            this.lblListaEstado.Name = "lblListaEstado";
            this.lblListaEstado.Size = new System.Drawing.Size(100, 36);
            this.lblListaEstado.TabIndex = 9;
            // 
            // gpbSexo
            // 
            this.gpbSexo.Controls.Add(this.rdbFem);
            this.gpbSexo.Controls.Add(this.rdbMasc);
            this.gpbSexo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSexo.Location = new System.Drawing.Point(234, 32);
            this.gpbSexo.Name = "gpbSexo";
            this.gpbSexo.Size = new System.Drawing.Size(200, 113);
            this.gpbSexo.TabIndex = 10;
            this.gpbSexo.TabStop = false;
            this.gpbSexo.Text = "sexo";
            this.gpbSexo.Enter += new System.EventHandler(this.gpbSexo_Enter);
            // 
            // rdbMasc
            // 
            this.rdbMasc.AutoSize = true;
            this.rdbMasc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMasc.Location = new System.Drawing.Point(6, 38);
            this.rdbMasc.Name = "rdbMasc";
            this.rdbMasc.Size = new System.Drawing.Size(85, 21);
            this.rdbMasc.TabIndex = 0;
            this.rdbMasc.TabStop = true;
            this.rdbMasc.Text = "Masculino";
            this.rdbMasc.UseVisualStyleBackColor = true;
            this.rdbMasc.CheckedChanged += new System.EventHandler(this.rdbMasc_CheckedChanged);
            // 
            // rdbFem
            // 
            this.rdbFem.AutoSize = true;
            this.rdbFem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFem.Location = new System.Drawing.Point(6, 61);
            this.rdbFem.Name = "rdbFem";
            this.rdbFem.Size = new System.Drawing.Size(78, 21);
            this.rdbFem.TabIndex = 1;
            this.rdbFem.TabStop = true;
            this.rdbFem.Text = "Feminino";
            this.rdbFem.UseVisualStyleBackColor = true;
            this.rdbFem.CheckedChanged += new System.EventHandler(this.rdbFem_CheckedChanged);
            // 
            // lblSexo
            // 
            this.lblSexo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSexo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblSexo.Location = new System.Drawing.Point(334, 438);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(100, 36);
            this.lblSexo.TabIndex = 11;
            // 
            // gbpPeriodo
            // 
            this.gbpPeriodo.Controls.Add(this.ckbNoite);
            this.gbpPeriodo.Controls.Add(this.ckbTarde);
            this.gbpPeriodo.Controls.Add(this.ckbManha);
            this.gbpPeriodo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbpPeriodo.Location = new System.Drawing.Point(234, 178);
            this.gbpPeriodo.Name = "gbpPeriodo";
            this.gbpPeriodo.Size = new System.Drawing.Size(200, 100);
            this.gbpPeriodo.TabIndex = 12;
            this.gbpPeriodo.TabStop = false;
            this.gbpPeriodo.Text = "Escolha";
            // 
            // ckbManha
            // 
            this.ckbManha.AutoSize = true;
            this.ckbManha.Location = new System.Drawing.Point(7, 19);
            this.ckbManha.Name = "ckbManha";
            this.ckbManha.Size = new System.Drawing.Size(67, 21);
            this.ckbManha.TabIndex = 0;
            this.ckbManha.Text = "Manhã";
            this.ckbManha.UseVisualStyleBackColor = true;
            // 
            // ckbTarde
            // 
            this.ckbTarde.AutoSize = true;
            this.ckbTarde.Location = new System.Drawing.Point(7, 43);
            this.ckbTarde.Name = "ckbTarde";
            this.ckbTarde.Size = new System.Drawing.Size(60, 21);
            this.ckbTarde.TabIndex = 1;
            this.ckbTarde.Text = "Tarde";
            this.ckbTarde.UseVisualStyleBackColor = true;
            // 
            // ckbNoite
            // 
            this.ckbNoite.AutoSize = true;
            this.ckbNoite.Location = new System.Drawing.Point(7, 67);
            this.ckbNoite.Name = "ckbNoite";
            this.ckbNoite.Size = new System.Drawing.Size(59, 21);
            this.ckbNoite.TabIndex = 2;
            this.ckbNoite.Text = "Noite";
            this.ckbNoite.UseVisualStyleBackColor = true;
            // 
            // btnEscolha
            // 
            this.btnEscolha.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnEscolha.Location = new System.Drawing.Point(14, 311);
            this.btnEscolha.Name = "btnEscolha";
            this.btnEscolha.Size = new System.Drawing.Size(123, 42);
            this.btnEscolha.TabIndex = 13;
            this.btnEscolha.Text = "Escolha";
            this.btnEscolha.UseVisualStyleBackColor = true;
            this.btnEscolha.Click += new System.EventHandler(this.btnEscolha_Click);
            // 
            // frmEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 493);
            this.Controls.Add(this.btnEscolha);
            this.Controls.Add(this.gbpPeriodo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.gpbSexo);
            this.Controls.Add(this.lblListaEstado);
            this.Controls.Add(this.btnCarregaLabel);
            this.Controls.Add(this.lblRecebe);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.ltbListaEstado);
            this.Controls.Add(this.cboEstados);
            this.Controls.Add(this.btnCrrega);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblEstados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEstados";
            this.Text = "frmEstadoscs";
            this.Load += new System.EventHandler(this.frmEstadoscs_Load);
            this.gpbSexo.ResumeLayout(false);
            this.gpbSexo.PerformLayout();
            this.gbpPeriodo.ResumeLayout(false);
            this.gbpPeriodo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstados;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCrrega;
        private System.Windows.Forms.ComboBox cboEstados;
        private System.Windows.Forms.ListBox ltbListaEstado;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Label lblRecebe;
        private System.Windows.Forms.Button btnCarregaLabel;
        private System.Windows.Forms.Label lblListaEstado;
        private System.Windows.Forms.GroupBox gpbSexo;
        private System.Windows.Forms.RadioButton rdbFem;
        private System.Windows.Forms.RadioButton rdbMasc;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.GroupBox gbpPeriodo;
        private System.Windows.Forms.CheckBox ckbNoite;
        private System.Windows.Forms.CheckBox ckbTarde;
        private System.Windows.Forms.CheckBox ckbManha;
        private System.Windows.Forms.Button btnEscolha;
    }
}