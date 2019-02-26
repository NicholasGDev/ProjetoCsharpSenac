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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIdade_Click(object sender, EventArgs e)
        {
            //criando variaveis

            double num1, num2, idade;

            //convertendo variaveis

            num1 = Convert.ToDouble(txtNascimento.Text);
            num2 = Convert.ToDouble(txtAnoatual.Text);

            //subtraindo

            idade = num2 - num1;

            //resultado
            lblIdade.Text = String.Format("{0} - {1} = {2}", num1, num2, idade);
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            // criando váriaveis

            double num1, num2, resul;
            num2 = Math.PI;
            // convertendo variaveis
            num1 = Convert.ToDouble(txtRaio.Text);
            // conta
            resul = num2 *(num1 * num1);
            // resultado
            lblArea.Text = resul.ToString();



        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            // criando variaveis:
            double a, b, c, delta, rdelta, x1, x2;
            // convertendo variaveis:
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            c = Convert.ToDouble(txtC.Text);
            // calculo
            delta = b * b - 4 * a * c;
            rdelta = Math.Sqrt(delta);
           
            x1 = (-b + rdelta) / 2 * a;
            x2 = (-b - rdelta) / 2 * a;

            // resultado

            lblXum.Text = x1.ToString();
            lblXdois.Text = x2.ToString();








        }
    }
}
