using System;

class Exercicio14
{
    public static void Executar()
    {
        string cliente;
        string equipamento;
        int codigo;
        int dias;
        double valor;
        bool equipamentoDisponivel;

        Console.Write("Cliente: ");
        cliente = Console.ReadLine();

        Console.Write("Equipamento: ");
        equipamento = Console.ReadLine();

        Console.Write("Código do equipamento: ");
        codigo = int.Parse(Console.ReadLine());

        Console.Write("Quantidade de dias: ");
        dias = int.Parse(Console.ReadLine());

        Console.Write("Valor da locação: ");
        valor = double.Parse(Console.ReadLine());

        Console.Write("Equipamento disponível? (true/false): ");
        equipamentoDisponivel = bool.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine("          SISTEMA DE LOCAÇÃO");
        Console.WriteLine("========================================");
        Console.WriteLine("Cliente: " + cliente);
        Console.WriteLine("Equipamento: " + equipamento);
        Console.WriteLine("Código: " + codigo);
        Console.WriteLine("Dias de locação: " + dias);
        Console.WriteLine("Valor: R$ " + valor);
        Console.WriteLine("Equipamento disponível: " + equipamentoDisponivel);
        Console.WriteLine("========================================");
    }
}