using SemInterface.Entities;
using System;

namespace SemInterface.Services
{
    public class RentalService
    {
        public double PricePerhour { get; private set; }
        public double PricePerDay { get; private set; }
        private BrazilTaxService _brazilTaxService = new BrazilTaxService();

        public RentalService(double pricePerHour, double pricePerDay)
        {
            PricePerhour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        public void Proccessinvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0;
            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerhour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _brazilTaxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}