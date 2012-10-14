using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormsBase.Cadastro
{
    public partial class FrmCadBase : Form
    {
        public enum StatusCadastro
        {
            scInserindo, scNavegando, scEditando, scExcluindo
        }

        public StatusCadastro sStatus;
        public int _nCdGenerico;

        public FrmCadBase()
        {
            InitializeComponent();
        }

        protected void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected void LimpaControles()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox)
                    (ctl as TextBox).Text = "";

                if (ctl is ComboBox)
                    (ctl as ComboBox).SelectedIndex = -1;

                if (ctl is ListBox)
                    (ctl as ListBox).SelectedIndex = -1;

                if (ctl is CheckBox)
                    (ctl as CheckBox).Checked = false;

                if (ctl is RadioButton)
                    (ctl as RadioButton).Checked = false;

                if (ctl is CheckedListBox)
                {
                    foreach (ListControl item in (ctl as CheckedListBox).Items)
                        item.SelectedIndex = -1;
                }
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Salvar())
            {
                sStatus = StatusCadastro.scNavegando;
                LimpaControles();
                HabilitaControles(false);
            }
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o registro?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            else
            {
                if (Excluir())
                {
                    sStatus = StatusCadastro.scNavegando;
                    LimpaControles();
                    HabilitaControles(false);
                }
            }
        }

        protected void btnNovo_Click(object sender, EventArgs e)
        {
            Novo();
            LimpaControles();
            HabilitaControles(true);
        }

        protected void btnLocalizar_Click(object sender, EventArgs e)
        {

        }

        private void frmBase_Load(object sender, EventArgs e)
        {
            sStatus = StatusCadastro.scNavegando;
            LimpaControles();
            HabilitaControles(false);
        }

        protected virtual bool Novo()
        {
            sStatus = StatusCadastro.scInserindo;
            return false;
        }

        protected virtual bool Abrir()
        {
            if (txtID.Text == String.Empty)
                MessageBox.Show("O campo ID não foi informado",
                    "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                sStatus = StatusCadastro.scEditando;
            
            return false;
        }

        protected virtual bool Salvar()
        {
            return false;
        }

        protected virtual bool Excluir()
        {
            sStatus = StatusCadastro.scExcluindo;
            return false;
        }


        protected virtual void setData()
        {

        }

        protected virtual void getData()
        {

        }

        protected void HabilitaControles(Boolean bValue)
        {
            //percorre os controles de tela e habilita/desabilita
            foreach (Control ctl in this.Controls)
            {
                if (ctl is ToolStrip)
                    continue;

                ctl.Enabled = bValue;
            }

            //habilita os botões

            //botão Novo - vai ser habilitado somente quando for navegação
            btnNovo.Enabled = (sStatus == StatusCadastro.scNavegando);
            //botão Salvar
            btnSalvar.Enabled = (sStatus == StatusCadastro.scEditando || sStatus == StatusCadastro.scInserindo);
            btnExcluir.Enabled = (sStatus == StatusCadastro.scEditando);
            //sempre habilitar o fechar
            btnFechar.Enabled = true;
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (Abrir())
            {
                HabilitaControles(true);
                getData();
            }
        }

    }
}
