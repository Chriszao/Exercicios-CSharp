 using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            //Este for percorrerá as linhas
            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                //Este for percorrerá as colunas
                for (int x = 0; x < n; x++)
                {
                    mat[i, x] = int.Parse(values[x]);
                }
            }

            Console.WriteLine("Main Diagonal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();

            int cont = 0;

            for (int i = 0; i < n; i++)
            {
                for (int x = 0; x < n; x++)
                {
                    if (mat[i, x] < 0)
                    {
                        cont++;
                    }
                }
            }

            Console.WriteLine("Negative numbers: " + cont);

        }
    }
}
