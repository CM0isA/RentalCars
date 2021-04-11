using System;
using System.Collections.Generic;
using System.Text;

namespace RentalCars
{
    class PriceCalculatorFactory
    {
        public PriceCaculator GetPriceCalculator(Rental car)
        {

            switch(car.Car.PriceCode)
            {                
                case PriceCode.Premium:
                    return new PremiumPriceCalculator();
                case PriceCode.Mini:
                    return new MiniPriceCalculator();
                case PriceCode.Luxury:
                    return new LuxuryPriceCalculator();
                default:
                    return new PriceCaculator();
            }

        }
    }
}
