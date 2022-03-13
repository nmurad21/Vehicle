using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle.Models
{
    class Vehicle
    {
        public string color;
        public int year;     
        
        public Vehicle(string color,int year)
        {
            this.color = color;
            this.year = year;
        }
    }
}
