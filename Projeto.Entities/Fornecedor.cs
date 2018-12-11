using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entities
{
    public class Fornecedor
    {
        public int IdFornecedor { get; set; }
        public string Nome { get; set; }
        //TEM-MUITOS
        public List<Produto> Produtos { get; set; }

        public Fornecedor()
        {

        }

        public Fornecedor( int idFornecedor, string nome )
        {
            IdFornecedor = idFornecedor;
            Nome = nome;
        }

        public Fornecedor( int idFornecedor, string nome, List<Produto> produtos ) 
            : this( idFornecedor, nome )
        {
            Produtos = produtos;
        }

        public override string ToString()
        {
            return $"Id: {IdFornecedor}, Nome: {Nome}";
        }
    }
}
