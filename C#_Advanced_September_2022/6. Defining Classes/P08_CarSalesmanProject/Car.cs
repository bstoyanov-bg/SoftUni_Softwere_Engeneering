
using System;

namespace P08_CarSalesmanProject
{
    public class Car
    {
        private string model;
        private int weight;
        private string color;

        public Car(string carModel, Engine engine)
        {
            this.Model = carModel;
            this.Engine = engine;
        }
        public string Model { get; set; }

        public Engine Engine { get; set; }

        public int Weight { get; set; }

        public string Color { get; set; }


        public override string ToString()
        {
            string weight = this.Weight == 0 ? "n/a" : this.Weight.ToString();
            string color = this.Color ?? "n/a";

            string result =
                $"{this.Model}:{Environment.NewLine}" +
                $"  {this.Engine.ToString()}{Environment.NewLine}" +
                $"  Weight: {weight}{Environment.NewLine}" +
                $"  Color: {color}";

            return result;
        }
    }
}



