namespace CSharp;

class Pagamento
{
    public static void motoPecas()
    {
        Console.Write("Digite a identificação do vendedor: ");
        int identificaçãoVendedor = int.Parse(Console.ReadLine());
        
        Console.Write("Digite o código da peça: ");
        int codigoPeca = int.Parse(Console.ReadLine());
        
        Console.Write("Digite o preço unitário da peça: ");
        int precoUnitario = int.Parse(Console.ReadLine());
        
        Console.Write("Digite a quantidade vendida: ");
        int quantidadeVendida = int.Parse(Console.ReadLine());

        double totalVenda = precoUnitario * quantidadeVendida;
        double comissao = totalVenda * 0.05;
        
        Console.WriteLine($"Identificação do vendedor: {identificaçãoVendedor}");
        Console.WriteLine($"Código da peça: {codigoPeca}");
        Console.WriteLine($"Preço unitário da peça: {precoUnitario}");
        Console.WriteLine($"Quantidade vendida: {quantidadeVendida}");
        Console.WriteLine($"O total da venda: {totalVenda:C}");
        Console.WriteLine($"Valor da comissão: {comissao:C}");

    }