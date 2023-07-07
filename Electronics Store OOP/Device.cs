using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronics_Store_OOP
{
    abstract class Device
    {
        protected Device() { }
        public Device(string brand, string model, decimal price)
        {
            Brand = brand;
            Model = model;
            Price = price;
        }

        protected string Brand { get; set; }
        protected string Model { get; set; }
        protected decimal Price { get; set; }
        public abstract void GetDetails();
    }
}
