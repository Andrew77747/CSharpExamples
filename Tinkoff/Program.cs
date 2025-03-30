using System;

namespace Tinkoff
{
    //Даны три неубывающих массива чисел. Найти число, которое присутствует во всех трех массивах.
    //Input: [1,2,4,5], [3,3,4], [2,3,4,5,6]

    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = { 1, 2, 4, 5 , 1233};
            int[] secondArray = { 3, 3 , 1233};
            int[] thirdArray = { 2, 3, 4, 5, 6, 1233 };

            int searchingNumber;

            for (int i = 0; i < firstArray.Length; i++)
            {
                for (int j = 0; j < secondArray.Length; j++)
                {
                    if (firstArray[i] == secondArray[j])
                    {

                        for (int k = 0; k < thirdArray.Length; k++)
                        {
                            if (secondArray[j] == thirdArray[k])
                            {
                                searchingNumber = secondArray[j];
                                Console.WriteLine(searchingNumber);
                            }
                        }
                    }
                }
            }
        }
    }
}
