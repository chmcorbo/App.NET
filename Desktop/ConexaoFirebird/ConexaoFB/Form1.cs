using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sigleton.Conexao;

namespace ConexaoFB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SigletonConexaoFB.Strcnx = "User=SYSDBA;Password=masterkey;Database=LOCALHOST:G:\\SINAPSE\\BANCO DE DADOS\\FIREBIRD\\ADMINISTRACAO\\SINAPSE.FDB;DataSource=LOCAL;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=10;Pooling=False;Packet Size=8192;Server Type=0";
                SigletonConexaoFB.getConexao().Open();
                MessageBox.Show("Conexão feita com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na conexão: " + ex.Message);
            }
            finally
            {
                SigletonConexaoFB.getConexao().Close();
            }
        }
    }
}
