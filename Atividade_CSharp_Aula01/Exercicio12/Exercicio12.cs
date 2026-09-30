using System;

class Exercicio12
{
    public static void Executar()
    {
        string nome;
        int idade;
        string cidade;
        string evento;
        string categoria;
        int codigo;
        bool confirmada;

        Console.Write("Nome: ");
        nome = Console.ReadLine();

        Console.Write("Idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.Write("Cidade: ");
        cidade = Console.ReadLine();

        Console.Write("Evento: ");
        evento = Console.ReadLine();

        Console.Write("Categoria: ");
        categoria = Console.ReadLine();

        Console.Write("Código da inscrição: ");
        codigo = int.Parse(Console.ReadLine());

        Console.Write("Inscrição confirmada? (true/false): ");
        confirmada = bool.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine("         CADASTRO DE EVENTO");
        Console.WriteLine("========================================");
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Cidade: " + cidade);
        Console.WriteLine("Evento: " + evento);
        Console.WriteLine("Categoria: " + categoria);
        Console.WriteLine("Código: " + codigo);
        Console.WriteLine("Inscrição confirmada: " + confirmada);
        Console.WriteLine("========================================");
    }
}