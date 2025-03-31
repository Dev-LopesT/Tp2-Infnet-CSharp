using System;
using System.Globalization;

namespace tp2_Infnet.Exercicios
{
    public class Exercicio6
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("=== Exercício 6: Cálculo de IMC ===");

            double peso, altura;

            while (true)
            {
                Console.Write("Digite seu peso em kg (ex: 70,5): ");
                string inputPeso = Console.ReadLine();

                if (double.TryParse(inputPeso.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out peso) && peso > 0)
                    break;

                Console.WriteLine("Peso inválido. Digite um número positivo.");
            }

            while (true)
            {
                Console.Write("Digite sua altura em metros (ex: 1,75): ");
                string inputAltura = Console.ReadLine();

                if (double.TryParse(inputAltura.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out altura) && altura > 0)
                    break;

                Console.WriteLine("Altura inválida. Digite um número positivo.");
            }

            double imc = peso / (altura * altura);
            string classificacao;

            if (imc < 18.5)
                classificacao = "Abaixo do peso";
            else if (imc < 25)
                classificacao = "Peso normal";
            else if (imc < 30)
                classificacao = "Sobrepeso";
            else if (imc < 35)
                classificacao = "Obesidade Grau I";
            else if (imc < 40)
                classificacao = "Obesidade Grau II";
            else
                classificacao = "Obesidade Grau III (mórbida)";

            Console.WriteLine();
            Console.WriteLine($"IMC calculado: {imc:F2}");
            Console.WriteLine($"Classificação: {classificacao}");
        }
    }
}
