using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using simples;

namespace WsSinapse.dominio
{
    public class HistAtualizReg : ClasseBase
    {
        // fields;
        private int id;
        private Licenca_cliente licenca_cliente;
        private DateTime data_envio;
        private int qtde_licenca;
        private DateTime liberado_ate;
        private String versao_aniel;
        
        // Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public Licenca_cliente Licenca_cliente
        {
            get { return licenca_cliente; }
            set { licenca_cliente = value; }
        }
        public DateTime Data_envio
        {
            get { return data_envio; }
            set { data_envio = value; }
        }
        public int Qtde_licenca
        {
            get { return qtde_licenca; }
            set { qtde_licenca = value; }
        }
        public DateTime Liberado_ate
        {
            get { return liberado_ate; }
            set { liberado_ate = value; }
        }
        public String Versao_aniel
        {
            get { return versao_aniel; }
            set { versao_aniel = value; }
        }
        // Métodos
        public HistAtualizReg()
        {
            licenca_cliente = new Licenca_cliente();
        }
    }
}
