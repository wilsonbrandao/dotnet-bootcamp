using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public Professor(string nome) : base(nome){}

        public decimal Salario { get; set; }

        public sealed override void Apresentar() => 
            Console.WriteLine($"Olá meu nome é {Nome}. Sou um professor, ganho um salario de {Salario}!");
    }
}