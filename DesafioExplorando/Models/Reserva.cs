using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioExplorando.Models
{
    public class Reserva
    {
        public Reserva(){}
        public Reserva(Suite suite, int diasReserva)
        {
            Suite = suite;
            DiasReservados = diasReserva;
        }

        private List<Pessoa> _hospedes = new List<Pessoa>();
        private Suite _suite = new Suite("Solteiro", 1, 110.00M);
        private int _diasReservados;

        public List<Pessoa> Hospedes { get => _hospedes; set => _hospedes = value; }
        public Suite Suite { get => _suite; set => _suite = value; }
        public int DiasReservados { get => _diasReservados; set => _diasReservados = value; }

        public void CadastraHospedes(List<Pessoa> hospedes)
        {
            if(hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
                Console.WriteLine($"Hospedes cadastrados");
            }
            else
            {
                throw new Exception("O quarto escolhido não comparta o total de hospedes");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            if(Hospedes.Count <= suite.Capacidade)
            {
                Suite = suite;
                Console.WriteLine($"Suite reservada");
            }
            else
            {
                throw new Exception("O quarto escolhido não comparta o total de hospedes");
            }
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = 0M;
            if(DiasReservados >= 10)
            {
                decimal desconto = (Suite.ValorDiaria / 100) * 10;
                valor = (Suite.ValorDiaria - desconto) * DiasReservados;
            }
            else
            {
                valor = Suite.ValorDiaria * DiasReservados;
            }
            return valor;
        }


    }
}