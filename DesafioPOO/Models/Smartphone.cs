using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public Smartphone(string modelo, string imei, int memoria, string? numero)
        {
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            Numero = numero;
        }

        protected string Modelo;
        protected string IMEI;
        protected int Memoria;

        public string? Numero { get; set; }

        public void Ligar()
        {
            Console.WriteLine("Ligando....");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo liganção...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}