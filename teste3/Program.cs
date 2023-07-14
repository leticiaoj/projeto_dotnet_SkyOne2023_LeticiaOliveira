Console.WriteLine("Bem-vindo ao Teste 03!");

while (true)
{
    Console.WriteLine("\nInforme o nome do aluno (ou digite 'sair' para encerrar):");
    string nome = Console.ReadLine();

    if (nome.ToLower() == "sair")
        break;

    Console.WriteLine($"Qual foi a nota do primeiro semestre do aluno {nome}?");
    double nota1;
    if (!double.TryParse(Console.ReadLine(), out nota1))
    {
        Console.WriteLine("Entrada inválida. Por favor, digite uma nota válida.");
        continue;
    }

    Console.WriteLine($"Qual foi a nota do segundo semestre do aluno {nome}?");
    double nota2;
    if (!double.TryParse(Console.ReadLine(), out nota2))
    {
        Console.WriteLine("Entrada inválida. Por favor, digite uma nota válida.");
        continue;
    }

    double media = (nota1 + nota2) / 2;
    Console.WriteLine($"Média: {media.ToString("0.#")}");

    if (media >= 6.0)
    {
        Console.WriteLine("O aluno foi aprovado.");
    }
    else
    {
        Console.WriteLine("O aluno foi reprovado.");
    }
}

Console.WriteLine("\nEncerrando o programa. Pressione qualquer tecla para sair...");
Console.ReadKey();
