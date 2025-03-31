using System;

namespace tp2_Infnet.Exercicios
{
    public class Exercicio2
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("=== Exercício 2: Dias até o Próximo Aniversário ===");

            DateTime dataNascimento;

            while (true)
            {
                Console.Write("Digite sua data de nascimento (dd/mm/aaaa): ");
                string input = Console.ReadLine();

                bool dataValida = DateTime.TryParseExact(
                    input,
                    "dd/MM/yyyy",
                    null,
                    System.Globalization.DateTimeStyles.None,
                    out dataNascimento
                );

                if (!dataValida)
                {
                    Console.WriteLine("Data inválida. Use o formato dd/mm/aaaa.\n");
                    continue;
                }

                if (dataNascimento > DateTime.Today)
                {
                    Console.WriteLine("A data de nascimento não pode ser no futuro.\n");
                    continue;
                }

                break;
            }

            DateTime hoje = DateTime.Today;
            DateTime proximoAniversario = new DateTime(hoje.Year, dataNascimento.Month, dataNascimento.Day);

            // Se o aniversário deste ano já passou
            if (proximoAniversario < hoje)
            {
                proximoAniversario = proximoAniversario.AddYears(1);
            }

            TimeSpan diferenca = proximoAniversario - hoje;

            Console.WriteLine($"\n Faltam {diferenca.Days} dias para o seu próximo aniversário!");
        }
    }
}
