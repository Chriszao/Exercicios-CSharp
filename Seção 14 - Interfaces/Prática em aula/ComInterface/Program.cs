using System;
using System.Globalization;
using ComInterface.Entities;
using ComInterface.Services;

namespace ComInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");

            Console.Write("Car model: ");
            string model = Console.ReadLine();

            Console.Write("Pickup (dd/MM/YYYY HH:MM): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            
            Console.Write("Return (dd/MM/YYYY HH:MM): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour: ");
            double Hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture
            );

            Console.Write("Enter price per day: ");
            double Day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture
            );

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));
            
            RentalService rentalService = new RentalService(Hour, Day, new BrazilTaxService());

            rentalService.Proccessinvoice(carRental);

            Console.WriteLine("INVOICE: ");
            Console.WriteLine(carRental.Invoice);
        }
    }
}
k