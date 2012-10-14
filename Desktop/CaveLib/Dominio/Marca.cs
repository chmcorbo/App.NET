/// <summary>
/// Summary description for Marca
/// </summary>
/// 

namespace cave.dominio
{
    using System;
    using solucon.dominio;

    public class Marca
    {
        //Properties
        public String Descricao { get; set; }
        // Métodos
        public Marca()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }

    public class Modelo
    {
        // Fields
        private Marca _marca;

        //Properties
        public String Descricao { get; set; }
        public Marca Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }

        // Métodos
        public Modelo()
        {
            _marca = new Marca();
        }
    }
}