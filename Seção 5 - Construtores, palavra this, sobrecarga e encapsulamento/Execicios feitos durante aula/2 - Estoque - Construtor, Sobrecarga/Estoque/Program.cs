using System;
using System.Globalization;

//Estoque utilizando construtores e Sobrecargas;

namespace Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do Produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto p = new Produto(nome, preco);

            //Caso queira adicionar um construtor padrão, sem argumentos. Na classe Produto, deve ser criado uma nova sobrecarga de construtor vazio. Exemplo na classe Produto.

            Console.WriteLine();
            Console.WriteLine($"Dados do produto: {p}");
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados {p}.");
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados {p}.");

        }
    }
}
