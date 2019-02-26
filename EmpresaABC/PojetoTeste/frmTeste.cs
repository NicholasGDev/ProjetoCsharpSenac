using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PojetoTeste
{
    public partial class frmTeste : Form
    {
        public frmTeste()
        {
            InitializeComponent();
        }

        private void btnEscolher_Click(object sender, EventArgs e)
        {

            enterEscolher();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            double resp = 0, v1 = 50, v2 = 35;

            resp = v1 + v2;

            DialogResult mensagem = MessageBox.Show("A soma de " + v1 + "+" + v2 + "=" + resp, "Escolha Valor", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3);
            if(mensagem==DialogResult.Yes)
            {
                MessageBox.Show("Você clicou sim");
            }
            if (mensagem == DialogResult.No)
            {
                MessageBox.Show("Você clicou No");
            }
            if (mensagem == DialogResult.Cancel)
            {
                MessageBox.Show("Você clicou Cancelar");
            }
        }

        public void enterEscolher()
        {
            string valor = "";


            if (txtEscolha.Text.Equals(""))
            {
                MessageBox.Show("Digite um número inteiro.");
                txtEscolha.Focus();
                txtEscolha.Clear();
            }
            else
            {

                switch (Convert.ToInt32(txtEscolha.Text))
                {
                    case 1:
                        valor = " 1";
                        break;

                    case 2:
                        valor = " 2";
                        break;

                    case 3:
                        valor = " 3";
                        break;

                    case 4:
                        valor = " 4";
                        break;

                    case 5:
                        valor = " 5";
                        break;

                    default:
                        MessageBox.Show("Escola um numero de 1 a 5.");

                        break;


                }

                if (Convert.ToInt32(txtEscolha.Text) <= 5)
                {
                    MessageBox.Show("voce digitou" + valor);
                    txtEscolha.Focus();
                    txtEscolha.Clear();
                }

            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

        }
        

        public void testeEntrar()
        {
            string nome = "Senac";

            if (txtNome.Text.Equals(nome))
            {
                MessageBox.Show("Olá, seja bem vindo.");
                txtEscolha.Focus();
                txtEscolha.Clear();
            }
            else
            {
                MessageBox.Show("Digite o nome correto.");
                txtEscolha.Focus();
                txtEscolha.Clear();

            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            testeEntrar();
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                testeEntrar();
            }
        }

        private void txtEscolha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                enterEscolher();
            }
        }
    }
}
