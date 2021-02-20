using System;
using System.Globalization;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Pensao[] pensao = new Pensao[10];

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string name, email;
                int quarto;

                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");

                Console.Write("Nome do estudante: ");
                name = Console.ReadLine();

                Console.Write("Email do estudante: ");
                email = Console.ReadLine();

                Console.Write("Qual quarto deseja alugar? ");
                quarto = int.Parse(Console.ReadLine());

                pensao[quarto] = new Pensao(name, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (pensao[i] != null)
                    Console.WriteLine(i + ": " + pensao[i]);
            }
            
        }
    }
}
