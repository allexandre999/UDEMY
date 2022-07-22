using System;
using System.Globalization;

namespace ProdutoConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre os dados do produto:");
            string nome = Console.ReadLine();
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int quantidade = int.Parse(Console.ReadLine());
            Produto produto = new Produto(nome,preco,quantidade);

            Console.WriteLine(produto.ToString());
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            quantidade = int.Parse(Console.ReadLine());
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
