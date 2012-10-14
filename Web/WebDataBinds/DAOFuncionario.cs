using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebDataBinds.Model;

namespace WebDataBinds.DAO
{
    public class DAOFuncionario
    {
        public DAOFuncionario()
        {

        }
        public List<Funcionario> listar()
        {
            Funcionario funcionario;
            List<Funcionario> funcionarios = new List<Funcionario>();

            funcionario = new Funcionario();
            funcionario.id = 1;
            funcionario.nome = "Rafael Silva";
            funcionario.ramal = "117";
            funcionarios.Add(funcionario);

            funcionario = new Funcionario();
            funcionario.id = 2;
            funcionario.nome = "Bruno Oliveira";
            funcionario.ramal = "122";
            funcionarios.Add(funcionario);

            funcionario = new Funcionario();
            funcionario.id = 3;
            funcionario.nome = "Ricardo Seoldo";
            funcionario.ramal = "118";
            funcionarios.Add(funcionario);

            funcionario = new Funcionario();
            funcionario.id = 4;
            funcionario.nome = "Ricardo Coelho";
            funcionario.ramal = "119";
            funcionarios.Add(funcionario);

            funcionario = new Funcionario();
            funcionario.id = 5;
            funcionario.nome = "Anderson Dutra";
            funcionario.ramal = "121";
            funcionarios.Add(funcionario);

            return funcionarios;
        }
    }
}
