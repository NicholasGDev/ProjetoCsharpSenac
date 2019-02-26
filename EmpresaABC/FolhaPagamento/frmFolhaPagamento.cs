using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolhaPagamento
{
    public partial class frmFolhaPagamento : Form
    {
        //criando variaveis
        double salario, resul,resulf;

        public frmFolhaPagamento()
        {
            InitializeComponent();
            carregaCombo();
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {

        }

        private void cboClubedelazer_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //convertendo variaveis
            salario = Convert.ToDouble(txtSalario.Text);
            if (cboClubedelazer.SelectedIndex == 0)
            {
                resul = salario - 100;
                txtSalariofolha.Text = String.Format("{0 :c}", resul);
            }
            if ((cboClubedelazer.SelectedIndex == 0) && (ckbPlanSaude.Checked))
            {
                resul = salario - 100;
                resulf = resul - 150;
                txtSalariofolha.Text = String.Format("{0 :c}", resulf);
            }
            if (cboClubedelazer.SelectedIndex == 1)
            {
                resul = salario - 50;
                txtSalariofolha.Text = String.Format("{0 :c}", resul);
            }
            if ((cboClubedelazer.SelectedIndex == 1) && (ckbPlanSaude.Checked))
            {
                resul = salario - 50;
                resulf = resul - 150;
                txtSalariofolha.Text = String.Format("{0 :c}", resulf);
            }
            if (cboClubedelazer.SelectedIndex == 2)
            {
                resul = salario - 10;
                txtSalariofolha.Text = String.Format("{0 :c}", resul);
            }
            if ((cboClubedelazer.SelectedIndex == 2) && (ckbPlanSaude.Checked))
            {
                resul = salario - 10;
                resulf = resul - 150;
                txtSalariofolha.Text = String.Format("{0 :c}", resulf);
            }





        }

        private void frmFolhaPagamento_Load(object sender, EventArgs e)
        {

        }

        public void carregaCombo()
        {
            cboClubedelazer.Items.Clear();
            cboClubedelazer.Items.Add("Clube A - R$ 100,00");
            cboClubedelazer.Items.Add("Clube B - R$ 50,00");
            cboClubedelazer.Items.Add("Clube C - R$ 10,00");

        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {
            
            //convertendo variaveis
            salario = Convert.ToDouble(txtSalario.Text);
            //resultado
            txtSalariofolha.Text = String.Format("{0 :c}", salario);
        }

        private void ckbPlanSaude_CheckedChanged(object sender, EventArgs e)
        {
            
            //convertendo variaveis
            salario = Convert.ToDouble(txtSalario.Text);
            //resultados
            if (ckbPlanSaude.Checked)
            {
                resul = salario - 150.00;
                txtSalariofolha.Text = String.Format("{0 :c}", resul);
            }
            else
            {
                txtSalariofolha.Text = String.Format("{0 :c}", salario);
            }
        }
    }
}
