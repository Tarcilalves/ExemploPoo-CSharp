using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.Models
{
    public class Aluno : Pessoa
    {
        // construtor vazio
        public Aluno()
        {
            
        }
        //contrutor para obederce a regra da classe Pai: nome obrigatório.
        public Aluno(string nome) : base(nome)
        {
            
        }
        public double Nota { get; set; }
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos, e sou um aluno nota {Nota}");
        }
    }
}