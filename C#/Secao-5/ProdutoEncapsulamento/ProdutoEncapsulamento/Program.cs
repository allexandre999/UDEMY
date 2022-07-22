using System;
using System.Globalization;

namespace ProdutoEncapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("João",900.00);
            Console.WriteLine(p.GetNome());
            p.SetNome("TV");
            Console.WriteLine(p.GetNome());
        }
    }
}
