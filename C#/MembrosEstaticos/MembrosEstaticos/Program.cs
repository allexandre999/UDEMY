using System;
using System.Globalization;

namespace MembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double valorDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("\nQuantos dólares você vai comprar? ");
            double qtdDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write($"\nValor a ser pago em reais = {ConversorDeMoeda.ConverterMoeda(valorDolar,qtdDolar).ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine();
        }
    }
}
