using System;
using System.Collections.Generic;
using System.Text;

namespace MembrosEstaticos
{
    class ConversorDeMoeda
    {
        public static double ConverterMoeda(double valorDolar, double qtdDolar) {
            return valorDolar * qtdDolar + CalcularIOF(valorDolar,qtdDolar);
        }

        public static double CalcularIOF(double valorDolar, double qtdDolar) {
            return valorDolar * qtdDolar * 6 / 100;
        }

    }
}
