using System;
using System.Globalization;

namespace Exercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            DadosFuncionario p1, p2;
            p1 = new DadosFuncionario();
            p2 = new DadosFuncionario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            p1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            p2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double mediaSalario;

            mediaSalario = (p1.Salario + p2.Salario) / 2.0;
            Console.WriteLine($"Salário médio: {mediaSalario.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
