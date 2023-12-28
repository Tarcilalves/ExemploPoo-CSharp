using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.Models
{
    public class Pessoa
    {
        // construtor vazio
       public Pessoa()
       {
        
       } 

       //Criar um contrutor padrão que exige o um 'nome'.
        public Pessoa(string nome)
        {
            Nome = nome;
        }
       public string Nome { get; set; }
       public int Idade { get; set; }
       public string Email { get; set; }
       
       public virtual void Apresentar()
       {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade}");
       }
    }
}