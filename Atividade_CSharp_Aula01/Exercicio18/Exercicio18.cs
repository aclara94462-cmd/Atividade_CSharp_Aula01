using System;

class Exercicio18
{
    public static void Executar()
    {
        string cliente;
        string placa;
        string modelo;
        string cidade;
        string horarioEntrada;
        int horas;
        double valor;
        bool ativo;

        Console.Write("Nome do cliente: ");
        cliente = Console.ReadLine();

        Console.Write("Placa do veículo: ");
        placa = Console.ReadLine();

        Console.Write("Modelo do veículo: ");
        modelo = Console.ReadLine();

        Console.Write("Cidade: ");
        cidade = Console.ReadLine();

        Console.Write("Horário de entrada: ");
        horarioEntrada = Console.ReadLine();

        Console.Write("Quantidade de horas: ");
        horas = int.Parse(Console.ReadLine());

        Console.Write("Valor: ");
        valor = double.Parse(Console.ReadLine());

        Console.Write("Estacionamento ativo? (true/false): ");
        ativo = bool.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine("       CONTROLE DE ESTACIONAMENTO");
        Console.WriteLine("========================================");
        Console.WriteLine("Cliente: " + cliente);
        Console.WriteLine("Placa: " + placa);
        Console.WriteLine("Modelo: " + modelo);
        Console.WriteLine("Cidade: " + cidade);
        Console.WriteLine("Horário de entrada: " + horarioEntrada);
        Console.WriteLine("Horas: " + horas);
        Console.WriteLine("Valor: R$ " + valor);
        Console.WriteLine("Ativo: " + ativo);
        Console.WriteLine("========================================");
    }
}