using System;
using System.Globalization;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("insira a cotação do dólar: ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = ConversorDeMoedas.DolarParaReal(quantia, cotacao);

            Console.WriteLine($"Valor a ser pago em reais = R$ {result.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
