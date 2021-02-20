using System;

namespace EX02
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            Console.WriteLine("Insira um número qualquer: ");
            N = int.Parse(Console.ReadLine());
            
            if (N % 2 == 0)
                Console.WriteLine($"O número {N} é PAR!");
            else
            {
                Console.WriteLine($"O número {N} é IMPAR!");
            }
        }
    }
}
