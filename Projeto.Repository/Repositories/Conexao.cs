using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Projeto.Repository.Repositories
{
    public class Conexao
    {
        public SqlConnection Connection { get; set; }
        public SqlCommand Command { get; set; }
        public SqlDataReader DataReader { get; set; }
        public SqlTransaction Transaction { get; set; }

        public void AbrirConexao()
        {
            Connection = new SqlConnection( ConfigurationManager.ConnectionStrings [ "BD_ESTOQUE" ].ConnectionString );
            Connection.Open();
        }

        public void FecharConexao()
        {
            Connection.Close();
        }
    }
}
