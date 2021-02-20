using System;
using System.Globalization;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo Medidas = new Retangulo();


            Console.WriteLine("Entre com a altura e largura do retângulo: ");

            Console.Write("Altura: ");
            Medidas.Altura = double.Parse(Console.ReadLine(),  CultureInfo.InvariantCulture);

            Console.Write("Largura: ");
            Medidas.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("AREA = " + Medidas.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO = " + Medidas.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + Medidas.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
