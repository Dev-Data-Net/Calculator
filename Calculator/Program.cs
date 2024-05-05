using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj 1. liczbę: \t ");
            var number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Jaką operację chcesz wykonać? \n Możlwe operacje to:\n +\n -\n *\n /");
            var action = Console.ReadLine();

            Console.WriteLine("Podaj 2. liczbę: \t ");
            var number2 = int.Parse(Console.ReadLine());

            var result = 0;

            switch (action)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;
                default:
                    throw new Exception("Wybrałeś złą operację.");
            }
            Console.WriteLine("Wynik Twojego działania to: " + result);
        }
    }
}
