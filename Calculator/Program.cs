using System;
using System.Collections.Generic;

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

            //// typ wartościowy
            //var minAge = 10;
            //var maxAge = 20;
            //minAge = maxAge;
            //maxAge = 21;
            //Console.WriteLine(minAge);

            //// typ referencyjny
            //var robot6 = new Robot("1") { Name = "1" };
            //var robot7 = new Robot("2") { Name = "2" };
            //robot6 = robot7;
            //robot7.Name = "3";
            //Console.WriteLine(robot6.Name);

            //// typ nullowalny
            //int? age = null;

            //var minAge = 10;
            //var maxAge = 20;

            //Console.WriteLine("Proszę podaj swój wiek: ");
            //var age = int.Parse(Console.ReadLine());

            //// instrukcja warunkowa if
            //if (age >= minAge && age <= maxAge)
            //{
            //    Console.WriteLine("Możesz dołączyć do klubu.");
            //}
            //else
            //{
            //    Console.WriteLine("Nie możesz dołączyć do klubu.");
            //}


            //// switch
            //var number = int.Parse(Console.ReadLine());

            //switch (number)
            //{
            //    case 1:
            //        Console.WriteLine("Wybrałeś 1.");
            //        break;
            //    case 2:
            //        Console.WriteLine("Wybrałeś 2.");
            //        break;
            //    default:
            //        Console.WriteLine("Wybrałeś złą wartość.");
            //        break;


            //}

            // pętla while
            //var i = 0;
            //while (i <= 100)
            //{
            //    if (i == 39)
            //    {
            //        i++;
            //        continue;
            //        // break;
            //    }
            //    Console.WriteLine(i);
            //    i++;

            //}
            //// pętla do while
            //do
            //{
            //}
            //while (true);

            //// pętla for
            //int length = 100;
            //for (int j = 0; j < length; j++)
            //{
            //    Console.WriteLine(j);
            //}

            //// pętla for each
            //var numbers5 = new List<int>();
            //Console.WriteLine("Proszę podaj 5 liczb, każdą zatwierdż enterem.");

            //for (int n = 0; n < 5; n++)
            //{
            //    numbers5.Add(int.Parse(Console.ReadLine()));
            //}

            //Console.WriteLine("Twoje liczby to: ");

            //foreach (var item in numbers5)
            //{
            //    Console.WriteLine(item);
            //}

            // rzucanie wyjątków
            try
            {
                Console.WriteLine("Dzielenie dwóch liczb. \n Podaj dzielną:");
                var dividend = decimal.Parse(Console.ReadLine());

                Console.WriteLine("\n Podaj dzielnik: ");
                var divider = decimal.Parse(Console.ReadLine());

                var result = dividend / divider;

                Console.WriteLine(" \n Iloraz wynosi: \n " + result);
            }
            catch (DivideByZeroException ex)
            {
                // logika odpowiedzialna za zapisywanie informacji o błędzie do pliku
                Console.WriteLine("Nie można dzielić przez 0.");
                throw ex;
            }
            catch (Exception ex)
            {
                // logika odpowiedzialna za zapisywanie informacji o błędzie do pliku
                Console.WriteLine("Nieprawidłowe dane."); // można też wpisać ex.Message
            }
            finally
            {
                // tekst lub kod, który zostanie wykonany zawsze, dzięki finally.
                Console.WriteLine("Kod po try catch.");
            }
            


        }



    }
}
