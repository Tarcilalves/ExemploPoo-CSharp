using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.Models
{
    public class Professor : Pessoa
    {
        //construtor vazio
        public Professor()
        {
            
        }
        //contrutor para obederce a regra da classe Pai: nome obrigatório.
        public Professor(string nome) : base(nome)
        {
            
        }
        public decimal Salario { get; set; }
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos, e sou um professor e ganho {Salario}");
        }
    }
}