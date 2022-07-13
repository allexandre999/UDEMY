using System;
using System.Globalization;


namespace Produto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            produto.Nome = Console.ReadLine();
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine(produto.ToString());
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(quantidade);
            Console.WriteLine(produto.ToString());
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            quantidade = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(quantidade);
            Console.WriteLine(produto.ToString());
            Console.WriteLine();

        }
    }
}
