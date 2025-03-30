using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите высоту треугольника: ");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите ширину треугольника: ");
            int width = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                string symbol = "#";

                int j = 1;
                
                for ( ; j < width; )
                {
                    Console.Write(symbol);
                    break;
                }
                Console.WriteLine();

                j++;
            }

        }
    }
}
