using System;

class Exercicio01
{
    public static void Executar()
    {
        // Declaração das variáveis
        string nome;
        int idade;
        string cidade;
        double altura;
        char inicial;
        bool matriculado;

        // Entrada dos dados
        Console.Write("Nome completo: ");
        nome = Console.ReadLine();

        Console.Write("Idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.Write("Cidade onde mora: ");
        cidade = Console.ReadLine();

        Console.Write("Altura: ");
        altura = double.Parse(Console.ReadLine());

        Console.Write("Primeira letra do nome: ");
        inicial = char.Parse(Console.ReadLine());

        Console.Write("Está matriculado? (true/false): ");
        matriculado = bool.Parse(Console.ReadLine());

        // Saída dos dados
        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine("          FICHA DO ALUNO");
        Console.WriteLine("========================================");
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Cidade: " + cidade);
        Console.WriteLine("Altura: " + altura);
        Console.WriteLine("Inicial: " + inicial);
        Console.WriteLine("Matriculado: " + matriculado);
        Console.WriteLine("========================================");
    }
}