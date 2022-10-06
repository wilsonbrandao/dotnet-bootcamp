using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento (decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            System.Console.WriteLine("Digite a placa do veículo estácionado: ");
            string placa = Console.ReadLine().ToUpper();
            this.veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            System.Console.WriteLine("Digite a placa do veículo para remover: ");

            string placa = Console.ReadLine().ToUpper();

            if (veiculos.Any(value => value == placa))
            {
                System.Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estácionado: ");
                
                int horas = int.Parse(Console.ReadLine());
                decimal valorTotal = this.precoInicial + this.precoPorHora * horas;

                veiculos.Remove(placa);

                System.Console.WriteLine($"O Veículo {placa} foi removido e o preço total foi de: R$ {valorTotal.ToString("0.00")}");
            }
            else
            {
                System.Console.WriteLine("Desculpe, esse veículo não está estácionado. Verifique se a placa está correta");
            }
        }

        public void ListarVeiculos()
        {
            if(veiculos.Any())
            {
                System.Console.WriteLine("Os veiculos estácionados aqui são: ");
                foreach(string veiculo in veiculos)
                {
                    System.Console.WriteLine($"Placa: {veiculo}");
                }
            }
            else
            {
                System.Console.WriteLine("Não há veiculos estacionados");
            }
        }
    }
}