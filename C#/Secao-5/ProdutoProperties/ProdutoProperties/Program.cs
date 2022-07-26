using System;


namespace ProdutoProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("João", 900.00);
            Console.WriteLine(p.Nome);
            p.Nome= "T";
            Console.WriteLine(p.Nome);
            //p.Preco = 1000.00; //Properties feitas somente para Get;
            Console.WriteLine(p.Preco);
            //p.Quantidade = 20; //Properties feitas somente para Get;
            Console.WriteLine(p.Quantidade);
        }
    }
}
