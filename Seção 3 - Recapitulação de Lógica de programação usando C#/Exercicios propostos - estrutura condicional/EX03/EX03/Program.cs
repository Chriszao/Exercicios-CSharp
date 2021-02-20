using System;

namespace EX03
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Insira dois valores: ");
            string[] Vet = Console.ReadLine().Split(' ');

            int a = int.Parse(Vet[0]), b = int.Parse(Vet[1]);

            if (a % b == 0 || b % a == 0)
                Console.WriteLine("São multiplos!");
            else
            {
                Console.WriteLine("Não são multiplos!");
            }

        }
    }
}
