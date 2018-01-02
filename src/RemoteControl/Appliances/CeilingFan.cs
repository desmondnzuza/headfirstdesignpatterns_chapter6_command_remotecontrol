using System;

namespace RemoteControl.Appliances
{
    public class CeilingFan
    {
        private readonly string _area;

        public CeilingFan(string area)
        {
            _area = area;
        }

        public void High()
        {
            Console.WriteLine($"{_area} CeilingFan set to high");
        }

        public void Medium()
        {
            Console.WriteLine($"{_area} CeilingFan set to medium");
        }

        public void Low()
        {
            Console.WriteLine($"{_area} CeilingFan set to low");
        }

        public void Off()
        {
            Console.WriteLine($"{_area} CeilingFan off");
        }

        public void GetSpeed()
        {
            Console.WriteLine($"{_area} CeilingFan is fetching speed");
        }
    }
}
