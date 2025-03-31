using tp2_Infnet.Exercicios;

class Program
{
    static void Main(string[] args)
    {
        string escolha = "";

        do
        {
            Console.Clear();
            Console.WriteLine("=== TP2 - INFNET ===");
            Console.WriteLine("Escolha o exercício para rodar:");
            Console.WriteLine("1  - Exercício 1");
            Console.WriteLine("2  - Exercício 2");
            Console.WriteLine("3  - Exercício 3");
            Console.WriteLine("4  - Exercício 4");
            Console.WriteLine("5  - Exercício 5");
            Console.WriteLine("6  - Exercício 6");
            Console.WriteLine("7  - Exercício 7");
            Console.WriteLine("8  - Exercício 8");
            Console.WriteLine("9  - Exercício 9");
            Console.WriteLine("10 - Exercício 10");
            Console.WriteLine("11 - Exercício 11");
            Console.WriteLine("12 - Exercício 12");
            Console.WriteLine("13 - Executar todos os exercícios");
            Console.WriteLine("14 - Sair");
            Console.Write("Digite a opção: ");
            escolha = Console.ReadLine();

            Console.Clear();

            switch (escolha)
            {
                case "1": Exercicio1.Executar(); break;
                case "2": Exercicio2.Executar(); break;
                case "3": Exercicio3.Executar(); break;
                case "4": Exercicio4.Executar(); break;
                case "5": Exercicio5.Executar(); break;
                case "6": Exercicio6.Executar(); break;
                case "7": Exercicio7.Executar(); break;
                case "8": Exercicio8.Executar(); break;
                case "9": Exercicio9.Executar(); break;
                case "10": Exercicio10.Executar(); break;
                case "11": Exercicio11.Executar(); break;
                case "12": Exercicio12.Executar(); break;
                case "13":
                    Exercicio1.Executar();
                    Pausar();
                    Exercicio2.Executar();
                    Pausar();
                    Exercicio3.Executar();
                    Pausar();
                    Exercicio4.Executar();
                    Pausar();
                    Exercicio5.Executar();
                    Pausar();
                    Exercicio6.Executar();
                    Pausar();
                    Exercicio7.Executar();
                    Pausar();
                    Exercicio8.Executar();
                    Pausar();
                    Exercicio9.Executar();
                    Pausar();
                    Exercicio10.Executar();
                    Pausar();
                    Exercicio11.Executar();
                    Pausar();
                    Exercicio12.Executar();
                    break;
                case "14":
                    Console.WriteLine("Encerrando o programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            if (escolha != "14")
            {
                Console.WriteLine("\nPressione Enter para voltar ao menu...");
                Console.ReadLine();
            }

        } while (escolha != "14");
    }

    static void Pausar()
    {
        Console.WriteLine("\nPressione Enter para continuar...");
        Console.ReadLine();
        Console.Clear();
    }
}
