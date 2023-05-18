using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Produtos_Sprint_3
{
    public class Marca
    {
        public int Codigo {get;set;}
        public string NomeMarca {get;set;}
        public DateTime DataCadastro = DateTime.Now;
        public List<Marca> marcas = new List<Marca>();

        public Marca(int codigo , string nomeMarca)
        {
            Codigo = codigo;
            NomeMarca = nomeMarca;
        }

        public void Cadastrar()
        {
          Console.WriteLine($"Qual o código da marca?");
          Codigo = int.Parse(Console.ReadLine());
          
          Console.WriteLine($"Qual o nome da marca");
          NomeMarca = Console.ReadLine();
          
          Console.WriteLine($"Data de cadastro da marca = {DataCadastro}");

          marcas.Add(new Marca(Codigo,NomeMarca));
          
        } 

        public void Listar()
        {
          Console.WriteLine($"Lista de marcas");
          foreach (var m in marcas)
          {
            Console.WriteLine($"Marca: {m.NomeMarca}");
            Console.WriteLine($"Codigo: {m.Codigo}");
          }
        }

        
    }
}