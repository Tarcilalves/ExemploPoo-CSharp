using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.Models
{
    public class ContaCorrente
    {
        //construtor
        public ContaCorrente(int NumeroConta, decimal saldoInicial)
        {
            this.NumeroConta = NumeroConta;
            saldo = saldoInicial;
        }

        //Métodos
        public int NumeroConta { get; set; }
        private decimal saldo;

        public void Sacar(decimal valor)
        {
            if(saldo >= valor)
            {
            saldo -=valor;
            Console.WriteLine("Saque realizado com sucesso");
            }else
            {
                Console.WriteLine("Valor desejado é maior que o saldo disponivel");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo disponivel é: {saldo}");
        }

    }
}