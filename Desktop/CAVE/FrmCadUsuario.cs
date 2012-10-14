using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cave.dominio;
using cave.DAO;

namespace CAVE
{
    public partial class FrmCadUsuario : Form
    {
        private Usuario usuario = new Usuario();
        private DAOUsuario daoUsuario = new DAOUsuario();
        private DAOPerfilUsuario daoPerfilUsuario = new DAOPerfilUsuario();
        public FrmCadUsuario()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            usuario.Login = txbLogin.Text;
            usuario.Nome = txbNome.Text;
            usuario.Senha = txbSenha.Text;
            // usuario.perfil.ID = cbPerfil.SelectedItem.ToString();
            usuario.Ativo = cbAtivo.Text.Substring(0,1);

        }

        private void FrmCadUsuario_Load(object sender, EventArgs e)
        {
            cbPerfil.DataSource = daoPerfilUsuario.ListarTudo();
        }


    }
}
