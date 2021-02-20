using System;

namespace EX01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;

            Console.WriteLine("Insira um número qualquer: ");
            n1 = int.Parse(Console.ReadLine());

            if (n1 >= 0)
                Console.WriteLine("Número positivo!");

            else
            {
                Console.WriteLine("Número negativo!");
            }

        }
    }
}
