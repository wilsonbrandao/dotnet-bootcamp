using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string modelo, string imei, int memoria, string? numero) : base(modelo, imei, memoria, numero)
        {
            
        }
            
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando \"{nomeApp}\" no Iphone");
        }
    }
}