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
            scInserindo, scNavegando, scEditando
        }

        public StatusCadastro sStatus;
        public int _nCdGenerico;

        public FrmCadBase()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmBase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void LimpaControles()
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

        public virtual bool Salvar()
        {
            return false;
        }

        public virtual bool Excluir()
        {
            return false;
        }

        public virtual bool Localizar()
        {
            return false;
        }

        public virtual void CarregaValores()
        {

        }

        private void HabilitaDesabilitaControles(bool bValue)
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Salvar())
            {
                sStatus = StatusCadastro.scNavegando;
                LimpaControles();
                HabilitaDesabilitaControles(false);
                MessageBox.Show("Gravação realizada com sucesso.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Erro na gravação do registro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o registro?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            else
            {
                if (Excluir())
                {
                    sStatus = StatusCadastro.scNavegando;
                    LimpaControles();
                    HabilitaDesabilitaControles(false);
                    MessageBox.Show("Registro excluído com sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Registro não excluído! Entre em contato com o administrador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            sStatus = StatusCadastro.scInserindo;
            LimpaControles();
            HabilitaDesabilitaControles(true);
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            if (Localizar())
            {
                sStatus = StatusCadastro.scEditando;
                HabilitaDesabilitaControles(true);
                CarregaValores();
            }
        }

        private void frmBase_Load(object sender, EventArgs e)
        {
            sStatus = StatusCadastro.scNavegando;
            LimpaControles();
            HabilitaDesabilitaControles(false);
        }
    }
}
