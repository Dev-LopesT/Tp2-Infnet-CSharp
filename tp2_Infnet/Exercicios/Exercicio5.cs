using System;
using System.Globalization;

namespace tp2_Infnet.Exercicios
{
    public class Exercicio5
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("=== Exercício 5: Conversor de Temperatura ===");

            double celsius;

            while (true)
            {
                Console.Write("Digite a temperatura em graus Celsius: ");
                string input = Console.ReadLine();

                if (double.TryParse(input.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out celsius))
                    break;

                Console.WriteLine("Valor inválido. Digite um número válido (ex: 25 ou 25,5).");
            }

            double fahrenheit = celsius * 9 / 5 + 32;
            double kelvin = celsius + 273.15;

            Console.WriteLine();
            Console.WriteLine($"Temperatura em Celsius   : {celsius:F2} °C");
            Console.WriteLine($"Temperatura em Fahrenheit: {fahrenheit:F2} °F");
            Console.WriteLine($"Temperatura em Kelvin    : {kelvin:F2} K");
        }
    }
}
