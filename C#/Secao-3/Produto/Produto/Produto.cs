using System.Globalization;

namespace Produto
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return $"Dados do produto: {Nome}, $ {Preco.ToString("F2",CultureInfo.InvariantCulture)}, {Quantidade} unidades, Total: $ {ValorTotalEmEstoque()}";
        }

    }
}
