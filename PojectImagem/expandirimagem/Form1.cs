using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace expandirimagem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExpandir_Click(object sender, EventArgs e)
        {
            pictureBox1.Width += + 1;
            pictureBox1.Height += + 1;

        }

        private void btnExpandir_Click_1(object sender, EventArgs e)
        {
            //criando variaveis
            double contador;

            // convertendo variaveis
            contador = Convert.ToDouble(lblContador.Text);

            // zoom da imagem
            pictureBox1.Width += +1 ;
            pictureBox1.Height += +1;
            
            // contador
            lblContador.Text = String.Format("{0}", contador +1);
            
            

        }

        private void btnOriginal_Click(object sender, EventArgs e)
        {
            double contador;

            // convertendo variaveis
            contador = Convert.ToDouble(lblContador.Text);

            // zoom da imagem
            pictureBox1.Width = 100;
            pictureBox1.Height = 50;

            // contador
            lblContador.Text = String.Format("{0}", contador + 1);
        }

        private void btnDiminuir_Click(object sender, EventArgs e)
        {
            //criando variaveis
            double contador;

            // convertendo variaveis
            contador = Convert.ToDouble(lblContador.Text);

            // zoom da imagem
            pictureBox1.Width += -1;
            pictureBox1.Height += -1;

            // contador
            lblContador.Text = String.Format("{0}", contador + 1);
        }
    }
}
