using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebDataBinds.Model
{
    public class Funcionario
    {
        public Funcionario()
        {
            id = 0;
            data_cadastro = DateTime.Now.Date;
            hora_cadastro = DateTime.Now.TimeOfDay;
        }
        public Int32 id { get; set; }
        public String nome { get; set; }
        public String ramal {get; set; }
        public DateTime data_cadastro { get; set; }
        public TimeSpan hora_cadastro { get; set; }
    }
}
