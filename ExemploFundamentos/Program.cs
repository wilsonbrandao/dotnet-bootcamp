using ExemploFundamentos.Common.Models;





/* =========================== VARIÁVEIS ================================= */
/*
//Tipo de dados nativos
string apresentacao = "Olá, seja bem vindo";
int quantidade = 1;
double altura = 1.80;
decimal preco = 1.80M;
bool condicao = true;
Console.WriteLine("Quantidade: " + quantidade);
Console.WriteLine("altura: " + altura.ToString("0.00")); //formatar casas decimais
Console.WriteLine("preco: " + preco);
Console.WriteLine("condicao: " + condicao);
Console.WriteLine(apresentacao);


//tipo de dados Struct
DateTime dataAtual = DateTime.Now; //data e hora
System.Console.WriteLine(dataAtual);

dataAtual = DateTime.Now.AddDays(5); //add 5 dias
System.Console.WriteLine(dataAtual.ToString("yyyy/MM/dd")); //somente data
System.Console.WriteLine(dataAtual.ToString("HH:mm")); //somente hora e minutos

/* =========================== Classe ================================= */
/*
//Instaciando Classe 
Pessoa mauro = new Pessoa();
mauro.Nome = "Mauro";
mauro.Idade = 27;
mauro.Apresentar();
*/

/* =========================== OPERADORES ================================= */
/*
// Atribuição
// int a = 10;
// int b = 20;
// int c = a + b;

// c += 5; //35;
// c -= 10; //25
// c *= 2; //50 
// Console.WriteLine(c);

//Cast - Casting
int a = Convert.ToInt32("5"); //método com Convert, null vira 0 (melhor método)
int b = int.Parse("10"); //metodo com Parse, null gera Exception
string numero = b.ToString();

//casting implicito
int c = 5;
int cc = 10;
double d = c; //um int cabe em um double
double dd = double.MaxValue;

//cc = Convert.ToInt32(dd); //Gera Exception pois um double não cabe em um int
Console.WriteLine(a); //int 5
Console.WriteLine(b); //int 10
Console.WriteLine(numero); //string 10
Console.WriteLine(d); //double 5
Console.WriteLine(dd); //double 1.7976931348623157E+308

//convertendo de forma segura
string z = "15";
int y = 0;

int.TryParse(z, out y); //tenta casting, se n conseguir returna valor padrão
int.TryParse(z, out int x); //declara nova variavel, se erro 0 é valor padrão

Console.WriteLine(y); //15
Console.WriteLine(x); //15
*/

/* =========================== OPERADPRES CONDICIONAIS ================================= */
/*
// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 4;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade em estoque: {quantidadeCompra}");
// Console.WriteLine($"É possivel realizar a venda: {possivelVenda}");

// //condição IF ELSE IF
// if(quantidadeCompra == 0){
//     Console.WriteLine("Venda inválida");
// }
// else if(possivelVenda )
// {
//     Console.WriteLine("Venda Realizada");
// }
// else
// {
//     Console.WriteLine("Desculpa. Não temos a quantidade desejada em estoque");
// }

//Switch Case
Console.Write("Digite uma letra: ");
char letra = Convert.ToChar(Console.ReadLine());

switch(letra)
{
    case 'a': 
    case 'e': 
    case 'i': 
    case 'o': 
    case 'u': 
        Console.WriteLine("É vogal!"); 
        break;
    default: 
        Console.WriteLine("Não é uma vogal!"); 
        break;
}
*/

/* =========================== OPERADORES LÓGICOS ================================= */
/*
bool ehMaiorDeIdade = true;
bool possuiAutorizacao = false;

//Operador OR
if(ehMaiorDeIdade || possuiAutorizacao)
{
    Console.WriteLine("Entrada libera!");
}
else
{
    Console.WriteLine("Entrada não libera!");
}

bool possuiPresencaMinima = true;
double media = 7.5;

//operador AND
if(possuiPresencaMinima && media >= 7){
    Console.WriteLine("Aprovado");
}
else
{
    Console.WriteLine("Reprovado");
}

bool choveu = false;
bool estaTarde = false;

//operador NOT
if (!choveu && !estaTarde)
{
    Console.WriteLine("Vou pedalar");
}
else
{
    Console.WriteLine("Vou pedalar outro dia");
}
*/

/* =========================== OPERADORES ARITMÉTICOS ================================= */
/*
Calculadora calc = new Calculadora();

calc.Somar(5, 5);
calc.Subtrair(5, 5);
calc.Multiplicar(5, 5);
calc.Dividir(5, 5);

calc.Potencia(3, 3);
calc.RaizQuadrada(9);

calc.Seno(30);
calc.Conseno(30);
calc.Tangente(30);
*/
/* =========================== LAÇOS DE REPETIÇÃO ================================= */
/*
int numero = 10;

for(int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{numero} x {i} = {numero * i}");
}

Console.WriteLine("==========================");

int numero2 = 5;
int contador = 1;
while(contador <= 10)
{
    Console.WriteLine($"{numero2} x {contador} = {numero2 * contador}");
    contador++;
    if(contador == 8){
        Console.WriteLine($"BREAK");
        break;
    }
}

Console.WriteLine("==========================");

int numero3 = 3;
int contador1 = 1;

do{
    Console.WriteLine($"{numero3} x {contador1} = {numero3 * contador1}");
    contador1++;
}while(contador1 <= 10);

string opcao = "";

while(opcao != "4"){
    Console.Clear();
    Console.WriteLine("Digite sua opção");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1": 
            Console.WriteLine("Cadastro de cliente");
            Console.ReadLine();
            break;
        case "2": 
            Console.WriteLine("Buscar cliente");
            Console.ReadLine();
            break;
        case "3": 
            Console.WriteLine("Apagar cliente");
            Console.ReadLine();
            break;
        case "4": 
            Console.WriteLine("Encerrar");
            break;
        default:
            Console.WriteLine("Opção inválida");
            Console.ReadLine();
            break;
    }
}
*/

/* =========================== ARRAYS ================================= */

//declaração array
// int[] arrayinteiros = new int[3];

// arrayinteiros[0] = 72;
// arrayinteiros[1] = 64;
// arrayinteiros[2] = 50;

// //Redimencionar tamanho de array, (referencia do array, tamanho novo)
// // Array.Resize(ref arrayinteiros, arrayinteiros.Length * 2);
// int[] arrayInteirosMaior = new int[arrayinteiros.Length * 2];
// Array.Copy(arrayinteiros, arrayInteirosMaior, arrayinteiros.Length); //copiar array




// for(int indice = 0; indice < arrayinteiros.Length; indice++) 
// {
//     System.Console.WriteLine($"Indice {indice} : {arrayinteiros[indice]}");
// }


// int indiceForeach = 0;
// System.Console.WriteLine("\nFOREACH");
// foreach(int elemento in arrayinteiros)
// {
//     System.Console.WriteLine($"Indice {indiceForeach} : {elemento}");
//     indiceForeach++;
// }

/* =========================== LIST ================================= */

//Declaração lista
List<string> listString = new List<string>();

//Adicionar na lista
listString.Add("São Paulo");
listString.Add("Bahia");
listString.Add("Minas Gerais");
listString.Add("Rio de Janeiro");

System.Console.WriteLine($"Itens lista: {listString.Count} - Capacidade {listString.Capacity}"); // 4 - 4
listString.Add("Pernambuco");
System.Console.WriteLine($"Itens lista: {listString.Count} - Capacidade {listString.Capacity}"); // 5 - 8 
listString.Remove("São Paulo"); //remove elemento pelo nome
System.Console.WriteLine($"Itens lista: {listString.Count} - Capacidade {listString.Capacity}");// 6 - 8



// //percorrer lista
// for(int indice = 0; indice < listString.Count; indice++)
// {
//     System.Console.WriteLine($"Indice {indice} : {listString[indice]}");
// }

// System.Console.WriteLine("\nFOREACH");
// int indiceForeach = 0;
// foreach( string elemento in listString)
// {
//     System.Console.WriteLine($"Indice {indiceForeach} : {elemento}");
//     indiceForeach++;
// }