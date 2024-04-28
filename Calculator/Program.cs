using System;
using System.Collections.Generic;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number;
            number = 255;
            int number1 = 9999;
            number1 = 123;
            // Console.WriteLine("Hello World");
            Console.WriteLine(number1);

            double number2 = 123.41;
            decimal amount = 31.12M;
            bool isReady = true;
            string name = "Programista";
            char sign = 'n';

            DateTime today = new DateTime(2020, 1, 1, 12, 0, 0);

            Robot robot = new Robot();

            List<int> lista = new List<int>() { 1, 2, 3 };
            lista.Add(4);
            lista.Remove(1);
            Console.WriteLine(lista[0]);

            List<string> lista1 = new List<string>() { "A", "B", "C" };

            int age = 20;
            string myAge = "30";
            age = int.Parse(myAge);
            myAge = age.ToString();
        }
    }


}
