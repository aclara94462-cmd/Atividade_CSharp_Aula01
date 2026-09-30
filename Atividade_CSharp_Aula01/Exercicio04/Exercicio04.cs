using System;

class Exercicio04
{
    public static void Executar()
    {
        // Declaração das variáveis
        string marca;
        string modelo;
        int ano;
        double preco;
        string categoria;
        char inicial;
        bool disponivel;

        // Entrada dos dados
        Console.Write("Marca: ");
        marca = Console.ReadLine();

        Console.Write("Modelo: ");
        modelo = Console.ReadLine();

        Console.Write("Ano: ");
        ano = int.Parse(Console.ReadLine());

        Console.Write("Preço: ");
        preco = double.Parse(Console.ReadLine());

        Console.Write("Categoria: ");
        categoria = Console.ReadLine();

        Console.Write("Primeira letra da marca: ");
        inicial = char.Parse(Console.ReadLine());

        Console.Write("Veículo disponível? (true/false): ");
        disponivel = bool.Parse(Console.ReadLine());

        // Saída dos dados
        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine("          FICHA DO VEÍCULO");
        Console.WriteLine("========================================");
        Console.WriteLine("Marca: " + marca);
        Console.WriteLine("Modelo: " + modelo);
        Console.WriteLine("Ano: " + ano);
        Console.WriteLine("Preço: R$ " + preco);
        Console.WriteLine("Categoria: " + categoria);
        Console.WriteLine("Inicial: " + inicial);
        Console.WriteLine("Disponível: " + disponivel);
        Console.WriteLine("========================================");
    }
}