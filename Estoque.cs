namespace CSharp
{
    class Mercado
    {
        public static void estoque()
        {
            Console.Write("Digite a quantidade mínima: ");
            int quantidadeMinima = int.Parse(Console.ReadLine());
            
            Console.Write("Digite a quantidade máxima: ");
            int quantidadeMaxima = int.Parse(Console.ReadLine());

            double estoqueMedio = (quantidadeMinima + quantidadeMaxima) / 2.0;
            
            Console.WriteLine($"O estoque médio é : {estoqueMedio}");
            
        }

    }
    
}