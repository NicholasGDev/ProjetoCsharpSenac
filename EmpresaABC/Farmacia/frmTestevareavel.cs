using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class frmTestevareavel : Form
    {
        bool flag = false;
        public frmTestevareavel()
        {
            InitializeComponent();
        }

        private void frmTestevareavel_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //criando variaveis
            int cont;
            cont = +1;
            label1.Text = cont.ToString();
            lblMostrar.Text = "Senac Largo treze";
            lblNCOMPLETO.Text = "Turma Ti92";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flag = true;
            lblFlag.Text = flag.ToString();

        }

        private void btnFalse_Click(object sender, EventArgs e)
        {
            // criando variaveis
            int cont;
            // declarando variaveis
            cont = 0;

            // mostrando variaveis
            lblMostrar.Text = "";
            lblNCOMPLETO.Text = "";
            flag = false;
            label1.Text = cont.ToString();
            lblFlag.Text = flag.ToString();
        }
    }
}
