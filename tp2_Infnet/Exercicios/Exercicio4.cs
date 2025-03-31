using System;

namespace tp2_Infnet.Exercicios
{
    public class Exercicio4
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("=== Exercício 4: Formulário de Cadastro Simples ===");

            Console.Write("Digite seu nome completo: ");
            string nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            string idade = Console.ReadLine();

            Console.Write("Digite seu telefone: ");
            string telefone = Console.ReadLine();

            Console.Write("Digite seu e-mail: ");
            string email = Console.ReadLine();

            Console.WriteLine("\nDados Cadastrados:");
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Nome     : {nome}");
            Console.WriteLine($"Idade    : {idade}");
            Console.WriteLine($"Telefone : {telefone}");
            Console.WriteLine($"E-mail   : {email}");
            Console.WriteLine("----------------------------");
        }
    }
}
