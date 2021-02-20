using System;
using System.Collections.Generic;
using System.Text;

namespace Course02.Entities
{
    class LegalPerson : Person
    {
        public int Employees { get; set; }

        public LegalPerson(string name, double annualSpend, int employees) : base(name, annualSpend)
        {
            Employees = employees;
        }

        public override double Taxes()
        {
            double count = 0;

            if (Employees > 10)
            {
                count = AnnualSpend * 0.14;
                return count;
            }
            else
            {
                count = AnnualSpend * 0.16;
                return count;
            }
        }
    }
}
