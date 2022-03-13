using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle.Models
{
    class Car:Vehicle
    {
        public string Brand;
        public string Model;
        public int FuelCapacity;
        public double FuelFor1Km;
        public double CurrentFuel;

        public Car(string Brand, string Model, int FuelCapacity, double FuelFor1Km, int CurrentFuel, string color, int year) : base(color, year)
        {
            this.Brand=Brand;
            this.Model = Model;
            this.FuelCapacity = FuelCapacity;
            this.FuelFor1Km = FuelFor1Km;
            this.CurrentFuel = CurrentFuel;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"{Brand} {Model} {FuelCapacity} {FuelFor1Km} {CurrentFuel} {color} {year}");
        }
        public void Drive()
        {
            int a = 28;
            double b = a * FuelFor1Km;
            if (CurrentFuel >= b)
            {
                Console.WriteLine(CurrentFuel -= b);
            }
            else if (CurrentFuel <= b)
            {
                Console.WriteLine("Catmayacaq");
            }
        }
    }
}
