using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ProdutoEncapsulamento
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto()
        {
            _quantidade = 1;
        }

        public Produto(string nome, double preco) : this()
        {
            _nome = nome;
            _preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            _quantidade = quantidade;
        }

        public string GetNome() {
            return _nome;
        }

        public void SetNome(string nome) {
            _nome = nome;
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

        public override string ToString()
        {
            return $"Dados do produto: {_nome}, $ {_preco.ToString("F2", CultureInfo.InvariantCulture)}, {_quantidade} unidades, Total: $ {ValorTotalEmEstoque()}";
        }
    }
}
