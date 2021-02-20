using System;
using System.Globalization;

namespace Vetor
{
    class Program
    {
        //PARTE 1 da aula de vetores
        //Trabalhando com Vetores do Tipo STRUCT (Valor)

        /*
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma = 0.0;

            for (int i = 0; i < n; i++)
            {
                soma += vect[i];
            }

            double avg = soma / n;
            Console.WriteLine($"Altura média = {avg.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        */

        //Vetores Parte2
        //Trabalhando com vetores do tipo classe
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vect[i] = new Produto { Name = name, Price = price };
            }
            double soma = 0;

            for (int i = 0; i < n; i++)
            {
                soma += vect[i].Price;
            }

            double media = soma / n;
            Console.WriteLine($"Média de preços = {media.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
