using System;

namespace BuzzFizz
{
    class Program
    {
        // 1..100
        //Если делится на 3 -> Fizz
        //Если делится на 5 -> Buzz
        //Если делится и на 3 и на 5 -> FizzBuzz


        static void Main(string[] args)
        {
            BuzzFizz3(15);
        }

        public static void BuzzFizz(int number)
        {
            if (number >= 1 && number <= 100)
            {
                if (number % 3 == 0 && number % 5 != 0)
                    Console.WriteLine("Fizz");
                else if (number % 5 == 0 && number % 3 != 0)
                    Console.WriteLine("Buzz");
                else if (number % 3 == 0 && number % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else
                {
                    Console.WriteLine("Число не делится на 3 и на 5");
                }
            }
            else
            {
                Console.WriteLine("Введите число от 1 до 100");
            }
        }

        public static void BuzzFizz2(int number)
        {
            if (number >= 1 && number <= 100)
            {
                if (number % 3 == 0 || number % 5 == 0)
                {
                    if (number % 5 != 0)
                        Console.WriteLine("Fizz");
                    else if (number % 3 != 0)
                        Console.WriteLine("Buzz");
                    else
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                }
                else
                {
                    Console.WriteLine("Число не делится на 3 и на 5");
                }
            }
            else
            {
                Console.WriteLine("Введите число от 1 до 100");
            }
        }

        public static void BuzzFizz3(int number)
        {
            if (number % 3 == 0)
            {
                if (number % 5 != 0)
                    Console.WriteLine("Fizz");
            }
            if (number % 5 == 0)
            {
                if (number % 3 != 0)
                    Console.WriteLine("Buzz");
            }
            if (number % 3 == 0 && number % 5 == 0)
                Console.WriteLine("FizzBuzz");
        }
    }
}

