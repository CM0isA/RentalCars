using System;
using System.Collections.Generic;
using System.Text;

namespace RentalCars.Category
{
    class OperationsContext
    {
        private readonly IOperations operations;

        public OperationsContext(IOperations operations)
        {
            this.operations = operations;
        }

        public bool ExecuteOperations(Rental rental)
        {
           return operations.CheckAvailability(rental);
        }
    }
}
