using System;

class Exercicio08
{
    public static void Executar()
    {
        // Declaração das variáveis
        string titulo;
        string autor;
        int ano;
        int codigo;
        double preco;
        string categoria;
        bool disponivel;

        // Entrada dos dados
        Console.Write("Título: ");
        titulo = Console.ReadLine();

        Console.Write("Autor: ");
        autor = Console.ReadLine();

        Console.Write("Ano de publicação: ");
        ano = int.Parse(Console.ReadLine());

        Console.Write("Código: ");
        codigo = int.Parse(Console.ReadLine());

        Console.Write("Preço: ");
        preco = double.Parse(Console.ReadLine());

        Console.Write("Categoria: ");
        categoria = Console.ReadLine();

        Console.Write("Livro disponível? (true/false): ");
        disponivel = bool.Parse(Console.ReadLine());

        // Saída dos dados
        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine("            FICHA DO LIVRO");
        Console.WriteLine("========================================");
        Console.WriteLine("Título: " + titulo);
        Console.WriteLine("Autor: " + autor);
        Console.WriteLine("Ano: " + ano);
        Console.WriteLine("Código: " + codigo);
        Console.WriteLine("Preço: R$ " + preco);
        Console.WriteLine("Categoria: " + categoria);
        Console.WriteLine("Disponível: " + disponivel);
        Console.WriteLine("========================================");
    }
}