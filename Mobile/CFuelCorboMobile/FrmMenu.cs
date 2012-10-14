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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void miSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?",
                  "Confirmação", MessageBoxButtons.YesNo, 
                  MessageBoxIcon.Question,
                  MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                Application.Exit();
        }
    }
}