using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInical)
        {
            NumeroConta = numeroConta;
            saldo = saldoInical;
        }
        public int NumeroConta { get; set; }
        private decimal saldo;

        public void Sacar(decimal valor)
        {
            if(saldo >= valor)
            {
                saldo -= valor;
                System.Console.WriteLine($"Saque de {valor} realizado, saldo atual: {saldo}");
            }
            else
            
            {
                System.Console.WriteLine($"Saldo insuficiente");
            }
        }

        public void ExibirSaldo()
        {
            System.Console.WriteLine($"Saldo: {saldo}");
        }
    }
}