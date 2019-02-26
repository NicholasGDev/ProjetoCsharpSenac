using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSimples
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Criando variáveis
            double num1, num2,resp;
            
            // Convertendo variáveis
            num1 = Double.Parse(txtVariavel1.Text);
            num2 = Double.Parse(txtVariavel2.Text);


            // estrutura de decisão

            if (rdbAdicao.Checked)
            {
                // somando
                resp = num1 + num2;

                // Resultado
                lblResultado.Text = resp.ToString();
            }

            if (rdbSubtracao.Checked)
            {
                //subtraindo
                resp = num1 - num2;

                //Resultado
                lblResultado.Text = resp.ToString();
            }

            if (rdbMult.Checked)
            {
                //multiplicando
                resp = num1 * num2;

                //Resultado
                lblResultado.Text = resp.ToString();
            }

            if (rdbDivisao.Checked)
            {
                resp = num2 = 0;

                lblResultado.Text = resp.ToString("impossivel divisão com 0");


            }else
            {
                //dividindo
                resp = num1 / num2;

                //resultado
                lblResultado.Text = resp.ToString();

            }



        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void rdbDivisao_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
