using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Classic.Product
{
    public class Vehicle
    {
        public string Name { get; set; }
        public string Motor { get; set; }
        public string Wheels { get; set; }
        public double MaxSpeed { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"Vehicle Name: {Name}");
            Console.WriteLine($"Motor: {Motor}");
            Console.WriteLine($"Wheels: {Wheels}");
            Console.WriteLine($"Max Speed: {MaxSpeed} km/h");
        }
    }
}
