
using System;

namespace P08_CarSalesmanProject
{
    public class Engine
    {
        private string model;
        private int power;
        private int displacement;
        private string efficiency;

        public Engine(string engineModel, int power)
        {
            this.Model = engineModel;
            this.Power = power;
        }
        public string Model { get; set; }

        public int Power { get; set; }

        public int Displacement { get; set; }

        public string Efficiency { get; set; }

        public override string ToString()
        {
            string displacement = this.Displacement == 0 ? "n/a" : this.Displacement.ToString();
            string efficiency = this.Efficiency ?? "n/a";

            string result =
                $"{this.Model}:{Environment.NewLine}" +
                $"    Power: {this.Power}{Environment.NewLine}" +
                $"    Displacement: {displacement}{Environment.NewLine}" +
                $"    Efficiency: {efficiency}";

            return result;
        }
    }
}

