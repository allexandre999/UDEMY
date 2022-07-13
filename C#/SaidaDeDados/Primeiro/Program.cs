using System;
using System.Globalization;

namespace SaidaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;


            Console.WriteLine($"Produtos:\nComputador, cujo preço é $ {preco1.ToString("F2")}\nMesa de escritório, cujo " +
                $"preco é $ {preco2.ToString("F2")}\n");
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}\n");
            Console.WriteLine($"Medida com oito casas decimais {medida.ToString("F8")}\n" +
                                $"Arredondado (três casas decimais): {medida.ToString("F3")}\n" +
                                $"Separador decimal invariant culture {medida.ToString("F3", CultureInfo.InvariantCulture)}\n");


        }
    }
}
