using System;

class Exercicio06
{
    public static void Executar()
    {
        // Declaração das variáveis
        string nome;
        int idade;
        string curso;
        string cidade;
        int matricula;
        string turno;
        bool ativo;

        // Entrada dos dados
        Console.Write("Nome: ");
        nome = Console.ReadLine();

        Console.Write("Idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.Write("Curso: ");
        curso = Console.ReadLine();

        Console.Write("Cidade: ");
        cidade = Console.ReadLine();

        Console.Write("Número da matrícula: ");
        matricula = int.Parse(Console.ReadLine());

        Console.Write("Turno: ");
        turno = Console.ReadLine();

        Console.Write("Estudante ativo? (true/false): ");
        ativo = bool.Parse(Console.ReadLine());

        // Saída dos dados
        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine("       CONFIRMAÇÃO DE MATRÍCULA");
        Console.WriteLine("========================================");
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Curso: " + curso);
        Console.WriteLine("Cidade: " + cidade);
        Console.WriteLine("Matrícula: " + matricula);
        Console.WriteLine("Turno: " + turno);
        Console.WriteLine("Estudante ativo: " + ativo);
        Console.WriteLine("========================================");
    }
}