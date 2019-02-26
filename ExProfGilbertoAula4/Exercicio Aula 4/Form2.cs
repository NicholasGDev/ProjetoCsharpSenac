using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_Aula_4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResul_Click(object sender, EventArgs e)
        {

        }

        private void lblMedia_Click(object sender, EventArgs e)
        {

        }

        private void lblNotaquatro_Click(object sender, EventArgs e)
        {

        }

        private void lblNotatres_Click(object sender, EventArgs e)
        {

        }

        private void lblNotadois_Click(object sender, EventArgs e)
        {

        }

        private void lblNotaum_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // criando variáveis
            double n1, n2, n3, n4,nfinal;
            // convertendo variáveis
            n1 = Convert.ToDouble(textBox1.Text);
            n2 = Convert.ToDouble(textBox2.Text);
            n3 = Convert.ToDouble(textBox3.Text);
            n4 = Convert.ToDouble(textBox4.Text);
            // calculando
            nfinal = (n1 + n2 + n3 + n4) / 4;
            // resultado
            lblResul.Text = nfinal.ToString();




        }
    }
}
