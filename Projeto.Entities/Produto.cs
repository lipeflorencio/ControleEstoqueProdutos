using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entities
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public string Descricao { get; set; }
        //TEM-UM
        public Fornecedor Fornecedor { get; set; }

        public Produto()
        {

        }

        public Produto( int idProduto, string nome, double preco, int quantidade, string descricao )
        {
            IdProduto = idProduto;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            Descricao = descricao;
        }

        public Produto( int idProduto, string nome, double preco, int quantidade, string descricao, Fornecedor fornecedor ) 
            : this( idProduto, nome, preco, quantidade, descricao )
        {
            Fornecedor = fornecedor;
        }

        public override string ToString()
        {
            return $"Id: {IdProduto}, Nome: {Nome}, Preço: {Preco}, Quantidade: {Quantidade}, Descrição: {Descricao}";
        }
    }
}
