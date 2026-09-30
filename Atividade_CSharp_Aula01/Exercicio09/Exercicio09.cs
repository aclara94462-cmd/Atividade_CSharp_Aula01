using System;

class Exercicio09
{
    public static void Executar()
    {
        string nome;
        int idade;
        string cidade;
        int codigo;
        string situacao;

        Console.Write("Nome: ");
        nome = Console.ReadLine();

        Console.Write("Idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.Write("Cidade: ");
        cidade = Console.ReadLine();

        Console.Write("Código: ");
        codigo = int.Parse(Console.ReadLine());

        Console.Write("Situação: ");
        situacao = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine("          FICHA DO CLIENTE");
        Console.WriteLine("========================================");
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Cidade: " + cidade);
        Console.WriteLine("Código: " + codigo);
        Console.WriteLine("Situação: " + situacao);
        Console.WriteLine("========================================");
    }
}