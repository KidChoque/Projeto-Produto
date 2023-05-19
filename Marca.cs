using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Produtos_Sprint_3
{
    public class Marca
    {
        public int Codigo { get; set; }
        public string NomeMarca { get; set; }
        public DateTime DataCadastro = DateTime.Now;
        public static List<Marca> marcas = new List<Marca>();


        public Marca()
        {

        }
        public Marca(int codigo, string nomeMarca, DateTime DataCadastro)
        {
            Codigo = codigo;
            NomeMarca = nomeMarca;
            DataCadastro = DateTime.Now;
        }

        public void Cadastrar()
        {
            Console.WriteLine($"Qual o código da marca?");
            Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Qual o nome da marca");
            NomeMarca = Console.ReadLine();

            Console.WriteLine($"Data de cadastro da marca = {DataCadastro}");

            marcas.Add(new Marca(Codigo, NomeMarca, DataCadastro));

        }

        public void Listar()
        {
            Console.WriteLine($"Lista de marcas");
            foreach (var m in marcas)
            {
                Console.WriteLine($"");
                Console.WriteLine($"Marca: {m.NomeMarca}");
                Console.WriteLine($"Codigo: {m.Codigo}");
                Console.WriteLine($"Data de cadastro: {m.DataCadastro}");
            }
        }
        public string Deletar()
        {
            Console.WriteLine($"Digite Código da marca a ser deletada :");
            Codigo = int.Parse(Console.ReadLine());

            Marca marcaEncontrada = marcas.Find(x => x.Codigo == Codigo);
            int index = marcas.IndexOf(marcaEncontrada);

            Console.WriteLine($"O índice da marca {Codigo} é {index} ");




            marcas.RemoveAt(index);
            return "Marca Deletada";
        }


    }
}