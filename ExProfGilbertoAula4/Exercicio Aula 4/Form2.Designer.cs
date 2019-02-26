namespace Exercicio_Aula_4
{
    partial class Form2
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
            this.lblNotaum = new System.Windows.Forms.Label();
            this.lblNotadois = new System.Windows.Forms.Label();
            this.lblNotatres = new System.Windows.Forms.Label();
            this.lblNotaquatro = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblResul = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNotaum
            // 
            this.lblNotaum.AutoSize = true;
            this.lblNotaum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotaum.Location = new System.Drawing.Point(24, 40);
            this.lblNotaum.Name = "lblNotaum";
            this.lblNotaum.Size = new System.Drawing.Size(49, 17);
            this.lblNotaum.TabIndex = 0;
            this.lblNotaum.Text = "Nota 1";
            this.lblNotaum.Click += new System.EventHandler(this.lblNotaum_Click);
            // 
            // lblNotadois
            // 
            this.lblNotadois.AutoSize = true;
            this.lblNotadois.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotadois.Location = new System.Drawing.Point(24, 113);
            this.lblNotadois.Name = "lblNotadois";
            this.lblNotadois.Size = new System.Drawing.Size(49, 17);
            this.lblNotadois.TabIndex = 1;
            this.lblNotadois.Text = "Nota 2";
            this.lblNotadois.Click += new System.EventHandler(this.lblNotadois_Click);
            // 
            // lblNotatres
            // 
            this.lblNotatres.AutoSize = true;
            this.lblNotatres.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotatres.Location = new System.Drawing.Point(24, 185);
            this.lblNotatres.Name = "lblNotatres";
            this.lblNotatres.Size = new System.Drawing.Size(49, 17);
            this.lblNotatres.TabIndex = 2;
            this.lblNotatres.Text = "Nota 3";
            this.lblNotatres.Click += new System.EventHandler(this.lblNotatres_Click);
            // 
            // lblNotaquatro
            // 
            this.lblNotaquatro.AutoSize = true;
            this.lblNotaquatro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotaquatro.Location = new System.Drawing.Point(24, 267);
            this.lblNotaquatro.Name = "lblNotaquatro";
            this.lblNotaquatro.Size = new System.Drawing.Size(49, 17);
            this.lblNotaquatro.TabIndex = 3;
            this.lblNotaquatro.Text = "Nota 4";
            this.lblNotaquatro.Click += new System.EventHandler(this.lblNotaquatro_Click);
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia.Location = new System.Drawing.Point(24, 380);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(50, 17);
            this.lblMedia.TabIndex = 4;
            this.lblMedia.Text = "Média:";
            this.lblMedia.Click += new System.EventHandler(this.lblMedia_Click);
            // 
            // lblResul
            // 
            this.lblResul.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResul.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResul.Location = new System.Drawing.Point(98, 374);
            this.lblResul.Name = "lblResul";
            this.lblResul.Size = new System.Drawing.Size(100, 23);
            this.lblResul.TabIndex = 5;
            this.lblResul.Click += new System.EventHandler(this.lblResul_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(12, 145);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(12, 221);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 25);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(12, 298);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 25);
            this.textBox4.TabIndex = 9;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(272, 374);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 30);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 432);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblResul);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.lblNotaquatro);
            this.Controls.Add(this.lblNotatres);
            this.Controls.Add(this.lblNotadois);
            this.Controls.Add(this.lblNotaum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNotaum;
        private System.Windows.Forms.Label lblNotadois;
        private System.Windows.Forms.Label lblNotatres;
        private System.Windows.Forms.Label lblNotaquatro;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblResul;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnCalcular;
    }
}