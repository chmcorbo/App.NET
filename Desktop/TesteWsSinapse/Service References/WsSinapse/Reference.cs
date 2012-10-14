﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TesteWsSinapse.WsSinapse {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.sinapseinformatica.com.br/", ConfigurationName="WsSinapse.WsEstarSoap")]
    public interface WsEstarSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.sinapseinformatica.com.br/StringConexao", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        string StringConexao(string senha_master);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.sinapseinformatica.com.br/Sobre", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        string Sobre();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.sinapseinformatica.com.br/RegistroAniel", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ClasseBase))]
        TesteWsSinapse.WsSinapse.HistAtualizReg RegistroAniel(string senha_master, int id_licenca_cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.sinapseinformatica.com.br/AtualizHistRegAniel", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ClasseBase))]
        bool AtualizHistRegAniel(string senha_master, int id_atualiz_reg, string usuario_aniel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.sinapseinformatica.com.br/Cons_Equipe", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ClasseBase))]
        TesteWsSinapse.WsSinapse.Equipe Cons_Equipe(string senha_master, string Cod_Equipe);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.sinapseinformatica.com.br/Cons_Produto", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ClasseBase))]
        TesteWsSinapse.WsSinapse.Produto Cons_Produto(string senha_master, string Codmat);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sinapseinformatica.com.br/")]
    public partial class HistAtualizReg : ClasseBase {
        
        private int idField;
        
        private Licenca_cliente licenca_clienteField;
        
        private System.DateTime data_envioField;
        
        private int qtde_licencaField;
        
        private System.DateTime liberado_ateField;
        
        private string versao_anielField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("Id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public Licenca_cliente Licenca_cliente {
            get {
                return this.licenca_clienteField;
            }
            set {
                this.licenca_clienteField = value;
                this.RaisePropertyChanged("Licenca_cliente");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public System.DateTime Data_envio {
            get {
                return this.data_envioField;
            }
            set {
                this.data_envioField = value;
                this.RaisePropertyChanged("Data_envio");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public int Qtde_licenca {
            get {
                return this.qtde_licencaField;
            }
            set {
                this.qtde_licencaField = value;
                this.RaisePropertyChanged("Qtde_licenca");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public System.DateTime Liberado_ate {
            get {
                return this.liberado_ateField;
            }
            set {
                this.liberado_ateField = value;
                this.RaisePropertyChanged("Liberado_ate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string Versao_aniel {
            get {
                return this.versao_anielField;
            }
            set {
                this.versao_anielField = value;
                this.RaisePropertyChanged("Versao_aniel");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sinapseinformatica.com.br/")]
    public partial class Licenca_cliente : ClasseBase {
        
        private int idField;
        
        private Cliente clienteField;
        
        private System.DateTime data_vendaField;
        
        private System.DateTime inicio_suporteField;
        
        private System.DateTime data_criacao_bdField;
        
        private int situacaoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("Id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public Cliente Cliente {
            get {
                return this.clienteField;
            }
            set {
                this.clienteField = value;
                this.RaisePropertyChanged("Cliente");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public System.DateTime Data_venda {
            get {
                return this.data_vendaField;
            }
            set {
                this.data_vendaField = value;
                this.RaisePropertyChanged("Data_venda");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public System.DateTime Inicio_suporte {
            get {
                return this.inicio_suporteField;
            }
            set {
                this.inicio_suporteField = value;
                this.RaisePropertyChanged("Inicio_suporte");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public System.DateTime Data_criacao_bd {
            get {
                return this.data_criacao_bdField;
            }
            set {
                this.data_criacao_bdField = value;
                this.RaisePropertyChanged("Data_criacao_bd");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public int Situacao {
            get {
                return this.situacaoField;
            }
            set {
                this.situacaoField = value;
                this.RaisePropertyChanged("Situacao");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sinapseinformatica.com.br/")]
    public partial class Cliente : ClasseBase {
        
        private int cod_clienteField;
        
        private string fantasiaField;
        
        private string razao_socialField;
        
        private int situacaoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int Cod_cliente {
            get {
                return this.cod_clienteField;
            }
            set {
                this.cod_clienteField = value;
                this.RaisePropertyChanged("Cod_cliente");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Fantasia {
            get {
                return this.fantasiaField;
            }
            set {
                this.fantasiaField = value;
                this.RaisePropertyChanged("Fantasia");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Razao_social {
            get {
                return this.razao_socialField;
            }
            set {
                this.razao_socialField = value;
                this.RaisePropertyChanged("Razao_social");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public int Situacao {
            get {
                return this.situacaoField;
            }
            set {
                this.situacaoField = value;
                this.RaisePropertyChanged("Situacao");
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Produto))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Perfil_Equipe))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Equipe))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Cliente))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Licenca_cliente))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HistAtualizReg))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sinapseinformatica.com.br/")]
    public abstract partial class ClasseBase : object, System.ComponentModel.INotifyPropertyChanged {
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sinapseinformatica.com.br/")]
    public partial class Produto : ClasseBase {
        
        private string codmatField;
        
        private string descricaoField;
        
        private string unidField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Codmat {
            get {
                return this.codmatField;
            }
            set {
                this.codmatField = value;
                this.RaisePropertyChanged("Codmat");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Descricao {
            get {
                return this.descricaoField;
            }
            set {
                this.descricaoField = value;
                this.RaisePropertyChanged("Descricao");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Unid {
            get {
                return this.unidField;
            }
            set {
                this.unidField = value;
                this.RaisePropertyChanged("Unid");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sinapseinformatica.com.br/")]
    public partial class Perfil_Equipe : ClasseBase {
        
        private int cod_Perfil_EquipeField;
        
        private string nomeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int Cod_Perfil_Equipe {
            get {
                return this.cod_Perfil_EquipeField;
            }
            set {
                this.cod_Perfil_EquipeField = value;
                this.RaisePropertyChanged("Cod_Perfil_Equipe");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Nome {
            get {
                return this.nomeField;
            }
            set {
                this.nomeField = value;
                this.RaisePropertyChanged("Nome");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sinapseinformatica.com.br/")]
    public partial class Equipe : ClasseBase {
        
        private string cod_EquipeField;
        
        private string nomeField;
        
        private Perfil_Equipe perfilField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Cod_Equipe {
            get {
                return this.cod_EquipeField;
            }
            set {
                this.cod_EquipeField = value;
                this.RaisePropertyChanged("Cod_Equipe");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Nome {
            get {
                return this.nomeField;
            }
            set {
                this.nomeField = value;
                this.RaisePropertyChanged("Nome");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public Perfil_Equipe Perfil {
            get {
                return this.perfilField;
            }
            set {
                this.perfilField = value;
                this.RaisePropertyChanged("Perfil");
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface WsEstarSoapChannel : TesteWsSinapse.WsSinapse.WsEstarSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class WsEstarSoapClient : System.ServiceModel.ClientBase<TesteWsSinapse.WsSinapse.WsEstarSoap>, TesteWsSinapse.WsSinapse.WsEstarSoap {
        
        public WsEstarSoapClient() {
        }
        
        public WsEstarSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WsEstarSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WsEstarSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WsEstarSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string StringConexao(string senha_master) {
            return base.Channel.StringConexao(senha_master);
        }
        
        public string Sobre() {
            return base.Channel.Sobre();
        }
        
        public TesteWsSinapse.WsSinapse.HistAtualizReg RegistroAniel(string senha_master, int id_licenca_cliente) {
            return base.Channel.RegistroAniel(senha_master, id_licenca_cliente);
        }
        
        public bool AtualizHistRegAniel(string senha_master, int id_atualiz_reg, string usuario_aniel) {
            return base.Channel.AtualizHistRegAniel(senha_master, id_atualiz_reg, usuario_aniel);
        }
        
        public TesteWsSinapse.WsSinapse.Equipe Cons_Equipe(string senha_master, string Cod_Equipe) {
            return base.Channel.Cons_Equipe(senha_master, Cod_Equipe);
        }
        
        public TesteWsSinapse.WsSinapse.Produto Cons_Produto(string senha_master, string Codmat) {
            return base.Channel.Cons_Produto(senha_master, Codmat);
        }
    }
}
