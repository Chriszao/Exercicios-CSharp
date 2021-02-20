using ComInterface.Entities;
using System;

namespace ComInterface.Services
{
    class RentalService
    {
        public double PricePerhour { get; private set; }
        public double PricePerDay { get; private set; }
        private ITaxService _taxService;

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerhour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
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

            double tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}