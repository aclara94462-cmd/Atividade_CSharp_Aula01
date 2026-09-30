using System;

class Exercicio07
{
    public static void Executar()
    {
        // Declaração das variáveis
        string equipamento;
        string marca;
        string modelo;
        int anoAquisicao;
        double valor;
        int patrimonio;
        bool funcionamento;

        // Entrada dos dados
        Console.Write("Equipamento: ");
        equipamento = Console.ReadLine();

        Console.Write("Marca: ");
        marca = Console.ReadLine();

        Console.Write("Modelo: ");
        modelo = Console.ReadLine();

        Console.Write("Ano de aquisição: ");
        anoAquisicao = int.Parse(Console.ReadLine());

        Console.Write("Valor: ");
        valor = double.Parse(Console.ReadLine());

        Console.Write("Número do patrimônio: ");
        patrimonio = int.Parse(Console.ReadLine());

        Console.Write("Está funcionando? (true/false): ");
        funcionamento = bool.Parse(Console.ReadLine());

        // Saída dos dados
        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine("        ETIQUETA DO EQUIPAMENTO");
        Console.WriteLine("========================================");
        Console.WriteLine("Equipamento: " + equipamento);
        Console.WriteLine("Marca: " + marca);
        Console.WriteLine("Modelo: " + modelo);
        Console.WriteLine("Ano de aquisição: " + anoAquisicao);
        Console.WriteLine("Valor: R$ " + valor);
        Console.WriteLine("Patrimônio: " + patrimonio);
        Console.WriteLine("Funcionamento: " + funcionamento);
        Console.WriteLine("========================================");
    }
}