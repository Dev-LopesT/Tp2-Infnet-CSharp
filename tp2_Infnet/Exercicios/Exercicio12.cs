using System;

namespace tp2_Infnet.Exercicios
{
    public class Exercicio12
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("=== Exercício 12: Jogo de Adivinhação ===");

            Random random = new Random();
            int numeroSecreto = random.Next(1, 101); 
            int tentativas = 0;
            int palpite;

            Console.WriteLine("Tente adivinhar o número entre 1 e 100.");

            while (true)
            {
                Console.Write("Digite seu palpite: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out palpite) || palpite < 1 || palpite > 100)
                {
                    Console.WriteLine("Palpite inválido. Digite um número entre 1 e 100.");
                    continue;
                }

                tentativas++;

                if (palpite == numeroSecreto)
                {
                    Console.WriteLine($"\nParabéns! Você acertou o número em {tentativas} tentativa(s).");
                    break;
                }
                else if (palpite < numeroSecreto)
                {
                    Console.WriteLine("O número secreto é maior.");
                }
                else
                {
                    Console.WriteLine("O número secreto é menor.");
                }
            }
        }
    }
}
