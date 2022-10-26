using System;

namespace DefiningClasses
{
    public class Car
    {
        // FIELDS (PRIVATE) {

        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double travelledDistance;

        // } FIELDS (PRIVATE)


        // CONSTRUCTOR {
        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
        }

        // } CONSTRUCTOR


        // PROPERTIES (PUBLIC) {
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public double FuelAmount
        {
            get { return this.fuelAmount; }
            set { this.fuelAmount = value; }
        }

        public double FuelConsumptionPerKilometer
        {
            get { return this.fuelConsumptionPerKilometer; }
            set { this.fuelConsumptionPerKilometer = value; }
        }

        public double TravelledDistance
        {
            get { return this.travelledDistance; }
            set { this.travelledDistance = value; }
        }

        // } PROPERTIES (PUBLIC)


        // METHODS (PUBLIC) {

        public void Drive(double kilometers)
        {
            if (kilometers * this.FuelConsumptionPerKilometer > this.FuelAmount)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else 
            {
                this.FuelAmount -= (this.FuelConsumptionPerKilometer * kilometers);
                this.TravelledDistance += kilometers;
            }
        }

        // } METHODS (PUBLIC)
    }
}