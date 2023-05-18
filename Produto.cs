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
    public class Produtos
    {
          public int Codigo {get;set;}
        public string NomeProduto {get;set;}
        public float Preco {get;set;}
        public DateTime DataCadastro = DateTime.Now;
        public Marca Marca {get;set;}
        public Usuario CadastradoPor {get;set;}
        public List<Produtos> ListaDeProdutos {get;set;}
      
      public void Cadastrar()
      {
        Console.WriteLine($"Qual é o código do produto?");
       int codigo = int.Parse(Console.ReadLine());

        Console.WriteLine($"Qual é o nome do produto?");
       string nomeProduto = Console.ReadLine();
        
        Console.WriteLine($"Qual o preço do produto?");
        float preco = float.Parse(Console.ReadLine());
        
        Console.WriteLine($"Data de cadastro do produto = {DataCadastro} ");

        Console.WriteLine($"Qual a marca do produto?");
        
        
        
      }

    }
}