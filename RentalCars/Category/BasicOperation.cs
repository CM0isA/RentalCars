using System;
using System.Collections.Generic;
using System.Text;
using RentalCars.Category;

namespace RentalCars.Category
{
    class BasicOperation : IOperations
    {
        public bool CheckAvailability(Rental rental)
        {
            return true;
        }

       
    }
}
