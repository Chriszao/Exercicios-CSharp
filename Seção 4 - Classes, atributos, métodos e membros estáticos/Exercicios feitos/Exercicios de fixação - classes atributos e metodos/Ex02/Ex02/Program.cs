using System;
using System.Globalization;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas p = new Pessoas();

            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            p.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            p.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Funcionário: {p}");

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            p.AumentarSalario(porcentagem);

            Console.WriteLine($"Dados atualizados: {p}");
        }
    }
}
