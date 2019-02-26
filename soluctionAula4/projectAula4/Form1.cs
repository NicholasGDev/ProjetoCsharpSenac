using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectAula4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            bool logica = true;
            int num = 45;
            //f garante que ele e float
            float nreal = 3.75f;
            //d ou sem d garante que ele double pois e padrão
            double nreal2 = 17.999;
            //m garante que é decimal
            decimal salario = 900.99m;

            label1.Text = "Valor Lógico: " + logica.ToString();
            //label1.Text += "\n";
            label1.Text +="\nValor inteiro: " + num.ToString();
            /* label1.Text += "\nValores reais: " + nreal.ToString() 
                 + ", " + nreal2.ToString() + " e "
                 + salario.ToString();*/
            label1.Text += String.Format(
                "\nValores reais: {0}, {1} e {2:c}",
                nreal, nreal2, salario);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Criando váriaveis
            double num1, num2, soma;
           // convertento variaveis
            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);
            //somando
            soma = num1 + num2;
            //resultado
            label2.Text = String.Format("{0} + {1} = {2}", num1, num2, soma);


            

        }

        private void btnSubtrai_Click(object sender, EventArgs e)
        {
            //criando variaveis

            double num3, num4, subtraia;

            //convertendo variaveis

            num3 = Convert.ToDouble(textBox1.Text);
            num4 = Convert.ToDouble(textBox2.Text);

            //subtraindo

            subtraia = num3 - num4;

            //resultado
            label2.Text = String.Format("{0} - {1} = {2}", num3, num4, subtraia);




        }
    }
}
