using System;

namespace RentalCars
{
    class Program
    {
        static void Main(string[] args)
        {
            RentalCars store = new RentalCars("Iasi Rentals",20);

            var customer1 = new Customer("Ion Popescu");
            var customer2 = new Customer("Mihai Chirica");
            var customer3 = new Customer("Gigi Becali");



            Console.ReadKey();



            store.AddRental(new Rental(customer1, new Car(PriceCode.Premium, "Ford Focus"), 2));
            store.AddRental(new Rental(customer3, new Car(PriceCode.Regular, "Renault Clio"), 3));
            store.AddRental(new Rental(customer1, new Car(PriceCode.Premium, "BMW 330i"), 1));
            store.AddRental(new Rental(customer3, new Car(PriceCode.Premium, "Volvo XC90"), 3));
            store.AddRental(new Rental(customer2, new Car(PriceCode.Mini, "Toyota Aygo"), 2));
            store.AddRental(new Rental(customer1, new Car(PriceCode.Mini, "Hyundai i10"), 4));
            store.AddRental(new Rental(customer3, new Car(PriceCode.Premium, "Volvo XC90"), 2));
            store.AddRental(new Rental(customer3, new Car(PriceCode.Luxury, "Mercedes E320"), 1));

            Console.WriteLine(store.Statement());

            Console.ReadKey();



            Console.WriteLine(store.StatementPerCategory());
            Console.ReadKey();

            customer1.ShowPoints();
            customer2.ShowPoints();
            customer3.ShowPoints();

            RentalCars store2 = new RentalCars("Bucuresti Rentals", 30);

            store2.AddRental(new Rental(customer1, new Car(PriceCode.Premium, "Ford Focus"), 2));
            store2.AddRental(new Rental(customer3, new Car(PriceCode.Regular, "Renault Clio"), 3));
            store2.AddRental(new Rental(customer1, new Car(PriceCode.Premium, "BMW 330i"), 1));
            store2.AddRental(new Rental(customer3, new Car(PriceCode.Premium, "Volvo XC90"), 3));
            store2.AddRental(new Rental(customer2, new Car(PriceCode.Mini, "Toyota Aygo"), 2));
            store2.AddRental(new Rental(customer1, new Car(PriceCode.Mini, "Hyundai i10"), 4));
            store2.AddRental(new Rental(customer3, new Car(PriceCode.Premium, "Volvo XC90"), 2));
            store2.AddRental(new Rental(customer3, new Car(PriceCode.Luxury, "Mercedes E320"), 1));

            Console.WriteLine(store2.Statement());
            Console.ReadKey();



            Console.WriteLine(store2.StatementPerCategory());
            Console.ReadKey();

        }
    }
}
