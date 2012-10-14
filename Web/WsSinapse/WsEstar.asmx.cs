using System;
using System.ComponentModel;
using System.Web.Services;
using WsSinapse.dominio;
using WsSinapse.dao;
using Sigleton.Conexao;

namespace WsSinapse
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://www.sinapseinformatica.com.br/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WsEstar : System.Web.Services.WebService
    {

        private bool Senha_master_valida(String senha_master)
        {
            return (senha_master == "@sina1234#");
        }

        [WebMethod]
        public String StringConexao(String senha_master)
        {
            if (!Senha_master_valida(senha_master))
            {
                throw new Exception("Autenticacao invalida. ");
            }
            SigletonConexaoFB.carregaStrcnx();
            return SigletonConexaoFB.Strcnx;
        }

        [WebMethod]
        public string Sobre()
        {
            return "WebService do Estar (Sistema de Atendimento da Sinapse)";
        }
        [WebMethod]
        public HistAtualizReg RegistroAniel(String senha_master,int id_licenca_cliente)
        {
            if (!Senha_master_valida(senha_master))
            {
                throw new Exception("Autenticacao invalida. ");
            }
            
            DAOHistAtualizReg histAtualizRegDAO = new DAOHistAtualizReg();
            DAOLicenca_cliente licenca_clienteDAO = new DAOLicenca_cliente();
            DAOCliente clienteDAO = new DAOCliente();
            HistAtualizReg result = histAtualizRegDAO.buscarAtualizLicenca(id_licenca_cliente);

            licenca_clienteDAO.buscarID(result.Licenca_cliente);
            clienteDAO.buscarID(result.Licenca_cliente.Cliente);
            return result;
        }
        [WebMethod]
        public bool AtualizHistRegAniel(String senha_master,int id_atualiz_reg, String usuario_aniel)
        {
            bool resultado = false;
            if (!Senha_master_valida(senha_master))
            {
                throw new Exception("Autenticacao invalida. ");
            }
            else
            {
                DAOHistAtualizReg histAtualizRegDAO = new DAOHistAtualizReg();
                histAtualizRegDAO.AtualizHistRegAniel(id_atualiz_reg, usuario_aniel);
                resultado = true;
            }
            return resultado;
        }
        [WebMethod]
        public Equipe Cons_Equipe(String senha_master, String Cod_Equipe)
        {
            Equipe equipe;
            if (!Senha_master_valida(senha_master))
            {
                throw new Exception("Autenticacao invalida. ");
            }
            else
            {
                DAOEquipe daoEquipe = new DAOEquipe();
                equipe=daoEquipe.buscarCod_Equipe(Cod_Equipe);
            }
            return equipe;
        }
        [WebMethod]
        public Produto Cons_Produto(String senha_master, String Codmat)
        {
            Produto produto;
            if (!Senha_master_valida(senha_master))
            {
                throw new Exception("Autenticacao invalida. ");
            }
            else
            {
                DAOProduto daoProduto = new DAOProduto();
                produto = daoProduto.buscarCodmat(Codmat);
            }
            return produto;
        }

    }
}
