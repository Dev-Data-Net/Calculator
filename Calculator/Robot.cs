using System;

namespace Calculator
{
    class Robot
    {
        private string _serialNumber;
        public string Name;
        public Robot(string serialNumber)
        {
            Console.WriteLine("Konstruktor");
            _serialNumber = serialNumber;

        }

        public void SayHello()
        {
            Console.WriteLine("Cześć, jestem robot. Mój numer seryjny to: " + _serialNumber);
        }

        public DateTime GetCurrentDate()
        {
            var currentTime = DateTime.Now;
            return currentTime;
        }
    }
}
