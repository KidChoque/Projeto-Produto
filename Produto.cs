using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Criação da classe produto.
// NomeProduto-string
// Preco-float
// DataCadastro - Datetime
// Marca - Marca - Agregado da classe marca 
// CadastradoPor - Usuario - que não existe sem o produto
// ListaDeProdutos - List<Produto.
// Métodos
// Cadastrar(Produto) - string
// Listar()-List<Produto>
// Deletar(Produto)-string

namespace Projeto_Produtos_Sprint_3
{
    public class Produto
    {
        public int Codigo {get;set;}
        public string NomeProduto {get;set;}
        public float Preco {get;set;}
        public DateTime DataCadastro {get;set;}
        public Marca Marca {get;set;}
        public Usuario CadastradoPor {get;set;}
        public List<Produto> ListaDeProdutos {get;set;}

        public string Cadastrar()
        {
            Produto produto = new Produto();

           Console.WriteLine($"Qual o nome do produto:");
           produto.NomeProduto = Console.ReadLine();

           Console.WriteLine($"Qual o preço do produto :");
           produto.Preco = float.Parse(Console.ReadLine());
           
           Console.WriteLine($"Text");
           
            

            return "Produto Cadastrado";
        }

        public List<Produto> Listar()
        {
           Console.WriteLine($"{ListaDeProdutos}");
           return ListaDeProdutos;
           
        }
         
        public string Deletar(Produto)
        {
            ListaDeProdutos.RemoveAt();
           return "Produto Deletado";
        }
    }
}