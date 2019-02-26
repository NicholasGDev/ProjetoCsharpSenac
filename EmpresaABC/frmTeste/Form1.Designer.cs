namespace frmTeste
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
            this.btnCarregarEstados = new System.Windows.Forms.Button();
            this.cboEstados = new System.Windows.Forms.ComboBox();
            this.lblEst = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCarregarEstados
            // 
            this.btnCarregarEstados.Location = new System.Drawing.Point(12, 220);
            this.btnCarregarEstados.Name = "btnCarregarEstados";
            this.btnCarregarEstados.Size = new System.Drawing.Size(102, 23);
            this.btnCarregarEstados.TabIndex = 0;
            this.btnCarregarEstados.Text = "Carregar Estados";
            this.btnCarregarEstados.UseVisualStyleBackColor = true;
            this.btnCarregarEstados.Click += new System.EventHandler(this.btnCarregarEstados_Click);
            // 
            // cboEstados
            // 
            this.cboEstados.FormattingEnabled = true;
            this.cboEstados.Location = new System.Drawing.Point(12, 63);
            this.cboEstados.Name = "cboEstados";
            this.cboEstados.Size = new System.Drawing.Size(121, 21);
            this.cboEstados.TabIndex = 1;
            // 
            // lblEst
            // 
            this.lblEst.AutoSize = true;
            this.lblEst.Location = new System.Drawing.Point(23, 25);
            this.lblEst.Name = "lblEst";
            this.lblEst.Size = new System.Drawing.Size(45, 13);
            this.lblEst.TabIndex = 2;
            this.lblEst.Text = "Estados";
            // 
            // frmEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(153, 263);
            this.Controls.Add(this.lblEst);
            this.Controls.Add(this.cboEstados);
            this.Controls.Add(this.btnCarregarEstados);
            this.Name = "frmEstados";
            this.Text = "Teste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCarregarEstados;
        private System.Windows.Forms.ComboBox cboEstados;
        private System.Windows.Forms.Label lblEst;
    }
}

