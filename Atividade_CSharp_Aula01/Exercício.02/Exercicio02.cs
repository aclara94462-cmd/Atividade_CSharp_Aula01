using System;

class Exercicio02
{
    public static void Executar()
    {
        // Declaração das variáveis
        string nome;
        int idade;
        string cidade;
        string cargo;
        double salario;
        char inicial;
        bool ativo;

        // Entrada dos dados
        Console.Write("Nome: ");
        nome = Console.ReadLine();

        Console.Write("Idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.Write("Cidade: ");
        cidade = Console.ReadLine();

        Console.Write("Cargo: ");
        cargo = Console.ReadLine();

        Console.Write("Salário: ");
        salario = double.Parse(Console.ReadLine());

        Console.Write("Inicial do nome: ");
        inicial = char.Parse(Console.ReadLine());

        Console.Write("Está ativo? (true/false): ");
        ativo = bool.Parse(Console.ReadLine());

        // Saída dos dados
        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine("       FICHA PROFISSIONAL");
        Console.WriteLine("========================================");
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Cidade: " + cidade);
        Console.WriteLine("Cargo: " + cargo);
        Console.WriteLine("Salário: R$ " + salario);
        Console.WriteLine("Inicial: " + inicial);
        Console.WriteLine("Ativo: " + ativo);
        Console.WriteLine("========================================");
    }
}