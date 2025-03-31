using System;
using System.Globalization;

namespace tp2_Infnet.Exercicios
{
    public class Exercicio9
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("=== Exercício 9: Calculadora de Salário Líquido ===");

            double salarioBruto;

            while (true)
            {
                Console.Write("Digite o salário bruto: ");
                string input = Console.ReadLine();

                if (double.TryParse(input.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out salarioBruto) && salarioBruto >= 0)
                    break;

                Console.WriteLine("Valor inválido. Digite um número positivo.");
            }

            double percentualImposto;

            if (salarioBruto <= 1900)
                percentualImposto = 0.0;
            else if (salarioBruto <= 2800)
                percentualImposto = 0.075;
            else if (salarioBruto <= 3750)
                percentualImposto = 0.15;
            else if (salarioBruto <= 4660)
                percentualImposto = 0.225;
            else
                percentualImposto = 0.275;

            double valorImposto = salarioBruto * percentualImposto;
            double salarioLiquido = salarioBruto - valorImposto;

            Console.WriteLine();
            Console.WriteLine($"Salário Bruto : R$ {salarioBruto:F2}");
            Console.WriteLine($"Imposto ({percentualImposto * 100:F1}%) : R$ {valorImposto:F2}");
            Console.WriteLine($"Salário Líquido : R$ {salarioLiquido:F2}");
        }
    }
}
