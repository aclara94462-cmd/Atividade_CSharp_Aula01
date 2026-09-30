using System;

class Exercicio11
{
    public static void Executar()
    {
        string identificacao;
        string nome;
        int idade;
        string cidade;
        string motivo;
        int codigo;
        bool concluido;

        Console.Write("Identificação: ");
        identificacao = Console.ReadLine();

        Console.Write("Nome: ");
        nome = Console.ReadLine();

        Console.Write("Idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.Write("Cidade: ");
        cidade = Console.ReadLine();

        Console.Write("Motivo do atendimento: ");
        motivo = Console.ReadLine();

        Console.Write("Código do atendimento: ");
        codigo = int.Parse(Console.ReadLine());

        Console.Write("Atendimento concluído? (true/false): ");
        concluido = bool.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine("        SISTEMA DE ATENDIMENTO");
        Console.WriteLine("========================================");
        Console.WriteLine("Identificação: " + identificacao);
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Cidade: " + cidade);
        Console.WriteLine("Motivo: " + motivo);
        Console.WriteLine("Código: " + codigo);
        Console.WriteLine("Concluído: " + concluido);
        Console.WriteLine("========================================");
    }
}