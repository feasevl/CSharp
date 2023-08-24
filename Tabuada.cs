namespace CSharp;

class Tabuada
{
    public static void tabuada()
    {

        int firstNumberMultiplyInput;
        int numberMultiply;
        int multiplier;
            
        Console.WriteLine("Digite o número desejado para a sua tabuada");
        firstNumberMultiplyInput = Convert.ToInt32(Console.ReadLine());

        for (numberMultiply = 1; numberMultiply <= 10; ++numberMultiply)
        {
            multiplier = firstNumberMultiplyInput * numberMultiply;
            Console.WriteLine(firstNumberMultiplyInput + " * " + numberMultiply + " = " + multiplier);

        }

        Console.ReadKey();
    }

}