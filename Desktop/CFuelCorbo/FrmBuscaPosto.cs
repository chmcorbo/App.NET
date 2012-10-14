using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CFuelCorboLib.dao;
using CFuelCorboLib.dominio;
using System.Configuration;

namespace CFuelCorbo
{
    public partial class FrmBuscaPosto : FormsBase.Consultas.FrmBuscaBase
    {
        DAOPosto daoPosto = new DAOPosto(ConfigurationSettings.AppSettings["caminho"].ToString() + @"\posto.xml");
        List<Posto> lista;

        public FrmBuscaPosto()
        {
            InitializeComponent();
        }

        protected override void Pesquisar()
        {
            lstPesquisa.Items.Clear();
            if (txtPesquisa.Text == String.Empty)
                lista = daoPosto.listar();
            else
                lista = daoPosto.listar(txtPesquisa.Text);

            if (lista != null)
            {
                ListViewItem item;
                foreach (Posto posto in lista)
                {
                    item = new ListViewItem();
                    item.Text = posto.ID.ToString();
                    item.SubItems.Add(posto.nome);
                    lstPesquisa.Items.Add(item);
                }
            }
            base.Pesquisar();
        }

        protected override void frmPesquisaBase_Load(object sender, EventArgs e)
        {
            base.frmPesquisaBase_Load(sender, e);
        }

    }
}
