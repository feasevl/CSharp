namespace CSharp;

class Moedas
{
    public static void moedinha()
    {
        Console.Write("Digite o valor em reais escolhido para a conversão (R$): ");
        decimal valorEmReais = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Escolha a moeda para conversão:");
        Console.WriteLine("1. Dólar Americano");
        Console.WriteLine("2. Euro");
        Console.WriteLine("3. Iene Japonês");
        Console.WriteLine("4. Libra Esterlina");

        int opcao = int.Parse(Console.ReadLine());

        decimal valorConversao = 0;

        switch (opcao)
        {
            case 1:
                valorConversao = valorEmReais / 4.98m; 
                break;
            case 2:
                valorConversao = valorEmReais / 5.41m; 
                break;
            case 3:
                valorConversao = valorEmReais / 0.034m; 
                break;
            case 4:
                valorConversao = valorEmReais / 6.34m; 
                break;
            default:
                Console.WriteLine("Opção inválida! ");
                return;
        }

        Console.WriteLine($"Valor convertido: {valorConversao:C2}");

        
        Console.WriteLine($"Seu valor em dólar americano: {valorEmReais / 4.98m:C2}");
        Console.WriteLine($"Seu valor em euro: {valorEmReais / 5.41m:C2}");
        Console.WriteLine($"Seu valor iene japonês: {valorEmReais / 0.034m:C2}");
        Console.WriteLine($"Seu valor em libra esterlina: {valorEmReais / 6.34m:C2}");
    }
}