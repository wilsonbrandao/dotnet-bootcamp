using System.Text;
using DesafioExplorando.Models;

Console.OutputEncoding = Encoding.UTF8;

Pessoa hospedeWilson = new Pessoa("Wilson", "Brandão");
Pessoa hospedeStefany = new Pessoa("Stefany", "Bezerra");

List<Pessoa> hospedes = new List<Pessoa>();
hospedes.Add(hospedeWilson);
hospedes.Add(hospedeStefany);

Suite suitePremium = new Suite("Premium", 2, 220.0M);
Suite suiteSolteiro = new Suite("Solteiro", 1, 110.0M);

Reserva reserva = new Reserva(suitePremium,11);

reserva.CadastraHospedes(hospedes);
reserva.CadastrarSuite(suitePremium);
// reserva.CadastrarSuite(suiteSolteiro);

System.Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
System.Console.WriteLine($"Valor estadia: {reserva.CalcularValorDiaria()}");
