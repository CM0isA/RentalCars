using System;
using System.Collections.Generic;
using System.Text;

namespace RentalCars
{
    class PriceCaculator
    {
        public virtual double CalculatePrice(Rental car, double pricePerDay)
        {
            double thisAmount = pricePerDay * 2;
            if (car.DaysRented > 2)
                thisAmount += (car.DaysRented - 2) * pricePerDay * 0.75;
            return thisAmount;

        }
    }
}
