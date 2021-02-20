using System;
using System.Collections.Generic;
using System.Text;

namespace Course02.Entities
{
    class PhysicalPerson : Person
    {
        public double HealthExpenses { get; set; }

        public PhysicalPerson(string name, double annualSpend, double healthExpenses) : base(name, annualSpend)
        {
            HealthExpenses = healthExpenses;
        }

        public override double Taxes()
        {
            double count = 0;

            if (AnnualSpend <= 20000.00)
            {
                count = (AnnualSpend * 0.15) - (HealthExpenses * 0.50);
                return count;
            }
            else
            {
                count = (AnnualSpend * 0.25) - (HealthExpenses * 0.50);
                return count;
            }
        }
    }
}
