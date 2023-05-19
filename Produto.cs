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

        public Produtos()
        {

        }
        public Produtos(int Codigo,string NomeProduto,float Preco, DateTime DataCadastro, Marca Marca, Usuario CadastradoPor, List<Produtos> ListaDeProdutos)
        {
          Codigo = Codigo;
          NomeProduto = NomeProduto;
          Preco = Preco;
          DataCadastro = DataCadastro;
          Marca = Marca;
          CadastradoPor = CadastradoPor;
          ListaDeProdutos = ListaDeProdutos;
        }
      
      public void Cadastrar()
      {
         Produtos produto = new Produtos();

        Console.WriteLine($"Qual é o código do produto?");
       produto.Codigo = int.Parse(Console.ReadLine());

        Console.WriteLine($"Qual é o nome do produto?");
       produto.NomeProduto = Console.ReadLine();
        
        Console.WriteLine($"Qual o preço do produto?");
        produto.Preco = float.Parse(Console.ReadLine());
        
        Console.WriteLine($"Data de cadastro do produto = {produto.DataCadastro} ");


        Console.WriteLine($"Qual o código da marca do produto?");
        Marca.Codigo = int.Parse(Console.ReadLine());

       Marca marcaEncontrada = Marca.marcas.Find(x => x.Codigo == Marca.Codigo);
       int index = Marca.marcas.IndexOf(marcaEncontrada);

       Console.WriteLine($"A marca de seu produto é {marcaEncontrada.NomeMarca}");
       

        
        
        
        
      }

    }
}