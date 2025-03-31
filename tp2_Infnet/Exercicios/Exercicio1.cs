using System;

namespace tp2_Infnet.Exercicios
{
    public class Exercicio1
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("=== Exercício 1: Cálculo de Idade Precisa ===");

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

            int anos = hoje.Year - dataNascimento.Year;
            int meses = hoje.Month - dataNascimento.Month;
            int dias = hoje.Day - dataNascimento.Day;

            if (dias < 0)
            {
                meses--;
                dias += DateTime.DaysInMonth(hoje.Year, (hoje.Month == 1) ? 12 : hoje.Month - 1);
            }

            if (meses < 0)
            {
                anos--;
                meses += 12;
            }

            Console.WriteLine($"\n Idade exata: {anos} anos, {meses} meses e {dias} dias.");
        }
    }
}
