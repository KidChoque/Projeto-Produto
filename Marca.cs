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
        public DateTime DataCadastro {get;set;}
        public List<Marca> ListaMarca {get;set;}

        public string Cadastrar(Marca marca)
        {
            marca = new Marca();

         Console.WriteLine($"Qual o codigo da marca :");
         marca.Codigo = int.Parse(Console.ReadLine());

         Console.WriteLine($"Qual o nome da marca :");
         marca.NomeMarca = Console.ReadLine();

         return "Marca Cadastrada";
        }

        public List<Marca> Listar()
        {
            
        }
    }
}