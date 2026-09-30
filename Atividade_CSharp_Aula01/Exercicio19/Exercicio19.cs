using System;

class Exercicio19
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
        string localizacao;
        string responsavel;
        string categoria;
        bool funcionando;

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

        Console.Write("Localização: ");
        localizacao = Console.ReadLine();

        Console.Write("Responsável: ");
        responsavel = Console.ReadLine();

        Console.Write("Categoria: ");
        categoria = Console.ReadLine();

        Console.Write("Está funcionando? (true/false): ");
        funcionando = bool.Parse(Console.ReadLine());

        // Apresentação dos dados
        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine("   SISTEMA DE CADASTRO DE EQUIPAMENTOS");
        Console.WriteLine("========================================");
        Console.WriteLine("Equipamento: " + equipamento);
        Console.WriteLine("Marca: " + marca);
        Console.WriteLine("Modelo: " + modelo);
        Console.WriteLine("Ano de aquisição: " + anoAquisicao);
        Console.WriteLine("Valor: R$ " + valor);
        Console.WriteLine("Patrimônio: " + patrimonio);
        Console.WriteLine("Localização: " + localizacao);
        Console.WriteLine("Responsável: " + responsavel);
        Console.WriteLine("Categoria: " + categoria);
        Console.WriteLine("Funcionando: " + funcionando);
        Console.WriteLine("========================================");
    }
}