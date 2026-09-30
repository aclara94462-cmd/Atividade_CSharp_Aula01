using System;

class Exercicio03
{
    public static void Executar()
    {
        // Declaração das variáveis
        string nome;
        int codigo;
        string categoria;
        double preco;
        int quantidade;
        char inicial;
        bool disponivel;

        // Entrada dos dados
        Console.Write("Nome do produto: ");
        nome = Console.ReadLine();

        Console.Write("Código: ");
        codigo = int.Parse(Console.ReadLine());

        Console.Write("Categoria: ");
        categoria = Console.ReadLine();

        Console.Write("Preço: ");
        preco = double.Parse(Console.ReadLine());

        Console.Write("Quantidade em estoque: ");
        quantidade = int.Parse(Console.ReadLine());

        Console.Write("Inicial da categoria: ");
        inicial = char.Parse(Console.ReadLine());

        Console.Write("Produto disponível? (true/false): ");
        disponivel = bool.Parse(Console.ReadLine());

        // Saída dos dados
        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine("          FICHA DO PRODUTO");
        Console.WriteLine("========================================");
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Código: " + codigo);
        Console.WriteLine("Categoria: " + categoria);
        Console.WriteLine("Preço: R$ " + preco);
        Console.WriteLine("Quantidade: " + quantidade);
        Console.WriteLine("Inicial: " + inicial);
        Console.WriteLine("Disponível: " + disponivel);
        Console.WriteLine("========================================");
    }
}