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
    public partial class frmEstados : Form
    {
        public frmEstados()
        {
            InitializeComponent();
            carregaCombo();
            carregaLista();
        }

        private void frmEstadoscs_Load(object sender, EventArgs e)
        {
            //carregaCombo();
        }
        public void carregaCombo()
        {
            cboEstados.Items.Clear();

            cboEstados.Items.Add("São Paulo");
            cboEstados.Items.Add("Bahia");
            cboEstados.Items.Add("Sergipe");
            cboEstados.Items.Add("Pernambuco");
            cboEstados.Items.Add("Rio de Janeiro");
            cboEstados.Items.Add("Manaus");

        }

        private void btnCrrega_Click(object sender, EventArgs e)
        {
            //carregaCombo();
        }

        private void cboEstados_Click(object sender, EventArgs e)
        {

             
            
        }

        private void btnCrrega_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            //carregaLista();
        }

        public void carregaLista()
        {
            ltbListaEstado.Items.Clear();

            ltbListaEstado.Items.Add("São Paulo");
            ltbListaEstado.Items.Add("Bahia");
            ltbListaEstado.Items.Add("Sergipe");
            ltbListaEstado.Items.Add("Pernambuco");
            ltbListaEstado.Items.Add("Rio de Janeiro");
            ltbListaEstado.Items.Add("Manaus");

        }

        private void btnCarregaLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void cboEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblRecebe.Text = cboEstados.SelectedItem.ToString();
            ltbListaEstado.SelectedIndex = cboEstados.SelectedIndex;
        }

        private void ltbListaEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblListaEstado.Text = ltbListaEstado.SelectedItem.ToString();
            cboEstados.SelectedIndex = ltbListaEstado.SelectedIndex;

        }

        private void gpbSexo_Enter(object sender, EventArgs e)
        {

        }

        private void rdbMasc_CheckedChanged(object sender, EventArgs e)
        {
            lblSexo.Text = "Masculino";
        }

        private void rdbFem_CheckedChanged(object sender, EventArgs e)
        {
            lblSexo.Text = "Feminino";
        }

        private void btnEscolha_Click(object sender, EventArgs e)
        {
            if (rdbMasc.Checked)
            {
                MessageBox.Show("Você escolheu Masculino");
            }
            if (rdbFem.Checked)
            {
                MessageBox.Show("Você escolheu Feminino");
            }
        }
    }
}
