using Projeto.Business.Utils;
using Projeto.Entities;
using Projeto.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Business
{
    public class FuncionarioBusiness
    {
        public string MsgErro { get; private set; }

        //----------------------------------------------------------------------
        public bool CriarConta(Funcionario funcionario)
        {
            var repository = new FuncionarioRepository();

            try
            {
                repository.AbrirConexao();

                if ( !repository.LoginExistente( funcionario.Login ) )
                {
                    funcionario.Senha = CriptografiaUtil.GetMD5( funcionario.Senha );
                    
                    repository.Inserir( funcionario );
                }
                else
                {
                    MsgErro = $"Login {funcionario.Login} já encontra-se cadastrado, tente outro.";
                }
            }
            catch ( Exception e )
            {
                //HAFAZER: LOG4NET
                Debug.WriteLine( e.Message );

                MsgErro = "Erro ao criar conta de Funcionário.";
                return false;
            }
            finally
            {
                repository.FecharConexao();
            }

            return true;
        }
    }
}
