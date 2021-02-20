namespace Course02.Entities
{
    abstract class Person
    {
        public string Name { get; set; }
        public double AnnualSpend { get; set; }

        public Person(string name, double annualSpend)
        {
            Name = name;
            AnnualSpend = annualSpend;
        }

        public abstract double Taxes();
    }
}
