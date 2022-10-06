using DesafioFundamentos.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

System.Console.WriteLine(
    $"Seja bem vindo ao sistema de estacionamento!\n" +
    "Digite o preço inicial"
);
precoInicial = Convert.ToDecimal(Console.ReadLine());

System.Console.WriteLine("Digite o preço por hora: ");
precoPorHora = Convert.ToDecimal(Console.ReadLine());


var meuEstacionamento = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

while(exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");
    
    switch(Console.ReadLine())
    {
        case "1":
            meuEstacionamento.AdicionarVeiculo();
            break;
        case "2":
            meuEstacionamento.RemoverVeiculo();
            break;
        case "3":
            meuEstacionamento.ListarVeiculos();
            break;
        case "4":
            exibirMenu = false;
            break;
        default:
            System.Console.WriteLine("Opção inválida");
            break;
    }

    System.Console.WriteLine("Digite uma tecla para continuar");
    System.Console.ReadLine();
}

System.Console.WriteLine("Programa Encerrado");


