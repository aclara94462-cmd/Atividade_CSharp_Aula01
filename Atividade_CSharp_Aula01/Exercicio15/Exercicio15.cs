using System;

class Exercicio15
{
    public static void Executar()
    {
        // Declaração das variáveis
        string nome;
        int idade;
        string cidade;
        double altura;

        // Entrada de dados
        Console.Write("Nome: ");
        nome = Console.ReadLine();

        Console.Write("Idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.Write("Cidade: ");
        cidade = Console.ReadLine();

        Console.Write("Altura: ");
        altura = double.Parse(Console.ReadLine());

        // Apresentação dos dados
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