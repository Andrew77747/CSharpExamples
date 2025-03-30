using System;

namespace ShowStringAndSymbolAmountMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ: ");
            string symbol = Console.ReadLine();
            Console.WriteLine("Введите количество: ");
            int symbolAmount = int.Parse(Console.ReadLine());

            ShowStringAndSymbolAmount(symbol, symbolAmount);
        }

        public static void ShowStringAndSymbolAmount(string symbol, int symbolAmount)
        {
            for (int i = 0; i < symbolAmount; i++)
            {
                Console.Write(symbol);
            }

            //string[] symbolArray = new string[symbolAmount];

            //for (int i = 0; i < symbolArray.Length; i++)
            //{
            //    symbolArray[i] = symbol;
            //}

            //Console.WriteLine();
            //Console.WriteLine("Ваша строка: ");

            //for (int i = 0; i < symbolArray.Length; i++)
            //{
            //    Console.Write(symbolArray[i]);
            //}
        }
    }
}
