using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Car> carsCollection = new Dictionary<string, Car>();

            int numOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfCars; i++)
            {
                string carInput = Console.ReadLine();

                string[] carInfo = carInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string carModel = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsumptionPerKilometer = double.Parse(carInfo[2]);

                Car car = new Car(carModel, fuelAmount, fuelConsumptionPerKilometer);

                carsCollection.Add(carModel, car);
            }

            string commandInput = Console.ReadLine();

            while (commandInput != "End")
            {
                string[] carActions = commandInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string carModelToDrive = carActions[1];
                double kilometersToDrive = double.Parse(carActions[2]);

                Car car = carsCollection[carModelToDrive];

                car.Drive(kilometersToDrive);

                commandInput = Console.ReadLine();
            }

            foreach (var car in carsCollection)
            {
                Console.WriteLine($"{car.Key} {car.Value.FuelAmount:f2} {car.Value.TravelledDistance}");
            }
        }
    }
}