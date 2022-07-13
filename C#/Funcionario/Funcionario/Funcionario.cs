using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Funcionario
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem) {
            SalarioBruto = SalarioBruto + SalarioBruto * porcentagem / 100;
        }

        public override string ToString()
        {
            return $"{Nome}, $ {SalarioLiquido().ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
