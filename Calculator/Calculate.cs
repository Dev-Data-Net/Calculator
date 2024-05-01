using System;

namespace Calculator
{
    static class Calculate
    {
        static Calculate()
        {
            Console.WriteLine("Konstruktor statyczny.");
        }
        public static int Sum(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}
