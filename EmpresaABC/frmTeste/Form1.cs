using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmTeste
{
    public partial class frmEstados : Form
    {
        public frmEstados()
        {
            InitializeComponent();
        }

        private void btnCarregarEstados_Click(object sender, EventArgs e)
        {
            //
            cboEstados.Items.Clear();
            //
            cboEstados.Items.Add("São Paulos");
            cboEstados.Items.Add("Bahia");
            cboEstados.Items.Add("Rio de Janeiro");
            cboEstados.Items.Add("Acre");
            cboEstados.Items.Add("Pernambuco");
            cboEstados.Items.Add("Sergipe");
            cboEstados.Items.Add("Manaus");
        }
    }
}
