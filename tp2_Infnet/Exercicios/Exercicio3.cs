using System;

namespace tp2_Infnet.Exercicios
{
    public class Exercicio3
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("=== Exercício 3: Diferença Entre Duas Datas ===");

            DateTime data1, data2;

            while (true)
            {
                Console.Write("Digite a primeira data (dd/mm/aaaa): ");
                string input1 = Console.ReadLine();

                if (DateTime.TryParseExact(input1, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out data1))
                    break;

                Console.WriteLine("Data inválida. Use o formato dd/mm/aaaa.\n");
            }


            while (true)
            {
                Console.Write("Digite a segunda data (dd/mm/aaaa): ");
                string input2 = Console.ReadLine();

                if (DateTime.TryParseExact(input2, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out data2))
                    break;

                Console.WriteLine("Data inválida. Use o formato dd/mm/aaaa.\n");
            }

 
            if (data1 > data2)
            {
                DateTime temp = data1;
                data1 = data2;
                data2 = temp;
            }

            TimeSpan diferencaDias = data2 - data1;

            int anos = data2.Year - data1.Year;
            int meses = data2.Month - data1.Month;
            int dias = data2.Day - data1.Day;

            if (dias < 0)
            {
                meses--;
                dias += DateTime.DaysInMonth(data2.Year, (data2.Month == 1) ? 12 : data2.Month - 1);
            }

            if (meses < 0)
            {
                anos--;
                meses += 12;
            }

            Console.WriteLine($"\nDiferença total:");
            Console.WriteLine($"{diferencaDias.TotalDays} dias totais");
            Console.WriteLine($"{anos} anos, {meses} meses e {dias} dias");
        }
    }
}