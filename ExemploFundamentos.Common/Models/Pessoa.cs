using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    /// <summary>
    /// Representa uma pessoa fisíca
    /// </summary>
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        /// <summary>
        /// Diz o nome e idade da pessoa
        /// </summary>
        public void Apresentar(){
            Console.WriteLine($"olá, meu nome é {Nome},  e tenho {Idade} anos");
        }
    }
}