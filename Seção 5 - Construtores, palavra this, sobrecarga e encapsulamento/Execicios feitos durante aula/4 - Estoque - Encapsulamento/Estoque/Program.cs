using System;
using System.Globalization;

//Estoque utilizando Encapsulamento;

namespace Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            p.SetNome("T"); 

            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());


        }
    }
}
