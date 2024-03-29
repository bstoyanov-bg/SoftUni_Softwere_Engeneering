﻿
using System;

namespace SoftUniParking
{
    public class Car
    {
        private string make;
        private string model;
        private int horsePower;
        private string registrationNumber;

        public Car(string make, string model, int horsePower, string registrationNumber)
        {
            this.Make = make;
            this.Model = model;
            this.HorsePower = horsePower;
            this.registrationNumber = registrationNumber;
        }
        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public int HorsePower
        {
            get { return this.horsePower; }
            set { this.horsePower = value; }
        }
        public string RegistrationNumber
        {
            get { return this.registrationNumber; }
            set { this.registrationNumber = value; }
        }

        public override string ToString()
        {
            string result =
            $"Make: {this.make} {Environment.NewLine}" +
            $"Model: {this.model} {Environment.NewLine}" +
            $"HorsePower: {this.horsePower} {Environment.NewLine}" +
            $"RegistrationNumber: {this.registrationNumber}";

            return result;
        }
    }
}