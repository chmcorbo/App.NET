﻿namespace CFuelCorboLib.dominio
{
    using System;
    using CorboUtils.Dominio;

    public class Veiculo : ClasseBase
    {
        #region Properties
        public String placa { get; set; }
        public String marca { get; set; }
        public String modelo { get; set; }
        public String cor { get; set; }
        public String renavan { get; set; }
        #endregion
    }
}
