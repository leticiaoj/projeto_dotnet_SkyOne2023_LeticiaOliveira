Console.WriteLine("Bem-vindo ao Teste 02! Para iniciarmos, qual é o seu nome?");
string? nome = Console.ReadLine();

int quantidadeProvas = 0;
double totalNotas = 0;

while (true)
{
    Console.WriteLine($"{nome}, por favor, nos informe qual foi sua nota na prova (ou digite 'sair' para encerrar):");
    string? notaInput = Console.ReadLine();

    if (notaInput?.ToLower() == "sair")
        break;

    double nota;
    if (!double.TryParse(notaInput, out nota))
    {
        Console.WriteLine("Entrada inválida. Por favor, digite um valor numérico válido.");
        continue;
    }

    quantidadeProvas++;
    totalNotas += nota;
    double media = totalNotas / quantidadeProvas;

    Console.WriteLine($"Nome: {nome}");
    Console.WriteLine($"Quantidade de provas: {quantidadeProvas}");
    Console.WriteLine($"Total de nota: {totalNotas}");
    Console.WriteLine($"Sua média é de {media.ToString("0.##")}\n");
}

Console.WriteLine("Encerrando o programa. Pressione qualquer tecla para sair...");
Console.ReadKey();