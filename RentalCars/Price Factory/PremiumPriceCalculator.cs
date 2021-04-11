using System;
using System.Collections.Generic;
using System.Text;

namespace RentalCars
{
    internal class PremiumPriceCalculator : PriceCaculator
    {
        public override double CalculatePrice(Rental car, double pricePerDay) => pricePerDay * car.DaysRented * 1.5;
    }
}
