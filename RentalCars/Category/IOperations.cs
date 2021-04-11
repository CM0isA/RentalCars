using System;
using System.Collections.Generic;
using System.Text;

namespace RentalCars.Category
{
    interface IOperations
    {
        public bool CheckAvailability(Rental rental);
    }
}
