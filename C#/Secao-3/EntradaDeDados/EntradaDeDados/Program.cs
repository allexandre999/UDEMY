using System;
using System.Globalization;

namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            // Split();
            //SplitParse();
            //ExercicioPT2();
        }

        static void ExercicioPropostoPT1() {

        }

        static void Split() {
            string frase = Console.ReadLine();
            string x, y, z, a, b, c;
            string[] vet;
            x = Console.ReadLine();
            y = Console.ReadLine();
            z = Console.ReadLine();
            vet = Console.ReadLine().Split(' ');
            a = vet[0];
            b = vet[1];
            c = vet[2];

            Console.WriteLine("Você digitou:");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }

        static void SplitParse() {
            int n1, idade;
            char ch, sexo;
            double n2, altura;
            string nome;
            n1 = int.Parse(Console.ReadLine());
            ch = char.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string[] vet = Console.ReadLine().Split(' ');
            nome = vet[0];
            sexo = char.Parse(vet[1]);
            idade = int.Parse(vet[2]);
            altura = double.Parse(vet[3], CultureInfo.InvariantCulture);
            Console.WriteLine("Voce Digitou");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }

        static void ExercicioPT2() {
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com seu ultimo nome, idade e altura (mesma linha)");
            string[] vet = Console.ReadLine().Split(' ');
            string ultimoNome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2],CultureInfo.InvariantCulture);


            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
