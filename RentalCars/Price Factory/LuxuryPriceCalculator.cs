using System;
using System.Collections.Generic;
using System.Text;

namespace RentalCars
{
    internal class LuxuryPriceCalculator : PriceCaculator
    {
        public override double CalculatePrice(Rental car,double Price) => 70 * car.DaysRented;
    }
}
