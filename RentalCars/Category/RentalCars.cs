using System;
using System.Collections.Generic;
using RentalCars.Category;

namespace RentalCars
{
    public class RentalCars
    {
        private readonly List<Rental> _rentals = new List<Rental>();
        public string Name { get; }
        public double PricePerDay { get; private set; }

        public RentalCars(string name, double pricePerDay)
        {
            Name = name;
            PricePerDay = pricePerDay;
        }

        public void AddRental(Rental rental)
        {
            var factory = new PriceCalculatorFactory();
            var Availability = new CategoryStrategy();

            if (Availability.CheckAvailability(rental))
            {
                var calculator = factory.GetPriceCalculator(rental);
                var price = calculator.CalculatePrice(rental, PricePerDay);
                rental.Price = ApplyDiscount(rental, price);
                UpdateLoyaltyPoints(rental);

                _rentals.Add(rental);
                rental.Customer.AddRental(rental);
                
            }
            else
                Console.WriteLine("The customer doesn't meet the requirements to rent this type of vehicle");

        }

        public string Statement()
        {
            double totalAmount = 0;

            var r = "Rental Record for " + Name + "\n";
            r += "------------------------------\n";

            foreach (var car in _rentals)
            {
                r += car.Customer.Name + "\t" + car.Car.Model + "\t" + car.DaysRented + "d \t" + car.Price + " EUR\n";
                totalAmount += car.Price;
            }
            r += "------------------------------\n";
            r += "Total revenue " + totalAmount + " EUR\n";

            return r;
        }

        public static void UpdateLoyaltyPoints(Rental rental)
        {
            int frequentRenterPoints = 1;
            if (rental.Car.PriceCode == PriceCode.Premium
                && rental.DaysRented > 1)
                frequentRenterPoints++;
            rental.Customer.FrequentRenterPoints += frequentRenterPoints;
        }
        

        private static double ApplyDiscount(Rental car, double thisAmount)
        {
            if (car.Customer.FrequentRenterPoints >= 5 && car.Car.PriceCode != PriceCode.Luxury)
            {
                thisAmount = thisAmount * 0.95;
            }

            return thisAmount;
        }


        public string StatementPerCategory()
        {
            double regular = 0;
            double luxury = 0;
            double mini = 0;
            double premium = 0;

            var r = "Rental Recorde per Category for " +  this.Name + "\n";
            r += "Category " + "Total Income"+ "\n";
            r += "------------------------------\n";

            foreach (var car in _rentals)
            {
               switch(car.Car.PriceCode)
                {
                    case PriceCode.Regular:
                        regular += car.Price;
                        break;
                    case PriceCode.Mini:
                        mini += car.Price;
                        break;
                    case PriceCode.Premium:
                        premium += car.Price;
                        break;
                    case PriceCode.Luxury:
                        luxury += car.Price;
                        break;
                }    
                
            }

            r += PriceCode.Regular + "\t" + regular + "EUR\n";
            r += PriceCode.Premium + "\t" + premium + "EUR\n";
            r += PriceCode.Mini + "\t" + mini + "EUR\n";
            r += PriceCode.Luxury + "\t" + luxury + "EUR\n";
            return r;
        }
    }
}