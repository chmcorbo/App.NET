using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CFuelCorbo
{
    using CFuelCorboLib.dominio;
    using CFuelCorboLib.dao;
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //String caminho = System.Configuration.DefaultSettingValueAttribute["Caminho"].ToString;
            /*
                DAOPosto daoPosto = new DAOPosto(@"G:\App\VSCNET\Desktop\CFuelCorbo\app_data\");
                List<Posto> listaPostos = daoPosto.listar();
                comboBox1.Items.Add(listaPostos[0]);
                comboBox1.Items.Add(listaPostos[1]);
            */
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void veículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadVeiculo frmCadVeiculo = new FrmCadVeiculo();
            frmCadVeiculo.ShowDialog();
        }

        private void postoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscaPosto frmBuscaPosto = new FrmBuscaPosto();
            frmBuscaPosto.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mySqlConnection1.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mySqlConnection1.Close();
        }
    }
}
