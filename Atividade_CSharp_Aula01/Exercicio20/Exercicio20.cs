using System;

class Exercicio20
{
    public static void Executar()
    {
        // Dados do primeiro aluno
        string nome1;
        int idade1;
        string cidade1;
        double altura1;
        string curso1;
        bool estudanteAtivo1;

        // Entrada dos dados
        Console.Write("Nome do aluno: ");
        nome1 = Console.ReadLine();

        Console.Write("Idade: ");
        idade1 = int.Parse(Console.ReadLine());

        Console.Write("Cidade: ");
        cidade1 = Console.ReadLine();

        Console.Write("Altura: ");
        altura1 = double.Parse(Console.ReadLine());

        Console.Write("Curso: ");
        curso1 = Console.ReadLine();

        Console.Write("Estudante ativo? (true/false): ");
        estudanteAtivo1 = bool.Parse(Console.ReadLine());

        // Apresentação
        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine("             DADOS DO ALUNO");
        Console.WriteLine("========================================");
        Console.WriteLine("Nome: " + nome1);
        Console.WriteLine("Idade: " + idade1);
        Console.WriteLine("Cidade: " + cidade1);
        Console.WriteLine("Altura: " + altura1);
        Console.WriteLine("Curso: " + curso1);
        Console.WriteLine("Estudante ativo: " + estudanteAtivo1);
        Console.WriteLine("========================================");

        Console.WriteLine();
        Console.WriteLine("Para cadastrar mais alunos, seria necessário");
        Console.WriteLine("criar novas variáveis para cada aluno.");
        Console.WriteLine("Isso aumenta a quantidade de código e dificulta");
        Console.WriteLine("a organização e a manutenção do programa.");
    }
}