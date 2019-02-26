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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // criando variaveis
            double nsalario, salario;
            // convertendo as variaveis
            salario = Convert.ToDouble(textBox1.Text);
            // calculando
            nsalario = salario + (salario * 5 / 100);
            //resultado
            lblRsalario.Text = String.Format("{0:c}", nsalario);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // criando variaveis
            double nsalario, salario;
            // convertendo as variaveis
            salario = Convert.ToDouble(textBox1.Text);
            // calculando
            nsalario = salario + (salario * 10 / 100);
            //resultado
            lblRsalario.Text = String.Format("{0:c}", nsalario);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // criando variaveis
            double nsalario, salario;
            // convertendo as variaveis
            salario = Convert.ToDouble(textBox1.Text);
            // calculando
            nsalario = salario + (salario * 15 / 100);
            //resultado
            lblRsalario.Text = String.Format("{0:c}", nsalario);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // criando variaveis
            double nsalario, salario;
            // convertendo as variaveis
            salario = Convert.ToDouble(textBox1.Text);
            // calculando
            nsalario = salario + (salario * 20 / 100);
            //resultado
            lblRsalario.Text = String.Format("{0:c}", nsalario);
        }
    }
}
