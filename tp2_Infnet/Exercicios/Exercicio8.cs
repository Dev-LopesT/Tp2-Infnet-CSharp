using System;
using System.Globalization;

namespace tp2_Infnet.Exercicios
{
    public class Exercicio8
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("=== Exercício 8: Classificação de Nota Escolar ===");

            double nota;

            while (true)
            {
                Console.Write("Digite a nota (0 a 10): ");
                string input = Console.ReadLine();

                if (double.TryParse(input.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out nota) && nota >= 0 && nota <= 10)
                    break;

                Console.WriteLine("Nota inválida. Digite um valor entre 0 e 10.");
            }

            string classificacao;

            if (nota < 5)
                classificacao = "Insuficiente";
            else if (nota < 7)
                classificacao = "Regular";
            else if (nota < 9)
                classificacao = "Bom";
            else
                classificacao = "Excelente";

            Console.WriteLine($"\nNota: {nota:F1} - Classificação: {classificacao}");
        }
    }
}
