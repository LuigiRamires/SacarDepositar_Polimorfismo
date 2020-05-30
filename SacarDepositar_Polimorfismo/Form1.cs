using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SacarDepositar_Polimorfismo
{
    public partial class frmBanco : Form
    {
        cl_ContaEspecial ce = new cl_ContaEspecial();
        cl_ContaPoupança cp = new cl_ContaPoupança();

        public frmBanco()
        {
            InitializeComponent();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            if (rdbEspecial.Checked)
            {
                ce.creditar(Convert.ToDouble(txtValor.Text));
                lblSaldoCE.Text = Convert.ToString(ce.Saldo);
            }
            else
            {
                cp.creditar(Convert.ToDouble(txtValor.Text));
                lblSaldoCP.Text = Convert.ToString(cp.Saldo);
            }
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            if (rdbEspecial.Checked)
            {
                ce.debitar(Convert.ToDouble(txtValor.Text));
                lblSaldoCE.Text = Convert.ToString(ce.Saldo);
            }
            else
            {
                cp.debitar(Convert.ToDouble(txtValor.Text));
                lblSaldoCP.Text = Convert.ToString(cp.Saldo);
            }
        }
    }
}
