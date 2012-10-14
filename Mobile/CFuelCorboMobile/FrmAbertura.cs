using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CFuelCorboMobile
{
    public partial class FrmAbertura : Form
    {
        public FrmAbertura()
        {
            InitializeComponent();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.ToUpper() == "HENRIQUE" &&
                txtSenha.Text.ToUpper() == "CHMC")
            {
                FrmMenu frmMenu = new FrmMenu();
                frmMenu.ShowDialog();
            }
            else
            {
                MessageBox.Show("O usuário ou senha não são válidos.", "Informação");
            }
                
        }
    }
}