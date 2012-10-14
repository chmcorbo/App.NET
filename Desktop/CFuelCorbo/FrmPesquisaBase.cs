using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormsBase.Consultas
{
    public partial class FrmBuscaBase : Form
    {
        public Int32 _id;

        public FrmBuscaBase()
        {
            InitializeComponent();
            //inicializa variavel
            _id = 0;
        }

        protected void btnFechar_Click(object sender, EventArgs e)
        {
            Close();            
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            //preenche variavel
            if (_id == 0)
            {
                if (lstPesquisa.Focused)
                    _id = Int32.Parse(lstPesquisa.SelectedItems[0].Text);
            }
        }

        protected void lstPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _id = Int32.Parse(lstPesquisa.SelectedItems[0].Text);
            }
            catch
            {
                _id = 0;
            }
        }

        protected void lstPesquisa_DoubleClick(object sender, EventArgs e)
        {
            //preencher a variavel
            try
            {
                _id = Int32.Parse(lstPesquisa.SelectedItems[0].Text);
            }
            catch
            {
                _id = 0;
            }
            finally
            {
                Close();
                DialogResult = DialogResult.OK;
            }

        }

        protected virtual void Pesquisar()
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //pesquisar
            Pesquisar();
            //configura o texto na barra de status
            lblMensagem.Text = lstPesquisa.Items.Count + " registro(s) encontrado(s) ";
            btnOK.Enabled = (lstPesquisa.Items.Count > 0);
            if (btnOK.Enabled)
                lstPesquisa.Focus();
        }

        protected void CarregaItens(List<Object> pLista)
        {
            //limpa os registros do ListView
            lstPesquisa.Items.Clear();
            //Na formulário específico deverá se implementado o código para carregar os itens.
        }

        private void rbCodigo_Click(object sender, EventArgs e)
        {
            txtPesquisa.Focus();
        }

        private void rbDescricao_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisa.Focus();
        }

        protected virtual void frmPesquisaBase_Load(object sender, EventArgs e)
        {
            if (cbChave.Items.Count > 0)
                cbChave.SelectedIndex = 0;
        }

    }
}
