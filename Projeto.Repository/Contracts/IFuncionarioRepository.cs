using Projeto.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Repository.Contracts
{
    public interface IFuncionarioRepository
    {
        void Inserir( Funcionario funcionario );

        Funcionario Consultar( string login, string senha );

        bool LoginExistente( string login );
    }
}
