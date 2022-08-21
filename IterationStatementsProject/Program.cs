using System;

namespace IterationStatementsProject
{
    internal class Program
    {
        public static void Negative1000ToPositive1000(){
            int number = -1000;
            do
            {
                Console.WriteLine(number);
                number++;
            } while (number <= 1000);
        }
        public static void CountBy3To999()
        {
            int number = 0;
            do
            {
                number += 3;
                Console.WriteLine(number);
            }while(number < 999);
        }
        public static bool CheckForSameNumber(int a, int b)
        {
            if (a == b)
                return true;
            else
                return false;
        }
        public static void EvenOrOdd(int a)
        {
            if (a % 2 == 0)
                Console.WriteLine("It's Even!");
            else
                Console.WriteLine("It's Odd!");
        }
        public static void PositiveOrNegative(int a)
        {
            if (a > 0)
                Console.WriteLine("It is positive!");
            else if (a < 0)
                Console.WriteLine("It is negative!");
            else
                Console.WriteLine("You entered zero.");
        }
        public static void CheckVotingAge(int age)
        {
            if (age >= 18)
                Console.WriteLine("You are old enough to vote.");
            else
                Console.WriteLine("You are not old enough to vote.");
        }
        public static void IsAbsoluteValueMoreThan10(int a)
        {
            if (a >= -10 && a <= 10)
                Console.WriteLine("Your number is within -10 and 10.");
            else if (a < -10)
                Console.WriteLine("Your number is less than -10");
            else
                Console.WriteLine("Your number is greater than 10");
        }
        public static void MultiplicationTable(int a)
        {
            for (int i = 1; i < 13; i++)
                Console.WriteLine($"{i} x {a} = {i * a}");
        }
        static void Main(string[] args)
        {
            //Exercise 1
            for (int i = 1; i < 16; i++)
            {
                Console.WriteLine(i);
            }

            //Exercise 2 was a forked repo

            //Exercise 3
            Console.WriteLine("First I will count from -1000 to 1000:");
            Negative1000ToPositive1000();
            

            Console.WriteLine("Next I will count from 3 to 999 counting by 3s:");
            CountBy3To999();


            Console.WriteLine("Now you can enter two numbers and I will check if you entered the same number twice");
            Console.WriteLine("Enter your first number now:");
            int a;
            var response = int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Enter your second number now:");
            int b;
            var response2 = int.TryParse(Console.ReadLine(), out b);
            if (response == true && response2 == true)
                if (CheckForSameNumber(a, b))
                    Console.WriteLine("They were the same number!");
                else
                    Console.WriteLine("They were different numbers!");
            else
                Console.WriteLine("You did not input valid numbers!");


            Console.WriteLine("Input a number and I can tell you if it's even or odd:");
            int evenOddInput;
            var response3 = int.TryParse(Console.ReadLine(), out evenOddInput);
            if (response3)
                EvenOrOdd(evenOddInput);
            else
                Console.WriteLine("You did not enter a valid number.");


            Console.WriteLine("Input a number and I can tell you if it's positive or negative:");
            int positiveNegativeInput;
            var response4 = int.TryParse(Console.ReadLine(), out positiveNegativeInput);
            if (response4)
                PositiveOrNegative(positiveNegativeInput);
            else
                Console.WriteLine("You did not enter a valid number.");


            Console.WriteLine("If you tell me your age; I can tell you if you are old enough to vote.");
            Console.WriteLine("Enter your age:");
            int age;
            var response5 = int.TryParse(Console.ReadLine(), out age);
            if (response5)
                CheckVotingAge(age);
            else
                Console.WriteLine("You did not enter a valid number.");


            Console.WriteLine("Enter a number and I will tell you if its between -10 and 10.");
            Console.WriteLine("Number:");
            int number;
            var response6 = int.TryParse(Console.ReadLine(), out number);
            if (response6)
                IsAbsoluteValueMoreThan10(number);
            else
                Console.WriteLine("You did not enter a valid number.");



            Console.WriteLine("Enter a number to see its multiplication table:");
            int multiplier;
            var response7 = int.TryParse(Console.ReadLine(), out multiplier);
            if (response7)
                MultiplicationTable(multiplier);
            else
                Console.WriteLine("You did not enter a valid number.");
            
        }
    }
}
