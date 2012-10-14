using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace CFuelCorbo
{
    public partial class FrmConfiguracaoApp : Form
    {
        public FrmConfiguracaoApp()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = ConfigurationSettings.AppSettings["MySqlConnection.ConnectionString"].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //String caminho = System.Configuration.DefaultSettingValueAttribute["Caminho"].ToString;
        }
    }
}
