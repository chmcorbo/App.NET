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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                CorboLibUtils.Conexao.BD.MySQL.MySQL.carregaStrcnx();
                CorboLibUtils.Conexao.BD.MySQL.MySQL.getConexao().Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar conectar-se com o banco de dados. "+ex.Message,
                    "Erro de conexão.",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Close();
            }
            finally
            {
                CorboLibUtils.Conexao.BD.MySQL.MySQL.getConexao().Close();
            }

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
            FrmCadVeiculoTeste frmCadVeiculo = new FrmCadVeiculoTeste();
            frmCadVeiculo.ShowDialog();
        }

        private void postoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscaPosto frmBuscaPosto = new FrmBuscaPosto();
            frmBuscaPosto.ShowDialog();
        }

        private void conexãoComBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConexaoBD frmconexaoBD = new FrmConexaoBD();
            frmconexaoBD.ShowDialog();
        }

        private void arquivosDeConfiguraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConfiguracaoApp frmConfiguracaoApp = new FrmConfiguracaoApp();
            frmConfiguracaoApp.ShowDialog();

        }
    }
}
