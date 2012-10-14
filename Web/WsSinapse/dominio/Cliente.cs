using System;
using simples;

namespace WsSinapse.dominio
{
    public class Cliente : ClasseBase
    {
        //fields
        private int cod_cliente;
        private String fantasia;
        private String razao_social;
        private int situacao;
        //Properties
        public int Cod_cliente
        {
            get { return cod_cliente; }
            set { cod_cliente = value; }
        }
        public String Fantasia
        {
            get { return fantasia; }
            set { fantasia = value; }
        }
        public String Razao_social
        {
            get { return razao_social; }
            set { razao_social = value; }
        }

        public int Situacao
        {
            get { return situacao; }
            set { situacao = value; }
        }

    }
}
