using System;
using System.Collections.Generic;
using System.Linq;

namespace P08_CarSalesmanProject
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            int numOfEngines = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();
            List<Engine> engines = new List<Engine>();

            for (int i = 0; i < numOfEngines; i++)
            {
                string[] engineInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Engine engine = CreateEngine(engineInfo);

                engines.Add(engine);
            }

            int numOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfCars; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Car car = CreateCar(carInfo, engines);

                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }


        public static Engine CreateEngine(string[] engineInfo)
        {
            Engine engine = new Engine(engineInfo[0], int.Parse(engineInfo[1]));

            if (engineInfo.Length > 2)
            {
                int displacement;

                var isDigit = int.TryParse(engineInfo[2], out displacement);

                if (isDigit)
                {
                    engine.Displacement = displacement;
                }
                else
                {
                    engine.Efficiency = engineInfo[2];
                }

                if (engineInfo.Length > 3)
                {
                    engine.Efficiency = engineInfo[3];
                }
            }

            return engine;
        }

        public static Car CreateCar(string[] carInfo, List<Engine> engines)
        {
            Engine engine = engines.Find(e => e.Model == carInfo[1]);
            
            Car car = new Car(carInfo[0], engine);

            if (carInfo.Length > 2)
            {
                int weight;

                var isDigit = int.TryParse(carInfo[2], out weight);

                if (isDigit)
                {
                    car.Weight = weight;
                }
                else
                {
                    car.Color = carInfo[2];
                }

                if (carInfo.Length > 3)
                {
                    car.Color = carInfo[3];
                }
            }

            return car;
        }
    }
}