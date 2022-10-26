using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_RawDataProject
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numOfCars = int.Parse(Console.ReadLine());

            List<Car> carsCatalogue = new List<Car>();

            for (int i = 0; i < numOfCars; i++)
            {
                string[] carProps = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Car car = new Car(
                    carProps[0],
                    int.Parse(carProps[1]),
                    int.Parse(carProps[2]),
                    int.Parse(carProps[3]),
                    carProps[4],
                    double.Parse(carProps[5]),
                    int.Parse(carProps[6]),
                    double.Parse(carProps[7]),
                    int.Parse(carProps[8]),
                    double.Parse(carProps[9]),
                    int.Parse(carProps[10]),
                    double.Parse(carProps[11]),
                    int.Parse(carProps[12]));

                carsCatalogue.Add(car);
            }

            string carType = Console.ReadLine();
            string[] filteredCarModels;

            if (carType == "fragile")
            {
                filteredCarModels = carsCatalogue
                     .Where(c => c.Cargo.Type == "fragile" && c.Tyres.Any(c => c.Pressure < 1))
                     .Select(c => c.Model)
                     .ToArray();
            }
            else
            {
                filteredCarModels = carsCatalogue
                    .Where(c => c.Cargo.Type == "flammable" && c.Engine.Power > 250)
                    .Select(c => c.Model)
                    .ToArray();
            }

            foreach (var car in filteredCarModels)
            {
                Console.WriteLine(car);
            }
        }
    }
}