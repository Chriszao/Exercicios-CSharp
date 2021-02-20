using System;

namespace Exercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Registro x, y;
            x = new Registro();
            y = new Registro();

            Console.WriteLine("Digite o nome da primeira pessoa: ");
            x.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade da primeira pessoa: ");
            x.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da segunda pessoa: ");
            y.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade da segunda pessoa: ");
            y.Idade = int.Parse(Console.ReadLine());

            int maiorIdade;

            if(x.Idade > y.Idade)
            {
                maiorIdade = x.Idade;
                Console.WriteLine($"{x.Nome} é a pessoa mais velha cadastrada com {maiorIdade} anos.");
            }
            else
            {
                maiorIdade = y.Idade;
                Console.WriteLine($"{y.Nome} é a pessoa mais velha cadastrada com {maiorIdade} anos.");
            }
        }
    }
}
