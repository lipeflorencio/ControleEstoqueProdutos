using Projeto.Entities;
using Projeto.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Repository.Repositories
{
    public class FuncionarioRepository
        : Conexao, IFuncionarioRepository
    {

        //----------------------------------------------------------------------
        #region funções public
        //----------------------------------------------------------------------
        public Funcionario Consultar( string login, string senha )
        {
            string sql = "SELECT * FROM FUNCIONARIO_FUNC " + 
                         "FUNC_LOGIN = @Login " +
                         "FUNC_SENHA = @Senha ";

            Command = new SqlCommand( sql, Connection );
            Command.Parameters.AddWithValue( "@Login", login );
            Command.Parameters.AddWithValue( "@Senha", senha );
            DataReader = Command.ExecuteReader();

            if(DataReader.Read())
            {
                return makeFuncionario( DataReader );
            }
            else
            {
                return null;
            }
        }
        //----------------------------------------------------------------------
        public void Inserir( Funcionario funcionario )
        {
            string sql = "INSERT INTO FUNCIONARIO(FUNC_NOME, FUNC_MATRICULA, FUNC_LOGIN, FUNC_SENHA) " +
                         "VALUES(@Nome, @Matricula, @Login, @Senha)";

            Command = new SqlCommand( sql, Connection );
            Command.Parameters.AddWithValue( "@Nome", funcionario.Nome );
            Command.Parameters.AddWithValue( "@Matricula", funcionario.Matricula );
            Command.Parameters.AddWithValue( "@Login", funcionario.Login );
            Command.Parameters.AddWithValue( "@Senha", funcionario.Senha );
            Command.ExecuteNonQuery();
        }
        //----------------------------------------------------------------------
        public bool LoginExistente( string login )
        {
            string sql = "SELECT COUNT(FUNC_LOGIN) FROM FUNCIONARIO " +
                         "WHERE FUNC_LOGIN = @Login";

            Command = new SqlCommand( sql, Connection );
            Command.Parameters.AddWithValue( "@Login", login );
            int count = Convert.ToInt32(Command.ExecuteScalar());

            return count > 0;
        }
        //----------------------------------------------------------------------
        #endregion
        //----------------------------------------------------------------------

        //----------------------------------------------------------------------
        #region funções static private
        //----------------------------------------------------------------------
        private Funcionario makeFuncionario( SqlDataReader dr )
        {
            Funcionario funcionario = new Funcionario
            {
                IdFuncionario = Convert.ToInt32(dr["FUNC_IDFUNCIONARIO"]),
                Nome          = Convert.ToString(dr["FUNC_NOME"]),
                Matricula     = Convert.ToString(dr["FUNC_MATRICULA"]),
                Login         = Convert.ToString(dr["FUNC_LOGIN"]),
                Senha         = Convert.ToString(dr["FUNC_SENHA"])
            };

            return funcionario;
        }
        //----------------------------------------------------------------------
        #endregion
        //----------------------------------------------------------------------
    }
}
