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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void miConsEquipe_Click(object sender, EventArgs e)
        {
            FrmConsEquipe frmconsEquipe = new FrmConsEquipe();
            frmconsEquipe.ShowDialog();

        }

        private void miSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_ParentChanged(object sender, EventArgs e)
        {

        }

        private void miConsMaterial_Click(object sender, EventArgs e)
        {
            FrmConsMaterial frmconsMaterial = new FrmConsMaterial();
            frmconsMaterial.ShowDialog();

        }
    }
}