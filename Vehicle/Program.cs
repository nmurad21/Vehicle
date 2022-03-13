using System;
using Vehicle.Models;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Car masin = new Car("Mersedes", "Cls", 80, 2, 56, "Black", 2014);
            masin.ShowInfo();
            masin.Drive();
        }
    }
}
