using System.Xml;

// Sistema de gerenciamento de notas
List<string> nomes = new List<string>();

Dictionary<string, List<int>> alunos = new Dictionary<string, List<int>>(); // Criar um dicionario, é tipo um json
alunos.Add("Henrique", new List<int> { 12,2}); // Teste

void AdicionarAlunoNaLista(string nome)
{
    alunos.Add(nome, new List<int> ());
}
void AdicionarNotaDoAluno(string aluno)
{
    string controleNota = "dentro";
    Console.WriteLine("Entrei na função e controle: ",controleNota);
    while (controleNota != "sair")
    {
        Console.WriteLine($"Digite a nota do {aluno}: ");
        int nota = int.Parse(Console.ReadLine());
        alunos[aluno].Add(nota);
        Console.WriteLine("Adicionado com sucesso! ");

        Console.WriteLine("Digite sair para finalizar a adição de notas: ");
        controleNota = Console.ReadLine();
    }
}
void ListarAlunos()
{
    Console.Clear();
    Console.WriteLine("Listagem de alunos");
    foreach (var nome in alunos.Keys)
    {
        Console.Write("-");
        Console.WriteLine(nome);
    }
}
void ListarNotasDeTodos()
{
    foreach (var nome in alunos.Keys)
    {
        Console.WriteLine($"Nome do aluno: {nome}");
        Console.WriteLine("Notas");
        foreach (int notas in alunos[nome])
        {
            Console.Write($"{notas} | ");
        }
        Console.WriteLine("");
    }
}

void ListarMediaDeTodos()
{
    foreach (var nome in alunos.Keys)
    {
        Console.WriteLine($"Nome do aluno: {nome}");
        Console.WriteLine("Notas");
        foreach (int notas in alunos[nome])
        {
            Console.WriteLine($"-{notas}");
        }
        Console.WriteLine($"-> Média do {nome}: {alunos[nome].Average()}");
    }
}

void ListarNotasDeUmAluno(string aluno)
{
    Console.WriteLine($"Notas do {aluno}");
    foreach(var notas in alunos[aluno])
    {
        Console.Write($"{notas} |");
    }
}

void ListarMediaDeUmAluno(string aluno)
{
    Console.WriteLine($"Notas do {aluno}");
    foreach (var notas in alunos[aluno])
    {
        Console.Write($"{notas} |");
    }
    Console.WriteLine($" Média do aluno {aluno}: {alunos[aluno].Average()}");
}

void RemoverAluno(string aluno)
{
    alunos.Remove(aluno);
    Console.WriteLine($"Aluno {aluno} excluido com sucesso");
}

void Menu()
{
    int opcao = -1;
    while (opcao != 0)
    {
        Console.WriteLine("------------- Gerenciador de Notas de Alunos -------------");
        Console.WriteLine();
        Console.WriteLine("Digite a opção do menu para escolher o que fazer ");
        Console.WriteLine("1. Adicionar Aluno na Lista ");
        Console.WriteLine("2. Adicionar Nota para um Aluno da Lista ");

        Console.WriteLine("3. Ver todos os alunos cadastrados");
        Console.WriteLine("4. Ver a nota de todos os alunos cadastrados");
        Console.WriteLine("5. Ver a média de todos os Alunos");
        Console.WriteLine("6. Ver as notas de um Aluno especifico");
        Console.WriteLine("7. Ver a média de um Aluno especifico");

        Console.WriteLine("8. Para excluir um aluno da lista");

        Console.WriteLine("0. Para sair");
        Console.WriteLine();
        Console.WriteLine("----------------------------------------------------------");
        string escolha = Console.ReadLine()!;
        int escolhaConvetida = int.Parse(escolha);

        if (escolhaConvetida == 0)
        {
            Console.WriteLine("Saiu do APP");
            opcao = 0;
        }

        if (escolhaConvetida == 1)
        {
            Console.WriteLine("Digite o nome do aluno a ser inserido: ");
            string nomeInserido = Console.ReadLine()!;

            AdicionarAlunoNaLista (nomeInserido);
            Console.WriteLine($"Aluno {nomeInserido} inserido com sucesso");
            Carregando();
        }
        if (escolhaConvetida == 2)
        {
            ListarAlunos();
            Console.WriteLine("Digite o nome de um aluno da lista para inserir suas notas:");
            string alunoEscolhido = Console.ReadLine()!;
            AdicionarNotaDoAluno(alunoEscolhido);
            Carregando();
        }
        if (escolhaConvetida == 3)
        {
            ListarAlunos();
        }

        if (escolhaConvetida == 4)
        {
            ListarNotasDeTodos();
        }

        if (escolhaConvetida == 5)
        {
            ListarMediaDeTodos();
        }

        if (escolhaConvetida == 6)
        {
            ListarAlunos();
            Console.WriteLine("Digite o nome de um aluno da lista para verificar suas notas:");
            string alunoEscolhido = Console.ReadLine()!;
            ListarNotasDeUmAluno(alunoEscolhido);
            Console.WriteLine();
        }

        if (escolhaConvetida == 7)
        {
            ListarAlunos();
            Console.WriteLine("Digite o nome de um aluno da lista para verificar sua média:");
            string alunoEscolhido = Console.ReadLine()!;
            ListarMediaDeUmAluno(alunoEscolhido);
            Console.WriteLine();
        }

        if(escolhaConvetida == 8)
        {
            ListarAlunos();
            Console.WriteLine("Digite o nome de um aluno da lista para remove-lo da lista:");
            string alunoEscolhido = Console.ReadLine()!;
            RemoverAluno(alunoEscolhido);
            Console.WriteLine();
        }
    }
}

void Carregando()
{
    Console.WriteLine("Carregando e limpando console");
    Thread.Sleep(3000);
    Console.Clear();
}


void adicionarNomesNaLista(string nome)
{
    nomes.Add(nome);
    Console.WriteLine($"Lista de nomes Atual");
    Console.WriteLine("Usando ForEach");
    foreach (string nomeUnico in nomes)
    {
        Console.WriteLine(nomeUnico);
    }
    Console.WriteLine("Usando For normal");
    for (int i = 0; i < nomes.Count; i++)
    {
        Console.WriteLine(nomes[i]);
    }
}
// As funções utilizam o PascalCase, seus nomes iniciais começa com Maiusculo
void MostrarMedia()
{
    Console.Write("Digite sua nota: ");
    // As variaveis sempre como CamelCase -> Primeira letra minuscula e o resto Maiuscula...................................................................................................................................................................................................................................................................................................................
    int notaMedia = Console.Read();
    if (notaMedia >= 5)
    {
        Console.WriteLine("Nota suficiente para aprovação! ");
    }
    else
    {
        Console.WriteLine("Você esta reprovado! ");
    }
}
void Exercicio1Alura()
{
    Console.Write("Digite seu nome: ");
    string nome = Console.ReadLine()!;

    Console.Write("Digite seu sobrenome: ");
    string sobrenome = Console.ReadLine()!;
    // O sleep é tipo, espera em milesegundos e depois prossegue
    Thread.Sleep( 1000 );
    // Limpa o console
  
    //  Interpolação
    Console.WriteLine($"Nome completo: {nome} {sobrenome}");
    string nomeCompleto = nome + " " + sobrenome;
    Console.Clear();
    adicionarNomesNaLista(nomeCompleto);
}

//MostrarMedia();
//Exercicio1Alura();
//Exercicio1Alura();
//Exercicio1Alura();
Menu();