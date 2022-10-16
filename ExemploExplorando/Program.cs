using ExemploExplorando.Models;
using System.Globalization; //format region
using Newtonsoft.Json;





int numero = 20;
bool ehPar = false;

ehPar = numero.EhPar();
Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "impar"));

























// TrabalhandoComDatas();
// FormatandoNumeros();
// FormatandoStrings();
// TesteTryCatch();
// Filas();
// Pilhas();
// Dictionary();
// TupleExemplo();
// TupleComMetodo();
// ExemploDeconstruct();
// ifTernario();
// exemploSerialize();
// exemploDeserialize();
// TiposNulos();
// ObjTipoAnonimos();
// variavelDinamica();
// ClasseGenerica();



/*
void ClasseGenerica()
{
    //Instanciando classe genérica<T>
    MeuArray<int> arrayInteiro = new MeuArray<int>();
    arrayInteiro.AdcionarElementoArray(30);
    System.Console.WriteLine(arrayInteiro[0]);

    MeuArray<string> arrayString = new MeuArray<string>();
    arrayString.AdcionarElementoArray("texto");
    System.Console.WriteLine(arrayString[0]);
}

void variavelDinamica()
{
    dynamic variavelDinamica = 4;
    System.Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()} valor: {variavelDinamica}");

    variavelDinamica = "Texto";
    System.Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()} valor: {variavelDinamica}");

    variavelDinamica = true;
    System.Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()} valor: {variavelDinamica}");

    variavelDinamica = new Pessoa();
    System.Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()} valor: {variavelDinamica}");
}

void ObjTipoAnonimos()
{
    //Declaração de tipo anônimo
    var tipoAnonimo = new { Nome = "Leonardo", Sobrenome = "Buta", Altura = 1.80 };

    Console.WriteLine($"Nome: {tipoAnonimo.Nome}");
    Console.WriteLine($"Sobrenome: {tipoAnonimo.Sobrenome}");
    Console.WriteLine($"Altura: {tipoAnonimo.Altura}");
    //=============================================================================
    string conteudoArquivoJson = File.ReadAllText("Assets/vendas.json");
    List<Venda> listaVendas = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivoJson);
    

    var listaAnonimo = listaVendas.Select(x => new { x.Produto, x.Preco });
    Console.WriteLine($"Tipo da lista anonima: {listaAnonimo.GetType()}");

    foreach (var venda in listaAnonimo)
    {
        Console.WriteLine($"Produto: {venda.Produto}, Preco: {venda.Preco}");
    }
}

void TiposNulos()
{
    //Para fazer com que uma variável aceite valores nulos 
    //colocamos ? após a declaração de tipo
    bool? desejaReceberEmail = true;

    // sempre que trabalharmos com tipos nulos é importante
    //fazer a verificação de valor na variável?, caso contrário gera exception
    // variavel.HasValue é a mesma coisa que  variavel != null
    if (desejaReceberEmail.HasValue && desejaReceberEmail.Value)
    {
        Console.WriteLine("O usuário optou por receber e-mail");
    }
    else
    {
        Console.WriteLine("O usuário não respondeu ou optou por não responder");
    }

}

void exemploDeserialize()
{

    string conteudoArquivoJson = File.ReadAllText("Assets/vendas.json");

    List<Venda> listaVendas = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivoJson);

    foreach (Venda venda in listaVendas)
    {
        Console.WriteLine
        (
            $"Id: {venda.Id}, " +
            $"Produto: {venda.Produto}, " +
            $"Preço: {venda.Preco.ToString("C2")}, " +
            $"Data: {venda.DataVenda.ToString("dd/MM/yyy HH:mm")} " +
            $"{(venda.Desconto.HasValue? $"Desconto: {venda.Desconto.Value.ToString("C2")}" : $"")}"
        );
    }
}

void exemploSerialize()
{
    DateTime dataAtual = DateTime.Now;

    List<Venda> listaVendas = new List<Venda>();

    Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
    Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);

    listaVendas.Add(v1);
    listaVendas.Add(v2);

    string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented); //parse JSON

    File.WriteAllText("Assets/vendas.json", serializado);

    Console.WriteLine(serializado);
}

void ifTernario()
{
    int numero = 20;
    bool ehPar = false;

    ehPar = numero % 2 == 0;
    Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "impar"));


    if (numero % 2 == 0)
    {
        Console.WriteLine($"O número {numero} é par");
    }
    else
    {
        Console.WriteLine($"O número {numero} é impar");
    }
}

void ExemploDeconstruct()
{
    Pessoa pessoa = new Pessoa("Wilson", "Brandão");

    (string nome, string sobrenome) = pessoa;

    Console.WriteLine($"{nome} {sobrenome}");
}

void TupleComMetodo()
{
    LeituraArquivo arquivo = new LeituraArquivo();

    //var assume tipos retornados pela tupla
    var (sucesso, linhasArquivo, QuantidadeLinhas) = arquivo.LerArquivo("Asset/arquivoLeitura.txt");

    //Utilizando descarte com caractere " _ " (Underline)
    //var (sucesso, linhasArquivo, _ ) = arquivo.LerArquivo("Asset/arquivoLeitura.txt");

    
    if(sucesso)
    {
        Console.WriteLine($"Quantidade linhas arquivo: {QuantidadeLinhas}");
        foreach(string linha in linhasArquivo)
        {
            System.Console.WriteLine(linha);
        }
    }
    else
    {
        Console.WriteLine($"Não foi possivel ler o arquivo");
    }
    
}
 
void TupleExemplo()
{
    //  Tuplas são estrutura de dados que podem armazerar valores com tipos distintos

    //declaração Tupla
    (int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Wilson", "Brandão", 1.82M);

    //Outras formas de declarar uma Tupla
    //desvantagem de não poder nomear tipos
    ValueTuple<int, string, string, decimal> tupla2 = (2, "Stefany", "Oliveira", 1.70M);
    var tupla3 = Tuple.Create(3, "Maria", "José", 1.65M);

    Console.WriteLine($"id:  {tupla.Id}");
    Console.WriteLine($"Nome:  {tupla.Nome}");
    Console.WriteLine($"Sobrenome:  {tupla.Sobrenome}");
    Console.WriteLine($"Altura:  {tupla.Altura}");

    Console.WriteLine(tupla2);
    Console.WriteLine(tupla3);

}

void Dictionary()
{
     
    //    Dictionary é uma coleção de chave e valores 
    //    As chaves são únicas e não se repetem, se repetir gera exception
    
    //Dictionary<Tipo da chave, Tipo do Valor>
    Dictionary<string, string> estados = new Dictionary<string, string>();

    //Chave e Valor
    estados.Add("SP", "São Paulo");
    estados.Add("BA", "Bahia");
    estados.Add("MG", "Minas Gerais");

    //obter elemento
    Console.WriteLine(estados["MG"] + "\n");

    // foreach(KeyValuePair<string, string> item in estados)
    foreach(var item in estados)
    {
        Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
    }

    // estados.Add("BA", "Bahia"); //gera exception, item já existente

    Console.WriteLine("------------------------------------------------------------------------");

    estados.Remove("BA");

    //Alterar valor através da chave, se não existir a chave é criada com o valor passado
    estados["SP"] = "SÃO PAULO"; 

    foreach(var item in estados)
    {
        Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
    }

    Console.WriteLine("------------------------------------------------------------------------");

    string chave = "BA";

    Console.WriteLine($"Verificando elemento: {chave}");

    if(estados.ContainsKey(chave))
    {
        Console.WriteLine($"Valor existente: {chave}");
    }
    else
    {
        Console.WriteLine($"Valor não existente. é seguro adicioanar a chave: {chave}");
        
    }

}

void Pilhas() 
{
    //Classe stack cria uma pilha - LIFO
    Stack<int> pilha = new Stack<int>();

    //Insere um elemento no topo da Stack
    pilha.Push(2);
    pilha.Push(4);
    pilha.Push(6);
    pilha.Push(8);

    //percorrer stack
    foreach(int item in pilha)
    {
        Console.WriteLine(item); // 8 6 4 2 
    }

    //remove elemento no topo da stack
    Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

    pilha.Push(10);

    foreach(int item in pilha)
    {
        Console.WriteLine(item);
    }

}

void Filas()
{
    //Classe Queue cria uma fila - FIFO
    Queue<int> fila = new Queue<int>();

    //adiciona elemente no final da fila
    fila.Enqueue(2);
    fila.Enqueue(4);
    fila.Enqueue(6);
    fila.Enqueue(8);

    //percorer fila
    foreach (int item in fila)
    {
        Console.WriteLine(item);
    }

    //remove primeiro elemento da fila
    Console.WriteLine($"Removendo elemento: {fila.Dequeue()}");
    
    fila.Enqueue(10);

     foreach (int item in fila)
    {
        Console.WriteLine(item);
    }
}

void TesteTryCatch()
{
    try
    {
        //ler o arquivo e retonar cada linha do arquivo scomo uma string
        string[] linhasArquivo = File.ReadAllLines("Assets/arquivoLeitura.txt");

        foreach (string linha in linhasArquivo)
        {
            Console.WriteLine(linha);
        }
    }
    catch (FileNotFoundException error)
    {
        Console.WriteLine(
            $"Ocorreu um erro na leitura do arquivo." +
            $"Arquivo não encontrado! {error.Message}");
    }
    catch (DirectoryNotFoundException error)
    {
        Console.WriteLine(
            $"Ocorreu um erro na leitura do arquivo. " +
            $"Caminho não encontrado. {error.Message}");
    }
    catch (Exception error)
    {
        Console.WriteLine(
            $"Ocorreu um erro na leitura do arquivo. " +
            $"Caminho não encontrado. {error.Message}");
    }
    finally //sempre será executado
    {
        Console.WriteLine("Finally");
    }

    new ExemploException().Metodo1();
}

void TrabalhandoComDatas()
{
    DateTime data = DateTime.Now;

    System.Console.WriteLine(data); // 08/10/2022 18:42:02
    System.Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm")); // 08/10/2022 18:42

    System.Console.WriteLine(data.ToShortDateString()); // 08/10/2022 
    System.Console.WriteLine(data.ToShortTimeString()); // 18:42 
                                                        //=======================================================================
    string dataStringCorreta = "2022-04-17 18:00";
    string dataStringIncorreta = "2022-13-15 18:50";

    //converte string para dateTime porém gera exception se a data n puder ser convertida
    DateTime dataDesestruturada = DateTime.Parse(dataStringCorreta);
    System.Console.WriteLine(dataDesestruturada);  //17/04/2022 18:00:00

    //Tentar converter a data sem gerar exception
    bool conversao = DateTime.TryParseExact
    (
        dataStringIncorreta, //String a ser convertida
        "yyyy-MM-dd HH:mm", //Formato da data antes da conversão
        CultureInfo.InvariantCulture, //Qual formato de cultura a data está (InvariantCulture = Independente da cultura)
        DateTimeStyles.None,  //Estilo do dateTime
         out DateTime dataFormatada //cria variavel de saida
    );

    if (conversao)
    {
        System.Console.WriteLine($"Conversão com sucesso! Data: {dataFormatada}");
    }
    else
    {
        System.Console.WriteLine($"{dataStringIncorreta} não é uma data válida");
    }
}

void FormatandoNumeros()
{
    CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR"); //format region cuture

    decimal valorMonetario = 1582.40M;

    //formatar currency region especifica usando ToString("C")
    System.Console.WriteLine($"{valorMonetario:C}"); //R$ 1.582,40
    System.Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))); //$1,582.40

    //C = Currency e os numeros são sas casas decimais (C2 = 0.00)
    System.Console.WriteLine(valorMonetario.ToString("C2")); //R$ 1.582,40

    //formatar porcentagem usando ToString("P")
    double porcentagem = .2421;
    System.Console.WriteLine(porcentagem.ToString("P")); //24,21%

    //formater formato de números
    int numero = 123456;
    System.Console.WriteLine(numero.ToString("##-##-##")); //12-34-56
}

void FormatandoStrings()

{
    string numero1 = "10";
    string numero2 = "20";

    string resultado = numero1 + numero2;

    System.Console.WriteLine(resultado); //"1020"

    Pessoa alunoLeonardo = new Pessoa("Leonardo", "Buta");
    Pessoa alunoWilson = new Pessoa(nome: "Wilson", sobrenome: "Brandão");

    Curso cursoDeDotnet = new Curso();
    cursoDeDotnet.Nome = ".Net";
    cursoDeDotnet.Alunos = new List<Pessoa>();

    cursoDeDotnet.AdicionarAluno(alunoLeonardo);
    cursoDeDotnet.AdicionarAluno(alunoWilson);
    cursoDeDotnet.ListarAlunos();

    Pessoa p1 = new Pessoa();
    p1.Nome = "Wilson";
    p1.Sobrenome = "Brandão";
    p1.Idade = 20;
    p1.Apresentar();
}

*/