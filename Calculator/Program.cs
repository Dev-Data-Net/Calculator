using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte number;
            //number = 255;
            //number = 255;
            //var number1 = 9999;

            //number1 = 123;
            // Console.WriteLine("Hello World");
            //Console.WriteLine(number1);

            //var number2 = 123.41;
            //var amount = 31.12M;
            //var isReady = true;
            //var name = "Programista";
            //var sign = 'n';

            //DateTime today = new DateTime(2020, 1, 1, 12, 0, 0);

            //Robot robot = new Robot();

            //var lista = new List<int>() { 1, 2, 3 };
            //lista.Add(4);
            //lista.Remove(1);
            //Console.WriteLine(lista[0]);

            //List<string> lista11 = new List<string>() { "A", "B", "C" };
            //var lista1 = new List<string>() { "A", "B", "C" };

            //var age = 20;
            //var myAge = "30";
            //age = int.Parse(myAge);
            //myAge = age.ToString();

            //var robot = new Robot("1234");
            //var robot2 = new Robot("2222");
            //var robot3 = new Robot("3333");
            //var robot4 = new Robot("4444");
            //robot.SayHello();
            //robot2.SayHello();
            //robot3.SayHello();
            //robot4.SayHello();

            //var currentRobotTime = robot.GetCurrentDate();
            //robot.Name = "Robot 2020";
            //Console.WriteLine(robot.Name);

            //var sum = Calculate.Sum(1, 8);
            //Console.WriteLine(sum);

            //var robot5 = new Robot("5555");
            //robot5.SayHello();
            //Robot.SayHelloStatic();

            // typ wartościowy
            var minAge = 10;
            var maxAge = 20;
            minAge = maxAge;
            maxAge = 21;
            Console.WriteLine(minAge);

            // typ referencyjny
            var robot6 = new Robot("1") { Name = "1" };
            var robot7 = new Robot("2") { Name = "2" };
            robot6 = robot7;
            robot7.Name = "3";
            Console.WriteLine(robot6.Name);

            // typ nullowalny
            int? age = null;

        }
    }


}
