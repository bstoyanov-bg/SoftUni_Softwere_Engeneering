using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P06_VehicleCatalogueProject
{
    class P06_VehicleCatalogueProject
    {
        static void Main(string[] args)
        {
            List<Vechicle> vechicles = new List<Vechicle>();

            while (true)
            {
                string[] inputArgs = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                if (inputArgs[0] == "End")
                {
                    break;
                }

                VechicleType vechicleType;
                bool isVechicleTypeParseSuccesful = Enum.TryParse(inputArgs[0], true, out vechicleType);

                if (isVechicleTypeParseSuccesful)
                {
                    string vechicleModel = inputArgs[1];
                    string vechicleColor = inputArgs[2];
                    int vechicleHorsepower = int.Parse(inputArgs[3]);

                    var currentVechicle = new Vechicle(vechicleType, vechicleModel, vechicleColor, vechicleHorsepower);
                    vechicles.Add(currentVechicle);
                }

            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Close the Catalogue")
                {
                    break;
                }

                var desiredVechicle = vechicles.FirstOrDefault(vechicle => vechicle.Model == command);

                Console.WriteLine(desiredVechicle);
            }

            var cars = vechicles.Where(vechicle => vechicle.Type == VechicleType.Car).ToList();
            var trucks = vechicles.Where(vechicle => vechicle.Type == VechicleType.Truck).ToList();

            double carsAvgHorsepower = cars.Count > 0 ? cars.Average(car => car.Horsepower) : 0.00;
            double trucksAvgHorsepower = trucks.Count > 0 ? trucks.Average(truck => truck.Horsepower) : 0.00;

            Console.WriteLine($"Cars have average horsepower of: {carsAvgHorsepower:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAvgHorsepower:f2}.");
        }
    }

    enum VechicleType
    {
        Car,
        Truck
    }
    class Vechicle
    {
        public Vechicle(VechicleType type, string model, string color, int horsepower)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }
        public VechicleType Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Type: {Type}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Horsepower: {Horsepower}");

            return sb.ToString().TrimEnd();
        }
    }
}