using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ProdutoConstrutores
{
    //Construtor;Sobrecarga de Construtor;Palavra this;
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto()
        {
            Quantidade = 1;
        }

        public Produto(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome,preco)
        {
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return $"Dados do produto: {Nome}, $ {Preco.ToString("F2", CultureInfo.InvariantCulture)}, {Quantidade} unidades, Total: $ {ValorTotalEmEstoque()}";
        }
    }
}
