using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronics_Store_OOP
{
    internal class Laptop : Device, IDeviceDetails
    {
        private bool IsGaming { get; set; }
        public Laptop(string brand, string model, decimal price, bool isGaming) : base(brand, model, price)
        {
            IsGaming = isGaming;
        }

        public override void GetDetails()
        {
            Console.WriteLine($"Brand: {Brand}\n" +
                $"Model: {Model}\n" +
                $"Price: {Price}\n" +
                $"IsGaming: {IsGaming}");
        }

        public void TurnOn()
        {
            Console.WriteLine("Laptop is Turned On");
        }

        public void TurnOff()
        {
            Console.WriteLine("Laptop is Turned Off");
        }

        public void Charge()
        {
            Console.WriteLine("Laptop is Charging");
        }
    }
}
