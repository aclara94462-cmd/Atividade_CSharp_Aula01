using System;

class Exercicio17
{
    public static void Executar()
    {
        string nome;
        int idade;
        string cidade;
        string cargo;
        double salario;
        int codigo;
        string departamento;
        bool ativo;

        // Entrada de dados
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

        Console.Write("Código do funcionário: ");
        codigo = int.Parse(Console.ReadLine());

        Console.Write("Departamento: ");
        departamento = Console.ReadLine();

        Console.Write("Funcionário ativo? (true/false): ");
        ativo = bool.Parse(Console.ReadLine());

        // Saída dos dados
        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine("       CADASTRO DE FUNCIONÁRIO");
        Console.WriteLine("========================================");
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Cidade: " + cidade);
        Console.WriteLine("Cargo: " + cargo);
        Console.WriteLine("Salário: R$ " + salario);
        Console.WriteLine("Código: " + codigo);
        Console.WriteLine("Departamento: " + departamento);
        Console.WriteLine("Ativo: " + ativo);
        Console.WriteLine("========================================");
    }
}