using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Sorveteria
{
    public partial class frmFuncionarios : Form
    {
        public frmFuncionarios()
        {
            InitializeComponent();
            City();
            Estate();
        }

        private void cboCidade_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        public void City()
        {
            cboCidade.Items.Add("Acre");
            cboCidade.Items.Add("Alagoas");
            cboCidade.Items.Add("Amapá");
            cboCidade.Items.Add("Amazonas");
            cboCidade.Items.Add("Bahia");
            cboCidade.Items.Add("Ceará");
            cboCidade.Items.Add("Brasília");
            cboCidade.Items.Add("Espírito Santo");
            cboCidade.Items.Add("Goiás");
            cboCidade.Items.Add("Maranhão");
            cboCidade.Items.Add("Mato Grosso");
            cboCidade.Items.Add("Mato Grosso do Sul");
            cboCidade.Items.Add("Minas Gerais");
            cboCidade.Items.Add("Pará");
            cboCidade.Items.Add("Paraíba");
            cboCidade.Items.Add("Paraná");
            cboCidade.Items.Add("Pernambuco");
            cboCidade.Items.Add("Piauí");
            cboCidade.Items.Add("Rio de Janeiro");
            cboCidade.Items.Add("Rio Grande do Norte");
            cboCidade.Items.Add("Rio Grande do Sul");
            cboCidade.Items.Add("Rondônia");
            cboCidade.Items.Add("Roraima");
            cboCidade.Items.Add("Santa Catarina");
            cboCidade.Items.Add("São Paulo");
            cboCidade.Items.Add("Sergipe");
            cboCidade.Items.Add("Tocantins");
        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void Estate()
        {
            cboEstado.Items.Add("AC");
            cboEstado.Items.Add("Al");
            cboEstado.Items.Add("AP");
            cboEstado.Items.Add("AM");
            cboEstado.Items.Add("BA");
            cboEstado.Items.Add("CE");
            cboEstado.Items.Add("DF");
            cboEstado.Items.Add("ES");
            cboEstado.Items.Add("GO");
            cboEstado.Items.Add("MA");
            cboEstado.Items.Add("MT");
            cboEstado.Items.Add("MS");
            cboEstado.Items.Add("MG");
            cboEstado.Items.Add("PA");
            cboEstado.Items.Add("PB");
            cboEstado.Items.Add("PR");
            cboEstado.Items.Add("PE");
            cboEstado.Items.Add("PI");
            cboEstado.Items.Add("RJ");
            cboEstado.Items.Add("RN");
            cboEstado.Items.Add("RS");
            cboEstado.Items.Add("RO");
            cboEstado.Items.Add("RR");
            cboEstado.Items.Add("SC");
            cboEstado.Items.Add("SP");
            cboEstado.Items.Add("SE");
            cboEstado.Items.Add("TO");
        }
    }
}
