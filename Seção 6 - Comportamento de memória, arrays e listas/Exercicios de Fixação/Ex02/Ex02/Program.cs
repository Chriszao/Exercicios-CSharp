using System;
using System.Globalization;
using System.Collections.Generic;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("How many employers will be registred: ");
            int N = int.Parse(Console.ReadLine());

            List<Empregados> list = new List<Empregados>();

            for (int i = 1; i <= N; i++)
            {
                string name;
                int id;
                double salary;

                Console.WriteLine();
                Console.WriteLine($"Employee #{i}:");

                Console.Write("Id: ");
                id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                name = Console.ReadLine();

                Console.Write("Salary: ");
                salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Empregados(id, name, salary));
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("List of employees: ");
            foreach (Empregados obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();
            Console.Write("Enter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            Empregados emp = list.Find(x => x.Id == searchId);
            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.increaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees: ");
            foreach (Empregados obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
