using System;

namespace EX04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a hora inicial e a hora final do jogo: ");
            string[] V = Console.ReadLine().Split(' ');

            int ini = int.Parse(V[0]), fin = int.Parse(V[1]);
            int dur;

            if (ini < fin)

                dur = fin - ini;

            else
            {
                dur = 24 - fin + ini;

            }
            Console.WriteLine($"O jogo iniciou {ini} Hora(s) e terminou {fin} Horas, com uma duração de {dur} Horas.");

        }
    }
}
