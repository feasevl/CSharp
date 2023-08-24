namespace CSharp;

class Numeros
{
    static void Main()
    {
        int firstNumberinput;
        int secondNumberInput;

        Console.WriteLine("Digite seu 1° número");
        firstNumberinput = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite seu 2° número");
        secondNumberInput = Convert.ToInt32(Console.ReadLine());
      
        Console.WriteLine("Escolha a sua operação desejada!:");
        Console.WriteLine("\t 1 - Soma");
        Console.WriteLine("\t 2 - Subtração");
        Console.WriteLine("\t 3 - Multiplicação");
        Console.WriteLine("\t 4 - Divisão");
        Console.WriteLine("\t 0 - Sair da calculadora");
        Console.WriteLine("Qual é a sua escolha?");

        switch (Console.ReadLine())
        {
            case "1":
                Console.WriteLine($"Seu resultado é: {firstNumberinput} + {secondNumberInput} = " + (firstNumberinput + secondNumberInput));
                break;
            case "2":
                Console.WriteLine($"Seu resultado é: {firstNumberinput} - {secondNumberInput} = " + (firstNumberinput - secondNumberInput));
                break;
            case "3":
                Console.WriteLine($"Seu resultado é: {firstNumberinput} * {secondNumberInput} = " + (firstNumberinput * secondNumberInput));
                break;
            case "4":
                if ((firstNumberinput == 0) || (secondNumberInput == 0))
                {
                    Console.WriteLine("Não é possível realizar a divisão por 0");
                }
                else
                {
                    Console.WriteLine($"Seu resultado é: {firstNumberinput} / {secondNumberInput} = " + (firstNumberinput / secondNumberInput));
                }
                break;
            case "0":
                Console.WriteLine("Obrigada por testar a calculadora, para usa-la, rode o programa novamente");
                break;
        }

    }

}