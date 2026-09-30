using System;

class Exercicio10
{
    public static void Executar()
    {
        string nome;
        int idade;
        string cidade;
        string curso;
        string email;
        int codigo;
        string turno;
        bool inscricaoAtiva;

        Console.Write("Nome: ");
        nome = Console.ReadLine();

        Console.Write("Idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.Write("Cidade: ");
        cidade = Console.ReadLine();

        Console.Write("Curso escolhido: ");
        curso = Console.ReadLine();

        Console.Write("E-mail: ");
        email = Console.ReadLine();

        Console.Write("Código da inscrição: ");
        codigo = int.Parse(Console.ReadLine());

        Console.Write("Turno: ");
        turno = Console.ReadLine();

        Console.Write("Inscrição ativa? (true/false): ");
        inscricaoAtiva = bool.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine("          FICHA DE INSCRIÇÃO");
        Console.WriteLine("========================================");
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Cidade: " + cidade);
        Console.WriteLine("Curso: " + curso);
        Console.WriteLine("E-mail: " + email);
        Console.WriteLine("Código: " + codigo);
        Console.WriteLine("Turno: " + turno);
        Console.WriteLine("Inscrição ativa: " + inscricaoAtiva);
        Console.WriteLine("========================================");
    }
}