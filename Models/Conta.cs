using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.Models
{
    public abstract class Conta
    {
        //propriedade
        protected decimal saldo;

        // método Creditar, vai servir como <<abstract>>. Esse método não tem corpo, ele abre e fecha chaves. 
        public abstract void Creditar(decimal valor);

        //método
        public void ExibirSaldo()
        {
            Console.WriteLine("O seu saldo: " + saldo);
        }
        
    }
}