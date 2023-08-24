namespace CSharp
{
    class Dados
    {
        public static void dados()
        {
            Console.WriteLine("Bem-vindo ao Dice&Vice!");
            Console.Write("Digite o nome do primeiro jogador: ");
            string jogadorUm = Console.ReadLine();

            Console.Write("Digite o nome do segundo jogador, os jogadores não podem ter nomes iguais!: ");
            string jogadorDois = Console.ReadLine();

            while (jogadorDois == jogadorUm)
            {
                Console.Write("O nome do segundo jogador deve ser diferente do primeiro. Digite novamente! ");
                jogadorDois = Console.ReadLine();
            }

            Random dice = new Random();
            int[] pontosJogadorUm = new int[3];
            int[] pontosJogadorDois = new int[3];

            Console.WriteLine("\nIniciando o jogo!");

            for (int rodada = 0; rodada < 3; rodada++)
            {
                Console.WriteLine($"\nRodada {rodada + 1}");

                Console.WriteLine($"{jogadorUm}, digite 0 para jogar o dado: ");
                int inputUm;
                while (!int.TryParse(Console.ReadLine(), out inputUm) || inputUm != 0)
                {
                    Console.WriteLine("Opção inválida. Apenas digite 0 para lançar o dado.");
                    Console.WriteLine($"{jogadorUm}, digite 0 para jogar o dado: ");
                }
                pontosJogadorUm[rodada] = dice.Next(1, 7);
                Console.WriteLine($"{jogadorUm} obteve {pontosJogadorUm[rodada]} ponto(s) nesta rodada.");

                Console.WriteLine($"{jogadorDois}, digite 0 para jogar o dado: ");
                int inputDois;
                while (!int.TryParse(Console.ReadLine(), out inputDois) || inputDois != 0)
                {
                    Console.WriteLine("Opção inválida. Apenas digite 0 para lançar o dado.");
                    Console.WriteLine($"{jogadorDois}, digite 0 para jogar o dado: ");
                }
                pontosJogadorDois[rodada] = dice.Next(1, 7);
                Console.WriteLine($"{jogadorDois} obteve {pontosJogadorDois[rodada]} ponto(s) nesta rodada.");
            }

            Console.WriteLine("\nResultados:");
            int pontosTotalJogadorUm = 0;
            int pontosTotalJogadorDois = 0;

            for (int i = 0; i < 3; i++)
            {
                pontosTotalJogadorUm += pontosJogadorUm[i];
                pontosTotalJogadorDois += pontosJogadorDois[i];
                Console.WriteLine($"Rodada {i + 1}: {jogadorUm} - {pontosJogadorUm[i]}, {jogadorDois} - {pontosJogadorDois[i]}");
            }

            Console.WriteLine($"\nTotal de pontos:\n{jogadorUm} - {pontosTotalJogadorUm} pontos\n{jogadorDois} - {pontosTotalJogadorDois} pontos");

            if (pontosTotalJogadorUm > pontosTotalJogadorDois)
                Console.WriteLine($"\n{jogadorUm} venceu o Dice & Vice com {pontosTotalJogadorUm} pontos!");
            else if (pontosTotalJogadorDois > pontosTotalJogadorUm)
                Console.WriteLine($"\n{jogadorDois} venceu o Dice & Vice com {pontosTotalJogadorDois} pontos!");
            else
                Console.WriteLine("\nEmpate :(");

            Console.WriteLine("\nObrigado por jogar Dice & Vice!");
        }
    }
}


