using System;

namespace tp2_Infnet.Exercicios
{
    public class Exercicio7
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("=== Exercício 7: Verificador de Número Par ou Ímpar ===");

            int numero;

            while (true)
            {
                Console.Write("Digite um número inteiro: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out numero))
                    break;

                Console.WriteLine("Valor inválido. Digite um número inteiro.");
            }

            if (numero % 2 == 0)
                Console.WriteLine($"\nO número {numero} é par.");
            else
                Console.WriteLine($"\nO número {numero} é ímpar.");
        }
    }
}
