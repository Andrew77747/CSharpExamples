using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyNewStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, result;
            char symbol;

            Console.WriteLine("Введите первое число: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите знак: ");
            symbol = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            b = Convert.ToDouble(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        Console.WriteLine("Ваш результат: ");
            //        Console.WriteLine(a + b);
            //        break;
            //    case '-':
            //        Console.WriteLine("Ваш результат: ");
            //        Console.WriteLine(a - b);
            //        break;
            //    case '*':
            //        Console.WriteLine("Ваш результат: ");
            //        Console.WriteLine(a * b);
            //        break;
            //    case '/':
            //        Console.WriteLine("Ваш результат: ");
            //        Console.WriteLine(a / b);
            //        break;
            //    default: 
            //        Console.WriteLine("Введите корректный символ");
            //        break;
            //}

            if (symbol == '+')
            {
                Console.WriteLine("Ваш результат: ");
                Console.WriteLine(a + b);
            }
            else if (symbol == '-')
            {
                Console.WriteLine("Ваш результат: ");
                Console.WriteLine(a - b);
            }
            else if (symbol == '*')
            {
                Console.WriteLine("Ваш результат: ");
                Console.WriteLine(a * b);
            }
            else if (symbol == '/')
            {
                Console.WriteLine("Ваш результат: ");
                Console.WriteLine(a / b);
            }
            else
            {
                Console.WriteLine("Введите корректный символ");
            }
        }
    }
}