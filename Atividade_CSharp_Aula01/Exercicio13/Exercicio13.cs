using System;

class Exercicio13
{
    public static void Executar()
    {
        string cliente;
        string produto;
        int quantidade;
        double valor;
        string tipoPedido;
        bool pedidoAtivo;

        Console.Write("Cliente: ");
        cliente = Console.ReadLine();

        Console.Write("Produto: ");
        produto = Console.ReadLine();

        Console.Write("Quantidade: ");
        quantidade = int.Parse(Console.ReadLine());

        Console.Write("Valor: ");
        valor = double.Parse(Console.ReadLine());

        Console.Write("Tipo do pedido: ");
        tipoPedido = Console.ReadLine();

        Console.Write("Pedido ativo? (true/false): ");
        pedidoAtivo = bool.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine("            SISTEMA DE PEDIDO");
        Console.WriteLine("========================================");
        Console.WriteLine("Cliente: " + cliente);
        Console.WriteLine("Produto: " + produto);
        Console.WriteLine("Quantidade: " + quantidade);
        Console.WriteLine("Valor: R$ " + valor);
        Console.WriteLine("Tipo do pedido: " + tipoPedido);
        Console.WriteLine("Pedido ativo: " + pedidoAtivo);
        Console.WriteLine("========================================");
    }
}