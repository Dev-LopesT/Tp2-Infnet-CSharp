using System;

namespace tp2_Infnet.Exercicios
{
    public class Exercicio10
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("=== Exercício 10: Contagem Regressiva ===");

            int numero;

            while (true)
            {
                Console.Write("Digite um número inteiro positivo: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out numero) && numero >= 0)
                    break;

                Console.WriteLine("Valor inválido. Digite um número inteiro maior ou igual a zero.");
            }

            Console.WriteLine("\nContagem regressiva:");

            for (int i = numero; i >= 0; i--)
            {
                if (i == 0)
                    Console.Write($"{i}");
                else
                    Console.Write($"{i}, ");
            }

            Console.WriteLine(); 
        }
    }
}
