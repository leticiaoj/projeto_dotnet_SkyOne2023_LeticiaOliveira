Console.WriteLine("Digite a nota do primeiro semestre:");
decimal notaSemestre1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a nota do segundo semestre:");
decimal notaSemestre2 = Convert.ToDecimal(Console.ReadLine());

decimal mediaAluno = (notaSemestre1 + notaSemestre2) / 2;

Console.WriteLine("Sua média é de " + mediaAluno.ToString("0.00"));