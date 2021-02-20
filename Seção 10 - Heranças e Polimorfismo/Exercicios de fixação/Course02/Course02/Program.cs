using System;
using Course02.Entities;
using System.Globalization;
using System.Collections.Generic;

namespace Course02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");

                Console.Write("Physical or Legal person (P/L): ");
                char ch = char.Parse(Console.ReadLine().ToUpper());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Annual income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'P')
                {
                    Console.Write("Health expeditures: ");
                    double healthExpeditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new PhysicalPerson(name, income, healthExpeditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());

                    list.Add(new LegalPerson(name, income, employees));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAX PAID: ");

            double sum = 0;
            foreach (Person person in list)
            {
                Console.WriteLine($"{person.Name}: R${person.Taxes().ToString("F2", CultureInfo.InvariantCulture)}.");
                sum += person.Taxes();
            }
            Console.WriteLine($"TOTAL TAXES: R${sum.ToString("F2", CultureInfo.InvariantCulture)}.");
        }
    }
}
