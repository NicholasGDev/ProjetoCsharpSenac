namespace expandirimagem
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOriginal = new System.Windows.Forms.Button();
            this.lblContador = new System.Windows.Forms.Label();
            this.btnExpandir = new System.Windows.Forms.Button();
            this.lblClick = new System.Windows.Forms.Label();
            this.btnDiminuir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::expandirimagem.Properties.Resources.inglaterra;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.btnDiminuir);
            this.panel1.Controls.Add(this.lblClick);
            this.panel1.Controls.Add(this.btnOriginal);
            this.panel1.Controls.Add(this.lblContador);
            this.panel1.Controls.Add(this.btnExpandir);
            this.panel1.Location = new System.Drawing.Point(-2, 435);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 56);
            this.panel1.TabIndex = 1;
            // 
            // btnOriginal
            // 
            this.btnOriginal.AutoSize = true;
            this.btnOriginal.Location = new System.Drawing.Point(191, 13);
            this.btnOriginal.Name = "btnOriginal";
            this.btnOriginal.Size = new System.Drawing.Size(100, 37);
            this.btnOriginal.TabIndex = 4;
            this.btnOriginal.Text = "Tamanho Original";
            this.btnOriginal.UseVisualStyleBackColor = true;
            this.btnOriginal.Click += new System.EventHandler(this.btnOriginal_Click);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(544, 25);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(16, 13);
            this.lblContador.TabIndex = 1;
            this.lblContador.Text = "0 ";
            this.lblContador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExpandir
            // 
            this.btnExpandir.Location = new System.Drawing.Point(14, 20);
            this.btnExpandir.Name = "btnExpandir";
            this.btnExpandir.Size = new System.Drawing.Size(75, 23);
            this.btnExpandir.TabIndex = 0;
            this.btnExpandir.Text = "Expandir";
            this.btnExpandir.UseVisualStyleBackColor = true;
            this.btnExpandir.Click += new System.EventHandler(this.btnExpandir_Click_1);
            // 
            // lblClick
            // 
            this.lblClick.AutoSize = true;
            this.lblClick.Location = new System.Drawing.Point(587, 25);
            this.lblClick.Name = "lblClick";
            this.lblClick.Size = new System.Drawing.Size(47, 13);
            this.lblClick.TabIndex = 3;
            this.lblClick.Text = "Clique(s)";
            // 
            // btnDiminuir
            // 
            this.btnDiminuir.Location = new System.Drawing.Point(95, 20);
            this.btnDiminuir.Name = "btnDiminuir";
            this.btnDiminuir.Size = new System.Drawing.Size(75, 23);
            this.btnDiminuir.TabIndex = 2;
            this.btnDiminuir.Text = "diminuir";
            this.btnDiminuir.UseVisualStyleBackColor = true;
            this.btnDiminuir.Click += new System.EventHandler(this.btnDiminuir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 490);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Button btnExpandir;
        private System.Windows.Forms.Button btnOriginal;
        private System.Windows.Forms.Button btnDiminuir;
        private System.Windows.Forms.Label lblClick;
    }
}

