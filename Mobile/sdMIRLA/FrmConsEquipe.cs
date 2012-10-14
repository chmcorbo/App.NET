using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using sdMIRLA.WsSinapse;

namespace sdMIRLA
{
    public partial class FrmConsEquipe : Form
    {
        public FrmConsEquipe()
        {
            InitializeComponent();
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            
            WsSinapse.WsEstar ws = new WsEstar();
            WsSinapse.Equipe equipe;

            equipe=ws.Cons_Equipe("@sina1234#",txbEquipe.Text);

            if (equipe != null)
            {
                txbNome.Text = equipe.Nome;
                txbPerfil.Text = equipe.Perfil.Nome;
            }
            else
            {
                MessageBox.Show("Equipe não encontrada");
            }
        }

        private void FrmConsEquipe_Load(object sender, EventArgs e)
        {
            txbEquipe.Text = "";
            txbNome.Text = "";
            txbPerfil.Text = "";
        }

        private void miSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}