using System;
using System.Collections.Generic;
using System.Text;

namespace RentalCars.Category
{
    class CategoryStrategy
    {
        private bool Availability { get; set; }

        public bool  CheckAvailability(Rental rental)
        {
            
            OperationsContext context;

            switch (rental.Car.PriceCode)
            {
                case PriceCode.Luxury:
                    context = new OperationsContext(new LuxuryOperation());
                    Availability = context.ExecuteOperations(rental);
                    break;
                case PriceCode.Mini:
                    context = new OperationsContext(new MiniOperation());
                    Availability = context.ExecuteOperations(rental);
                    break;
                case PriceCode.Premium:
                    context = new OperationsContext(new PremiumOperation());
                    Availability = context.ExecuteOperations(rental);
                    break;
                default:
                    context = new OperationsContext(new BasicOperation());
                    Availability = context.ExecuteOperations(rental);
                    break;
            }

            return Availability;
        }

    }
}
