using System;
using System.Collections.Generic;
using System.Text;
using RentalCars.Category;

namespace RentalCars.Category
{
    class LuxuryOperation : IOperations
    {
        public bool CheckAvailability(Rental rental)
        {
            if (rental.Customer.FrequentRenterPoints >= 3)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Luxury cars can only be rented to loyal customers who have at least 3 Loyalty Points");
                return false;
            }
            }

       
    }
}
