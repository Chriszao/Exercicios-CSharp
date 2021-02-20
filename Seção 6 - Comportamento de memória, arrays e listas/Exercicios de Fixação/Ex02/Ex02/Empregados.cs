using System.Globalization;

namespace Ex02
{
    class Empregados
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Salary { get; private set; }

        public Empregados(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void increaseSalary(double percentage)
        {
            Salary += Salary * percentage / 100.0;
        }

        public override string ToString()
        {
            return ($"{Id},  {Name}, R$ {Salary.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
