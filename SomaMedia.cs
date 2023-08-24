namespace CSharp;

class SomaMedia
{
    public static void soma()
    {
        {
            Console.WriteLine("Digite os seus números desejados, este programa aceita de 3 à 10 números, positivos, decimais e negativos :) ");

            double[] numeros = new double[10];
            int quantidadeDeNumeros;

            do
            {
                Console.Write("Quantos números você deseja inserir? ");
                bool Numerico = int.TryParse(Console.ReadLine(), out quantidadeDeNumeros);

                if (Numerico && quantidadeDeNumeros >= 3 && quantidadeDeNumeros <= 10)
                    break;
                
                Console.WriteLine("Por favor, digite um número válido entre 3 e 10 >:(");
                
            } while (true);

            for (int i = 0; i < quantidadeDeNumeros; i++)
            {
                Console.Write($"Digite o número {i + 1}: ");
                double.TryParse(Console.ReadLine(), out numeros[i]);
            }
            double soma = 0;
            for (int i = 0; i < quantidadeDeNumeros; i++)
            {
                soma += numeros[i];
            }
            double media = soma / quantidadeDeNumeros;

            Console.WriteLine($"A soma dos seus números é: {soma}");
            Console.WriteLine($"A média dos seus números é: {media}");

            Console.ReadKey();
        }
    }