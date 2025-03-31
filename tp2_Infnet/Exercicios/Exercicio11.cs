using System;

namespace tp2_Infnet.Exercicios
{
    public class Exercicio11
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("=== Exercício 11: Tabuada Interativa ===");

            int numero;

            while (true)
            {
                Console.Write("Digite um número inteiro: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out numero))
                    break;

                Console.WriteLine("Valor inválido. Digite um número inteiro.");
            }

            Console.WriteLine($"\nTabuada do {numero}:");

            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
            }
        }
    }
}
