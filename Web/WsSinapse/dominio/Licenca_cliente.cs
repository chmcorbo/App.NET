using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using simples;

namespace WsSinapse.dominio
{
    public class Licenca_cliente : ClasseBase
    {   
        // fields;
        private int id;
        private Cliente cliente;
        private DateTime data_venda;
        private DateTime inicio_suporte;
        private DateTime data_criacao_bd;
        private int situacao;

        //Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
        public DateTime Data_venda
        {
            get { return data_venda; }
            set { data_venda = value; }
        }
        public DateTime Inicio_suporte
        {
            get { return inicio_suporte; }
            set { inicio_suporte = value; }
        }
        public DateTime Data_criacao_bd
        {
            get { return data_criacao_bd; }
            set { data_criacao_bd = value; }
        }
        public int Situacao
        {
            get { return situacao; }
            set { situacao = value; }
        }
        //Métodos
        public Licenca_cliente()
        {
            cliente = new Cliente();
        }
    }
}
