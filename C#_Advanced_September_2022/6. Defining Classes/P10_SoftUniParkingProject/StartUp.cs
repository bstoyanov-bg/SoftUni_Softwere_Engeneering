using System;
using System.Collections.Generic;

namespace SoftUniParking
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var car = new Car("Skoda", "Fabia", 65, "CC1856BG");
            var car2 = new Car("Audi", "A3", 110, "EB8787MN");
            var car3 = new Car("Mercedess", "E200", 180, "PB1485KT");
            var car4 = new Car("Opel", "Astra", 100, "CA1784PP");
            var car5 = new Car("Honda", "Accord", 150, "EB1698KB");

            //Console.WriteLine(car.ToString());
            //// Make: Skoda
            //// Model: Fabia
            //// HorsePower: 65
            //// RegistrationNumber: CC1856BG

            var parking = new Parking(5);
            Console.WriteLine(parking.AddCar(car));
            Console.WriteLine(parking.AddCar(car2));
            Console.WriteLine(parking.AddCar(car3));
            Console.WriteLine(parking.AddCar(car4));
            Console.WriteLine(parking.AddCar(car5));
            //// Successfully added new car Skoda CC1856BG

            Console.WriteLine(parking.AddCar(car));
            //// Car with that registration number, already exists!

            //Console.WriteLine(parking.AddCar(car2));
            //// Successfully added new car Audi EB8787MN

            //Console.WriteLine(parking.GetCar("EB8787MN").ToString());
            //// Make: Audi
            //// Model: A3
            //// HorsePower: 110
            //// RegistrationNumber: EB8787MN

            //Console.WriteLine(parking.RemoveCar("EB8787MN"));
            //// Successfullyremoved EB8787MN

            var carsToRemove = new List<string>
            {
                "CC1856BG",
                "PB1485KT",
                "CA1784PP",
                "EB1698KB"
            };

            parking.RemoveSetOfRegistrationNumber(carsToRemove);

            Console.WriteLine(parking.Count);
            // 1

        }
    }
}