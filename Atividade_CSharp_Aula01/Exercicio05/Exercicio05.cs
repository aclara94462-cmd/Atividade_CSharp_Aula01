using System;

class Exercicio05
{
    public static void Executar()
    {
        // Declaração das variáveis
        string nome;
        int idade;
        string cidade;
        string curso;
        double altura;
        char inicial;
        bool trabalha;
        bool estuda;

        // Entrada dos dados
        Console.Write("Nome: ");
        nome = Console.ReadLine();

        Console.Write("Idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.Write("Cidade: ");
        cidade = Console.ReadLine();

        Console.Write("Curso: ");
        curso = Console.ReadLine();

        Console.Write("Altura: ");
        altura = double.Parse(Console.ReadLine());

        Console.Write("Primeira letra do nome: ");
        inicial = char.Parse(Console.ReadLine());

        Console.Write("Trabalha? (true/false): ");
        trabalha = bool.Parse(Console.ReadLine());

        Console.Write("Estuda? (true/false): ");
        estuda = bool.Parse(Console.ReadLine());

        // Saída dos dados
        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine("        PERFIL DO ESTUDANTE");
        Console.WriteLine("========================================");
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Cidade: " + cidade);
        Console.WriteLine("Curso: " + curso);
        Console.WriteLine("Altura: " + altura);
        Console.WriteLine("Inicial: " + inicial);
        Console.WriteLine("Trabalha: " + trabalha);
        Console.WriteLine("Estuda: " + estuda);
        Console.WriteLine("========================================");
    }
}