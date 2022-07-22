using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Aluno
{
    class Aluno
    {
        public string NomeAluno;
        public double N1;
        public double N2;
        public double N3;

        public double Soma()
        {
            return N1 + N2 + N3;
        }

        public override string ToString()
        {
            if (Soma() >= 60)
            {
                return $"\nNOTA FINAL = {Soma().ToString("F2",CultureInfo.InvariantCulture)}" +
                    $"\nAPROVADO!";
            }
            else
            {
                return $"\nNOTA FINAL = {Soma().ToString("F2",CultureInfo.InvariantCulture)}" +
                    $"\nREPROVADO" +
                    $"\nFALTARAM {(60 - Soma()).ToString("F2",CultureInfo.InvariantCulture)} PONTOS";
            }
        }

    }
}
