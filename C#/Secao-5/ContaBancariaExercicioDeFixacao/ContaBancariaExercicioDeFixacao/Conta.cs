using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ContaBancariaExercicioDeFixacao
{
    class Conta
    {
        public int NumConta { get; private set; }
        public string NomeTitular { get; private set; }
        public double SaldoTitular { get; private set; }

        public Conta(int numeroConta, string nomeTitular) {
            if (numeroConta > 0 && nomeTitular.Length > 1)
            {
                NumConta = numeroConta;
                NomeTitular = nomeTitular;
                SaldoTitular = 0.0;
            }
        }

        public Conta(int numeroConta, string nomeTitular, double saldoTitular ) : this(numeroConta, nomeTitular)
        {
            if (saldoTitular > 0)
            {
                SaldoTitular = saldoTitular;
            }
        }

        public void Deposito(double deposito) {
            SaldoTitular = SaldoTitular + deposito; 
        }

        public void Saque(double saque) {
            if (saque > 0)
            {
                SaldoTitular = SaldoTitular - (saque + 5);
            }
        }

        public override string ToString()
        {
            return $"Conta {NumConta}, Titular: {NomeTitular}, Saldo: $ {SaldoTitular.ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
