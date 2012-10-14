using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TesteWsSinapse.WsSinapse;

namespace TesteWsSinapse
{
    public partial class FrmConsEquipe : Form
    {
        public FrmConsEquipe()
        {
            InitializeComponent();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {

            TesteWsSinapse.WsSinapse.WsEstarSoapClient ws = new WsEstarSoapClient();
            WsSinapse.Equipe equipe ;

            equipe = ws.Cons_Equipe("@sina1234#", txbEquipe.Text);

            if (equipe.Cod_Equipe != null)
            {
                txbNome.Text = equipe.Nome;
                txbPerfil.Text = equipe.Perfil.Nome;
            }
            else
            {
                MessageBox.Show("Equipe não encontrada");
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
