using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronics_Store_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var airpods = new AirPods("Xiaomi", "FreeBuds 4", 15000, 12.5);
            airpods.GetDetails();
            airpods.Charge();
            Console.WriteLine();

            Laptop laptop = new Laptop("Lenovo", "IdeaPad 5", 255000, false);
            laptop.GetDetails();
            laptop.TurnOn();
            laptop.Charge();
            laptop.TurnOff();
        }
    }
}
