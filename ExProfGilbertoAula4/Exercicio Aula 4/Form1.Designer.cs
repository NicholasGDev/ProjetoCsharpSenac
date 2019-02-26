namespace Exercicio_Aula_4
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAnoatual = new System.Windows.Forms.TextBox();
            this.txtNascimento = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblAnoatual = new System.Windows.Forms.Label();
            this.lblAnonascimento = new System.Windows.Forms.Label();
            this.btnIdade = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtRaio = new System.Windows.Forms.TextBox();
            this.btnArea = new System.Windows.Forms.Button();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblRaio = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblXum = new System.Windows.Forms.Label();
            this.lblXdois = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.txtAnoatual);
            this.panel1.Controls.Add(this.txtNascimento);
            this.panel1.Controls.Add(this.lblIdade);
            this.panel1.Controls.Add(this.lblAnoatual);
            this.panel1.Controls.Add(this.lblAnonascimento);
            this.panel1.Controls.Add(this.btnIdade);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 142);
            this.panel1.TabIndex = 0;
            // 
            // txtAnoatual
            // 
            this.txtAnoatual.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnoatual.Location = new System.Drawing.Point(143, 81);
            this.txtAnoatual.Name = "txtAnoatual";
            this.txtAnoatual.Size = new System.Drawing.Size(100, 27);
            this.txtAnoatual.TabIndex = 5;
            // 
            // txtNascimento
            // 
            this.txtNascimento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNascimento.Location = new System.Drawing.Point(143, 27);
            this.txtNascimento.Name = "txtNascimento";
            this.txtNascimento.Size = new System.Drawing.Size(100, 27);
            this.txtNascimento.TabIndex = 4;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.Location = new System.Drawing.Point(303, 50);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(65, 20);
            this.lblIdade.TabIndex = 3;
            this.lblIdade.Text = "Idade = ";
            // 
            // lblAnoatual
            // 
            this.lblAnoatual.AutoSize = true;
            this.lblAnoatual.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnoatual.Location = new System.Drawing.Point(62, 84);
            this.lblAnoatual.Name = "lblAnoatual";
            this.lblAnoatual.Size = new System.Drawing.Size(75, 20);
            this.lblAnoatual.TabIndex = 2;
            this.lblAnoatual.Text = "Ano Atual";
            // 
            // lblAnonascimento
            // 
            this.lblAnonascimento.AutoSize = true;
            this.lblAnonascimento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnonascimento.Location = new System.Drawing.Point(18, 27);
            this.lblAnonascimento.Name = "lblAnonascimento";
            this.lblAnonascimento.Size = new System.Drawing.Size(119, 20);
            this.lblAnonascimento.TabIndex = 1;
            this.lblAnonascimento.Text = "Ano Nascimento";
            // 
            // btnIdade
            // 
            this.btnIdade.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdade.Location = new System.Drawing.Point(475, 88);
            this.btnIdade.Name = "btnIdade";
            this.btnIdade.Size = new System.Drawing.Size(75, 30);
            this.btnIdade.TabIndex = 0;
            this.btnIdade.Text = "idade";
            this.btnIdade.UseVisualStyleBackColor = true;
            this.btnIdade.Click += new System.EventHandler(this.btnIdade_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.txtRaio);
            this.panel2.Controls.Add(this.btnArea);
            this.panel2.Controls.Add(this.lblArea);
            this.panel2.Controls.Add(this.lblRaio);
            this.panel2.Location = new System.Drawing.Point(0, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 123);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtRaio
            // 
            this.txtRaio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRaio.Location = new System.Drawing.Point(39, 78);
            this.txtRaio.Name = "txtRaio";
            this.txtRaio.Size = new System.Drawing.Size(100, 25);
            this.txtRaio.TabIndex = 3;
            // 
            // btnArea
            // 
            this.btnArea.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArea.Location = new System.Drawing.Point(475, 87);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(75, 33);
            this.btnArea.TabIndex = 2;
            this.btnArea.Text = "Area";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(333, 41);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(47, 17);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "área =";
            // 
            // lblRaio
            // 
            this.lblRaio.AutoSize = true;
            this.lblRaio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaio.Location = new System.Drawing.Point(36, 41);
            this.lblRaio.Name = "lblRaio";
            this.lblRaio.Size = new System.Drawing.Size(84, 17);
            this.lblRaio.TabIndex = 0;
            this.lblRaio.Text = "valor do raio";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Lime;
            this.panel3.Controls.Add(this.btnCalcula);
            this.panel3.Controls.Add(this.txtC);
            this.panel3.Controls.Add(this.txtB);
            this.panel3.Controls.Add(this.txtA);
            this.panel3.Controls.Add(this.lblXdois);
            this.panel3.Controls.Add(this.lblXum);
            this.panel3.Controls.Add(this.lblC);
            this.panel3.Controls.Add(this.lblB);
            this.panel3.Controls.Add(this.lblA);
            this.panel3.Location = new System.Drawing.Point(0, 277);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(576, 164);
            this.panel3.TabIndex = 0;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(52, 28);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(16, 17);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "A";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(52, 75);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(15, 17);
            this.lblB.TabIndex = 1;
            this.lblB.Text = "B";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(51, 125);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(16, 17);
            this.lblC.TabIndex = 2;
            this.lblC.Text = "C";
            // 
            // lblXum
            // 
            this.lblXum.AutoSize = true;
            this.lblXum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXum.Location = new System.Drawing.Point(437, 23);
            this.lblXum.Name = "lblXum";
            this.lblXum.Size = new System.Drawing.Size(23, 17);
            this.lblXum.TabIndex = 3;
            this.lblXum.Text = "X1";
            // 
            // lblXdois
            // 
            this.lblXdois.AutoSize = true;
            this.lblXdois.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXdois.Location = new System.Drawing.Point(437, 104);
            this.lblXdois.Name = "lblXdois";
            this.lblXdois.Size = new System.Drawing.Size(23, 17);
            this.lblXdois.TabIndex = 4;
            this.lblXdois.Text = "X2";
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(85, 20);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 25);
            this.txtA.TabIndex = 5;
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(85, 67);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 25);
            this.txtB.TabIndex = 6;
            // 
            // txtC
            // 
            this.txtC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.Location = new System.Drawing.Point(85, 117);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 25);
            this.txtC.TabIndex = 7;
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(293, 67);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(75, 23);
            this.btnCalcula.TabIndex = 8;
            this.btnCalcula.Text = "Calcula";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 443);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAnoatual;
        private System.Windows.Forms.TextBox txtNascimento;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblAnoatual;
        private System.Windows.Forms.Label lblAnonascimento;
        private System.Windows.Forms.Button btnIdade;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtRaio;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblRaio;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblXdois;
        private System.Windows.Forms.Label lblXum;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Button btnCalcula;
    }
}

