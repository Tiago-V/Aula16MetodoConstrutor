using System;

namespace Exercício_16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sem instâncias
            Produto nonep = new Produto();

            //Uma instância...
            Produto nomeproduto = new Produto("Fly By Low 2");

            Console.WriteLine("Nome do tênis: "+nomeproduto.Nome);

            Console.WriteLine();

            //Três instâncias...
            Produto sobreproduto = new Produto("Fly By Low 2", "Nike", "Basquete");

            //Console.WriteLine("Insira o nome do tênis: ");
            //nomeproduto.Nome = Console.ReadLine();

            //Console.WriteLine("Insira a marca do tênis: ");
            //nomeproduto.Marca = Console.ReadLine();

            //Console.WriteLine("Insira o modelo do tênis: ");
            //nomeproduto.Modelo = Console.ReadLine();

            //Console.WriteLine();

            Console.WriteLine($"Nome: {sobreproduto.Nome}\nMarca: {sobreproduto.Marca}\nModelo: {sobreproduto.Modelo}");

            Console.WriteLine();

            //Todas as instâncias...
            Produto infoproduto = new Produto("Fly By Low 2", "Nike", "Basquete", 43, 55);

            Console.WriteLine($"Nome: {infoproduto.Nome}\nMarca: {infoproduto.Marca}\nModelo: {infoproduto.Modelo}\nTamanho: {infoproduto.Tamanho}\nEstoque: {infoproduto.Qestoque}");

        }
    }
}
