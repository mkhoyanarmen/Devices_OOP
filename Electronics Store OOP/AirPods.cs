using System;

namespace Electronics_Store_OOP
{
    internal class AirPods : Device, IDeviceDetails
    {
        private double BluetoothRange { get; set; }
        public AirPods(string brand, string model, decimal price, double bluetoothRange) : base(brand, model, price)
        {
            BluetoothRange = bluetoothRange;
        }
        public override void GetDetails()
        {
            Console.WriteLine($"Brand: {Brand}\n" +
                $"Model: {Model}\n" +
                $"Price: {Price}\n" +
                $"Bluetooth Range: {BluetoothRange}");
        }

        public void TurnOn()
        {
            Console.WriteLine("AirPods is Turned On");
        }

        public void TurnOff()
        {
            Console.WriteLine("AirPods is Turned Off");
        }

        public void Charge()
        {
            Console.WriteLine("AirPods is Charging");
        }
    }
}
