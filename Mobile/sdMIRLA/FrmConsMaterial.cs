using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sdMIRLA
{
    public partial class FrmConsMaterial : Form
    {
        public FrmConsMaterial()
        {
            InitializeComponent();
        }

        private void label4_ParentChanged(object sender, EventArgs e)
        {

        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            if (txbCodigo.Text == "0251-0001-7")
            {
                txbDescricao.Text = "Fio Telefônico AA-80";
                txbUnidade.Text = "Rolo";
                txbValorUnit.Text = "R$ 130,00";
            }
            else
            {
                MessageBox.Show("Material não encontrado");
            }

        }

        private void FrmConsMaterial_Load(object sender, EventArgs e)
        {
            txbCodigo.Text = "";
            txbDescricao.Text = "";
            txbUnidade.Text = "";
            txbValorUnit.Text = "";
        }
    }
}