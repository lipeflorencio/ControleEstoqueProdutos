using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entities
{
    public class Funcionario
    {
        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        public Funcionario()
        {

        }

        public Funcionario( int idFuncionario, string nome, string matricula, string login, string senha )
        {
            IdFuncionario = idFuncionario;
            Nome = nome;
            Matricula = matricula;
            Login = login;
            Senha = senha;
        }

        public override string ToString()
        {
            return $"Id: {IdFuncionario}, Nome: {Nome}, Matrícula: {Matricula}, Login: {Login}";
        }
    }
}
