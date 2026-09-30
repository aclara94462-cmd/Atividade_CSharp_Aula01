using System;

class Exercicio16
{
    public static void Executar()
    {
        string nome;
        int idade;
        string cidade;
        double altura;

        Console.Write("Nome: ");
        nome = Console.ReadLine();

        Console.Write("Idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.Write("Cidade: ");
        cidade = Console.ReadLine();

        Console.Write("Altura: ");
        altura = double.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine("          DADOS DO USUÁRIO");
        Console.WriteLine("========================================");
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Cidade: " + cidade);
        Console.WriteLine("Altura: " + altura);
        Console.WriteLine("========================================");
    }
}